using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;

namespace main.Execute.services
{
   public static class server
    {
        public static SqlCommand com;
        // this method to get con string
        private static SqlConnection getconnectionserver()
        {

            SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();

            build.DataSource = Properties.Settings.Default.servername;
            build.InitialCatalog = Properties.Settings.Default.database;
            build.IntegratedSecurity = true;


            return new SqlConnection(build.ConnectionString) ;

            
        }

        //this method to insert and update and delete and delete all data
        public static bool execute(string str,Action method)
        {
            using (SqlConnection con = getconnectionserver())
             {
                try
                {
                     com = new SqlCommand(str, con);
                    com.CommandType = CommandType.StoredProcedure;
                    method.Invoke();// method to send parameters
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    con.Close();

                 

                }
             

            }


         
        }



    }
}
