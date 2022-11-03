using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace WcfApp2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPrajwalService
    {

        [OperationContract]
        Int32 Insert(PrajwalContact GenderPar);

        //[OperationContract]
        //int Update(PrajwalContact GenderPar);

        //[OperationContract]
        //List<PrajwalService> SelectAll();

        //[OperationContract]
        //int Delete(PrajwalContact GenderPar);   

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class PrajwalContact
    {
        private Int32 id;
        private String name;
        private String gender;

        [DataMember]
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }
}
