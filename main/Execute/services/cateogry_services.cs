using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace main.Execute.services
{
static class cateogry_services
    {

        public static bool cateogryinsert(int id ,string name)
        {
            return server.execute("cateogry_insert", () => cat_par_insert(id,name,server.com));
            
        }


        // this method to add insert into cateogry
        private static void cat_par_insert(int id,string name,SqlCommand com)
        {
            com.Parameters.Add("@id",SqlDbType.Int).Value=id;
            com.Parameters.Add("@name", SqlDbType.NVarChar).Value=name;
        }


        //------------------------------
        //this method to delete
        public static bool cateogrydelete(int id,string name)
        {
            return server.execute("[cateogry_delete]", () => cat_par_del(id,name,  server.com));
            
        }


     
        private static void cat_par_del(int id, string name,  SqlCommand com)
        {
            com.Parameters.Add("@id", SqlDbType.Int).Value = id;
            
        }
        //------------------------------
        //this method to update
        public static bool cateogryupdate(int id, string name)
        {
            return server.execute("[cateogry_update]", () => cat_par_update(id , name , server.com));
             
        }


        
        private static void cat_par_update(int id, string name, SqlCommand com)
        {
            com.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

        }

    }
}
