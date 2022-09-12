using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace auto
{
    internal class KL
    
    {
        public static string connectionString = @"";
        public void SignIn(string login, out string password, out bool pr)
        {
            password = string.Empty;
            pr = true;
           using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string zap = $"SELECT password FROM Users Where login ='{login}'";
                SqlCommand command = new SqlCommand(zap, con);
                try { password = command.ExecuteScalar().ToString(); }
                catch (Exception) { password = string.Empty; }
                con.Close();
            }
            if (password=="")
            {
                pr = false;
            }
            
        }
        
            
    }
}
