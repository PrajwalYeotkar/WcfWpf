using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public gettestdata GetInfo()
        {
            gettestdata g = new gettestdata();
            SqlConnection con = new SqlConnection("Data Source=IN-LP-TR-09\\SQLEXPRESS;Initial Catalog=WcfDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from GenderTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            g.GenderTable = dt;
            return g;

        }

        public string Insert(InsertGender GenderPar)
        {
            string msg;
            SqlConnection con = new SqlConnection("Data Source=IN-LP-TR-09\\SQLEXPRESS;Initial Catalog=WcfDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd;
            cmd= new SqlCommand("Insert into InsertGender(Name,Gender) values(@Name,@Gender)",con);
            cmd.Parameters.AddWithValue("@Name",GenderPar.Name);
            cmd.Parameters.AddWithValue("Gender", GenderPar.Gender);

            int g = cmd.ExecuteNonQuery();
            if(g==1)
            {
                msg = "Successfully Inserted";
            }
            else
            {
                msg = "Failed to Insert";
            }

            return msg;

        }

        
    }
}
