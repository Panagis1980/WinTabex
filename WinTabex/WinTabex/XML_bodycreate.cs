using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WinTabex
{
    class XML_bodycreate
    {
        private String errorMsg = "";

        public List<String> XML_create(DataSet ds)
        {
            List<String> body = new List<String>(0);
            
            var distinctStatus = ds.Tables[0].AsEnumerable().Select(row => new
            {
                status = row.Field<String>("d_status")
            }).Distinct();
            foreach (var s in distinctStatus)
            {
                body.Add("\t<ConditionBranch SymbolId=\"" + Guid.NewGuid().ToString("N") + "\">");
                body.Add("\t  <SimpleConditionExpression PropertyShortName=\"DetailStatus\" PropertyLongName=\"ApplicationId.DetailStatus\" PropertyType=\"xs:string\" OperatorID=\"1\" Value=\"" + s.status + "\" />");
                body.Add("\t  <Statements>");
                body.Add("\t\t<DecisionTable SymbolId=\"" + Guid.NewGuid().ToString("N") + "\">");
                body.Add("\t\t  <Conditions>");
                String conditionId = Guid.NewGuid().ToString("N");
                body.Add("\t\t\t<Condition Id=\"" + conditionId + "\" PropertyShortName=\"ActionId\" PropertyLongName=\"ActionId\" PropertyType=\"xs:string\" Value=\"\" />");
                body.Add("\t\t  </Conditions>");
                body.Add("\t\t  <Actions>");
                String assignTargetNodeGuid = Guid.NewGuid().ToString("N");
                String assignTargetStatusGuid = Guid.NewGuid().ToString("N");
                String assignNewNodeIdGuid = Guid.NewGuid().ToString("N");
                body.Add("\t\t\t<Assignment Id=\"" + assignTargetNodeGuid +  "\" PropertyLongName=\"TargetNode\" PropertyType=\"xs:string\" OperatorID=\"1\" Value=\"\" />");
                body.Add("\t\t\t<Assignment Id=\"" + assignTargetStatusGuid + "\" PropertyLongName=\"TargetStatus\" PropertyType=\"xs:string\" OperatorID=\"1\" Value=\"\" />");
                body.Add("\t\t\t<Assignment Id=\"" + assignNewNodeIdGuid + "\" PropertyLongName=\"NewNodeId\" PropertyType=\"xs:string\" OperatorID=\"1\" Value=\"\" />");
                body.Add("\t\t  </Actions>");
                body.Add("\t\t  <ColumnHeaders />");
                body.Add("\t\t  <RowHeaders>");

                var results = from myRow in ds.Tables[0].AsEnumerable() where myRow.Field<String>("d_status") == s.status
                              select myRow;
                
                // For each RowHeader/Action
                List<String> rowHeaderGUID = new List<String>(0);
                foreach (DataRow row in results)
                {
                    String headerGUID = Guid.NewGuid().ToString("N");
                    rowHeaderGUID.Add(headerGUID);
                    body.Add("\t\t\t<Case Id=\""+ headerGUID + "\" Condition=\""+ conditionId + "\" OperatorID=\"1\" Value=\"" + row.Field<string>("action") + "\" />");
                }
                body.Add("\t\t  </RowHeaders>");
                body.Add("\t\t  <Data>");

                Int32 rowCount = 0;
                foreach (DataRow row in results)
                {
                   
                    String headerGUID = rowHeaderGUID.ToArray().GetValue(rowCount).ToString();
                    body.Add("\t\t\t<Field Id=\"" + Guid.NewGuid().ToString("N") + "\" Action=\"" + assignTargetNodeGuid +
                        "\" Column=\"\" Row=\"" + headerGUID + "\" OperatorID=\"1\" Value=\""+ row.Field<string>("to_g_status") + "\" />");
                    body.Add("\t\t\t<Field Id=\"" + Guid.NewGuid().ToString("N") + "\" Action=\"" + assignTargetStatusGuid +
                         "\" Column=\"\" Row=\"" + headerGUID + "\" OperatorID=\"1\" Value=\"" + row.Field<string>("to_d_status") + "\" />");
                    body.Add("\t\t\t<Field Id=\"" + Guid.NewGuid().ToString("N") + "\" Action=\"" + assignNewNodeIdGuid +
                         "\" Column=\"\" Row=\"" + headerGUID + "\" OperatorID=\"1\" Value=\"" + row.Field<string>("new_nod_id") + "\" />");
                    rowCount += 1;
                }
                body.Add("\t\t  </Data>");
                body.Add("\t\t</DecisionTable>");
                body.Add("\t  </Statements>");
                body.Add("\t</ConditionBranch>");
            }
            return body;
        }

        public String getError()
        {
            return this.errorMsg;
        }
    }
}
