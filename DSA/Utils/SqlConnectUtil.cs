//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dsa.Utils
//{
//    public class SqlConnectUtil
//    {
//        private readonly string _connectionString;

//        public SqlConnectUtil(string connectionString)
//        {
//            Logger.Write("Initializing DB connection: {0}", connectionString);
//            _connectionString = connectionString;
//        }

//        public DataTable Execute(string sql)
//        {
//            Logger.Write("Executing DB Query: {0}", sql);
//            var table = new DataTable();
//            using (var connection = new SqlConnection(_connectionString + ";Column Encryption Setting=enabled"))
//            {
//                connection.Open();
//                var command = new SqlCommand(sql, connection);
//                command.CommandTimeout = 300;
//                table.Load(command.ExecuteReader());

//                Logger.Write("The query executed.");
//                return table;
//            }
//        }        

//        public DataTable UpdateUserRoleToOMWGO(string userID)
//        {
//            return Execute(string.Format("update [dbo].[Master_User_Detail] set asp_RoleId='2E50E3A6-8145-4B94-97FB-FC5FAF148501' where Nt_Login_Name='" + userID + "'"));
//        }

//        public DataTable UpdateUserRoleToOP(string userID)
//        {
//            return Execute(string.Format("update [dbo].[Master_User_Detail] set asp_RoleId='88F19DA7-6F85-4737-913C-01BE1B57B731' where Nt_Login_Name='" + userID + "'"));
//        }

//        public string GetUserRole(string userID)
//        {
//            string query = "select top 100 * from [dbo].[Master_User_Detail] where Nt_Login_Name='" + userID + "'";
//            var results = Execute(query);
//            string role = results.Rows[0][9].ToString();
//            return role;
//        }

//        public void InsertWorkGroupMembership(string userId, string wgId)
//        {
//            string createBy = @"AMERICAS\ProcessDSASEC2";
//            string getWGs = @"select * from [dbo].[User_WG_Association] where Nt_Login_Name='" + userId + "'";
//            var wgResults = Execute(getWGs);

//            string getWGs1 = @"select * from [dbo].[User_WG_Association] where NT_Login_Name = '" + userId + "' AND Work_Group_ID = '" + wgId + "'";
//            var wgResults1 = Execute(getWGs1);

//            if (wgResults.Rows.Count == 0)
//            {
//                Logger.Write("User is not a member of any Work Group");
//                string query = @"exec InsertUserWGAssociation_SP '" + wgId + "', '" + userId + "','" + createBy + "'";
//                var results = Execute(query);              
//            }
//            else
//            {
//                if (wgResults1.Rows.Count == 0)
//                {
//                    Logger.Write("WG is not associated with User");
//                    string query = @"exec InsertUserWGAssociation_SP '" + wgId + "', '" + userId + "','" + createBy + "'";
//                    var results = Execute(query);                  
//                }
//            }
//        }
//    }
//}

