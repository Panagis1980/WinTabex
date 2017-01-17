using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinTabex
{
    class OraConsole
    {

        private String username = "";
        private String password = "";
        private String sid = "";
        private String sysdba = "";
        private String table = "";
        private String whereClause = "";
        private String owner = "";
        private List<String> resultSet = new List<String>(0);

        public OraConsole(String[] args)
        {
            Int32 slashPos = 0;
            Int32 atPos = 0;

            if ((args[0].Contains('/') && args[0].Contains('@')) && (args.Length > 1)) 
            {
                
                if (args.Length > 2)  //where clause is specified
                {
                    whereClause = args[2];
                }
                
                if (args.Length > 3)  //owner is specified
                {
                    owner = args[3].ToUpper()+".";
                }

                slashPos = args[0].IndexOf('/');
                atPos = args[0].IndexOf('@');
                username = args[0].Substring(0, slashPos).ToUpper();
                password = args[0].Substring(slashPos + 1, atPos - slashPos - 1).ToUpper();
                sid = args[0].Substring(atPos + 1).ToUpper();
                table = args[1].ToUpper();
                System.Diagnostics.Debug.WriteLine(username);
                System.Diagnostics.Debug.WriteLine(password);
                System.Diagnostics.Debug.WriteLine(sid);
               // System.Diagnostics.Debug.WriteLine(args[1]);
               // System.Diagnostics.Debug.WriteLine(args[2]);

                List<String> resultSet = new List<String>(0);
                OraConnect OraTest = new OraConnect();
                // "User Id=<username>;Password=<password>;Data Source=<datasource>"
                String conn = "Data Source=" + sid + ";User Id=" + username + ";Password=" + password + ";";

                OraTest.setConnString(conn);
                //conn = conn + "DBA Privilege=SYSDBA;";
                if (!OraTest.Connect())
                {
                    Console.WriteLine(OraTest.getError());
                    resultSet.Clear();
                    OraTest.Close();
                }
                else
                {

                    String sql = "SELECT * FROM " + owner + table + " ";

                    if (whereClause.Length > 0)
                    {
                        sql += "WHERE "+ whereClause;
                    }

                    System.Diagnostics.Debug.WriteLine(sql);
                    if (!OraTest.createOracleInserts(resultSet, sql, table))
                    {
                        Console.WriteLine(OraTest.getError());
                        resultSet.Clear();
                        OraTest.Close();
                        Console.WriteLine("Failed fetching inserts...");
                    }
                    else
                    {
                        OraTest.Close();

                        foreach (var item in resultSet)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Correct syntax: (0)username/password@Host (1)table (2)[where clause without WHERE] (3)[table owner].");
                Console.WriteLine("Where clause and table owner are not mandatory. Order cannot be changed. "
                                    +"For (2) use 1=1 if you want to use the owner(3) param.");
                Console.WriteLine("AS SYSDBA is not supported currently. Sorry!");
            }
        }

        
    }
}
