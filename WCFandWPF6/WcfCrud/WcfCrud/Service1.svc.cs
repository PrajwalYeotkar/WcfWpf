using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfCrud
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Person conv(int id, int mobilenumber, string name,string address, string email)
        {
            Person p = new Person
            {
                Id = id,
                MobileNumber = mobilenumber,
                Name = name,
                Address = address,
                Email = email
            };
            return p;
        }

        public void DeletePerson(int id)
        {
            PersonContext po = new PersonContext();
            var c = (from per in po.Persons
                     where per.Id == id
                     select per).First();
            po.Persons.Remove(c);
            po.SaveChanges();   
        }

        public string GetData(int value)
        {
            return string.Format("You entered {0}", value);
        }

        public IEnumerable<Person> GetPerson()
        {
            List<Person> li = new List<Person>();
            PersonContext po = new PersonContext();
            li = po.Persons.ToList();
            return li;
        }

        public void InsertPerson(Person pobj)
        {
            PersonContext po = new PersonContext();
            po.Persons.Add(pobj);
            po.SaveChanges();
        }

        public Dictionary<String,String> SearchPerson(int id)
        {
            PersonContext po = new PersonContext();
            var c = (from per in po.Persons
                     where per.Id == id
                     select per).First();
            Dictionary<String, String> result = new Dictionary<String, String>() {
                { "Id",c.Id.ToString()},
                { "Name",c.Name},
                { "Address",c.Address},
                { "Mbnum",c.MobileNumber.ToString()},
                { "Email",c.Email}
            };

            return result;
        }

        public void UpdatePerson(Person pobj)
        {
            PersonContext po = new PersonContext();
            var c = (from per in po.Persons
                     where per.Id == pobj.Id
                     select per).First();
            c.Name = pobj.Name;
            c.Address = pobj.Address;
            c.MobileNumber = pobj.MobileNumber;
            po.SaveChanges();
        }
    }
}
