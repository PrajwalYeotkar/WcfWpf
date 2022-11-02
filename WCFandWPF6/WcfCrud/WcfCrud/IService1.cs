using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfCrud
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        IEnumerable<Person> GetPerson();

        [OperationContract]
        void InsertPerson(Person pobj);
        [OperationContract]
        void UpdatePerson(Person pobj);
        [OperationContract]
        void DeletePerson(int Id);

        [OperationContract]
        Person conv(int id, int mobilenumber, string name, string address, string email);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Person
    {
        [DataMember]
        [Key]
        [Required]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string Name { get; set; }
        [DataMember]
        [Required]
        public string Address { get; set; }
        [DataMember]
        [Required]
        public string Email { get; set; }   
        [DataMember]
        [Required]
        public Int32 MobileNumber { get; set; }   
    }
}
