using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;


namespace WinTabex
{
    class OraConnect
    {
        OracleConnection con;
        private String connString = "";
        private String errorMsg = "";
        public Boolean Connect()
        {
            try
            {
                con = new OracleConnection();
                con.ConnectionString = connString; //"User Id=<username>;Password=<password>;Data Source=<datasource>"
                con.Open();
                return true;
            }
            catch (Exception exc){
                this.errorMsg = exc.Message;
                return false;
            }
        }

        public Boolean Close()
        {
            try 
            {
                con.Close();
                con.Dispose();
                this.errorMsg = "Connection Closed";
                return true;
            }
            catch (Exception exc){
                this.errorMsg = exc.Message;
                return false;
            }
        }

        public String getVersion() 
        { 
            String ver = con.ServerVersion;
            return ver;
        }

        public String getError()
        {
            return this.errorMsg;
        }

        public void setConnString(String conn)
        {
            this.connString = conn;
        }

        public Boolean getOracleResultSet(List<String> resultSet, String sql)
        {
            resultSet.Clear();
            OracleCommand comm = con.CreateCommand();
            comm.CommandText = sql;
            try {
                OracleDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                   resultSet.Add(reader.GetString(0));
                }
                return true;
            }
            catch (Exception exc)
            {
                this.errorMsg = exc.Message;
                return false;
            }
        }

        public Boolean createOracleInserts(List<String> inserts, String sql, String table)
        {
            inserts.Clear();
            OracleCommand comm = con.CreateCommand();
            comm.CommandText = sql;
            Int32 colCount = 0;
            try
            {
                OracleDataReader reader = comm.ExecuteReader();
                colCount = reader.FieldCount;
                
                while (reader.Read())
                {
                    String ins = "insert into "+table+" values(";
                    for (int i = 0; i < colCount; i++)
                    {
                        if (reader.IsDBNull(i))
                        {
                            // MessageBox.Show("it isDBNull");
                            ins += "null";
                        }
                        else
                        {
                            //MessageBox.Show(reader.GetDataTypeName(i).ToUpper());

                            if (reader.GetDataTypeName(i).ToUpper() == "DOUBLE")
                            {
                                ins += reader.GetDouble(i);
                            }
                            else if (reader.GetDataTypeName(i).ToUpper() == "VARCHAR2" ||
                                       reader.GetDataTypeName(i).ToUpper() == "CHAR")
                            {
                                if (reader.GetString(i).Length > 0)
                                {
                                    ins += "'" + reader.GetString(i).Replace("'", "''") + "'";
                                }
                                else
                                {
                                    ins += "'" + reader.GetString(i) + "'";
                                }
                            }
                            else if (reader.GetDataTypeName(i).ToUpper() == "INT32")
                            {
                                ins += reader.GetInt32(i);
                            }
                            else if (reader.GetDataTypeName(i).ToUpper() == "NUMBER")
                            {
                                ins += reader.GetDecimal(i);
                            }
                            else if (reader.GetDataTypeName(i).ToUpper() == "DATE")
                            {
                                if (reader.GetDateTime(i) != null)
                                {
                                    ins += "to_date('" + reader.GetDateTime(i).ToString() + "','DD-MON-RRRR HH24:MI:SS')";
                                }
                                else
                                {
                                    ins += "null";
                                }
                            }
                            else if (reader.GetDataTypeName(i).ToUpper() == "INT16")
                            {
                                ins += reader.GetInt16(i);
                            }
                            else if (reader.GetDataTypeName(i).ToUpper() == "DECIMAL")
                            {
                                ins += reader.GetDecimal(i);
                            }
                            else if (reader.GetDataTypeName(i).ToUpper() == "SINGLE")
                            {
                                ins += reader.GetFloat(i);
                            }

                            else
                            {
                                ins += "'##'";
                            }
                        }

                        if (i != colCount-1)
                        {
                            ins += ",";
                        }
                        else
                        {
                            ins += ");";
                        }
                    }
                    //MessageBox.Show(ins);
                    inserts.Add(ins);
                }
                return true;
            }
            catch (Exception exc)
            {
                this.errorMsg = exc.Message;
                return false;
            }
        }
    }
}
