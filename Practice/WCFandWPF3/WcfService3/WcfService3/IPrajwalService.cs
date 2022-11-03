using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPrajwalService" in both code and config file together.
    [ServiceContract]
    public interface IPrajwalService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        int Insert(GenderTable GenderPar);

        [OperationContract]
        Dictionary<String,String> View(int Id);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
}
