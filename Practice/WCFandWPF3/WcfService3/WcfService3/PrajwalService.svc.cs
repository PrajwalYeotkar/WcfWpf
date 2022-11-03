using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrajwalService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrajwalService.svc or PrajwalService.svc.cs at the Solution Explorer and start debugging.
    public class PrajwalService : IPrajwalService
    {
        public PrajwalService()
        {
            ConnectToDb();
        }
        SqlConnection conn;
        SqlCommand comm;

        SqlConnectionStringBuilder connStringBuilder;

        void ConnectToDb()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "IN-LP-TR-09\\SQLEXPRESS";
            connStringBuilder.InitialCatalog = "WcfDB";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;
            comm = new SqlCommand();
            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public int Insert(GenderTable GenderPar)
        {
            try
            {
                comm.CommandText = "Insert into GenderTable(Id,Name,Gender) values(@Id,@Name,@Gender)";
                //comm.Parameters.AddWithValue("Id", GenderPar.Id);
                comm.Parameters.AddWithValue("Name", GenderPar.Name);
                comm.Parameters.AddWithValue("Gender", GenderPar.Gender);

                comm.CommandType = System.Data.CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public Dictionary<String, String> View(int Id)
        {
            var context = new WcfDBEntities();
            var data = context.GenderTable.Single(e => e.Id == Id);
            var list = new Dictionary<String, String>()
            {
                {
                    "Id",data.Id.ToString()
                },
                    {
                      "Name",data.Name
                },
                {
                   "Gender",data.Gender
                }
            };
            return list;
        }
    }
}
