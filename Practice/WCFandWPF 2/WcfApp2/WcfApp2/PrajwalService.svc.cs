using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfApp2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrajwalService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrajwalService.svc or PrajwalService.svc.cs at the Solution Explorer and start debugging.
    public class PrajwalService : IPrajwalService
    {
        string ConString = "Data Source=IN-LP-TR-09\\SQLEXPRESS;Initial Catalog=WcfDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        

        //public int Delete(PrajwalContact GenderPar)
        //{
        //    using (SqlConnection con = new SqlConnection(ConString))
        //    {
        //        SqlCommand comm = con.CreateCommand();
        //        try
        //        {
        //            comm.CommandText = "Delete from GenderTable where Id=@Id";

        //            comm.CommandType = CommandType.Text;
        //            con.Open();

        //            return comm.ExecuteNonQuery();
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        finally
        //        {
        //            if (con != null)
        //            {
        //                con.Close();
        //            }
        //        }
        //    }
        //}

        public int Insert(PrajwalContact GenderPar)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                SqlCommand comm = con.CreateCommand();
                try
                {
                    comm.CommandText = "Insert into GenderTable(Id,Name,Gender) values(@Id,@Name,@Gender)";
                    comm.Parameters.AddWithValue("Id", GenderPar.Id);
                    comm.Parameters.AddWithValue("Name", GenderPar.Name);
                    comm.Parameters.AddWithValue("Gender", GenderPar.Gender);

                    comm.CommandType = CommandType.Text;
                    con.Open();

                    return comm.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }

            }
        }

        //public List<PrajwalService> SelectAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public int Update(PrajwalContact GenderPar)
        //{
        //    using (SqlConnection con = new SqlConnection(ConString))
        //    {
        //        SqlCommand comm = con.CreateCommand();
        //        try
        //        {
        //            comm.CommandText = "Update GenderTable set Name=@Name,Gender=@Gender where Id=@Id";
        //            comm.Parameters.AddWithValue("Name", GenderPar.Name);
        //            comm.Parameters.AddWithValue("Gender", GenderPar.Gender);

        //            comm.CommandType = CommandType.Text;
        //            con.Open();

        //            return comm.ExecuteNonQuery();
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        finally
        //        {
        //            if (con != null)
        //            {
        //                con.Close();
        //            }
        //        }
        //    }
        //}
    }
}

