using ITXCatalogueManager.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITXCatalogueManager.SQLCon
{
    class SQLCon
    {
        public DataTable sendNewEntity(NewEntity u)
        {
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(Properties.Settings.Default.SqlConQuery))
                try
                {
                    using (var command = new SqlCommand("Update_Entities", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        conn.Open();
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@IDl", (object)u.Id_Entity?? DBNull.Value);
                        command.Parameters.AddWithValue("@IDc", u.Id_City);
                        command.Parameters.AddWithValue("@IDe", u.Id_EntityType);
                        command.Parameters.AddWithValue("@lat", u.Latitude);
                        command.Parameters.AddWithValue("@lon", u.Longitude);
                        command.Parameters.AddWithValue("@descrip", u.description);
                        command.Parameters.AddWithValue("@url", u.URL);
                        command.Parameters.AddWithValue("@code", u.code);
                        command.Parameters.AddWithValue("@Status", u.Status);
                        var Smsg = command.Parameters.Add("msg", SqlDbType.VarChar);
                        Smsg.Direction = ParameterDirection.ReturnValue;
                        var IDS = command.Parameters.Add("ID", SqlDbType.VarChar);
                        IDS.Direction = ParameterDirection.ReturnValue;
                        var Val = command.Parameters.Add("Validacion", SqlDbType.VarChar);
                        Val.Direction = ParameterDirection.ReturnValue;
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            dt.Load(dr);
                        }
                        conn.Close();
                    }
                    //Console.WriteLine(dt.Rows[0].ItemArray[1].ToString()+"+");
                }
                catch (SqlException a)
                {
                    Console.WriteLine("The process failed: {0}", a.ToString());
                }
            return dt;
        }
        public DataTable ll()
        {
            DataTable dt = new DataTable();




            return dt;
        }
    }
}
