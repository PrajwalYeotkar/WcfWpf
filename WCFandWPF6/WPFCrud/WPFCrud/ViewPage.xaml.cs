using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WcfCrud;
using WPFCrud.ServiceReference1;

namespace WPFCrud
{
    /// <summary>
    /// Interaction logic for ViewPage.xaml
    /// </summary>
    public partial class ViewPage : Window
    {
        List<Dictionary<String, String>> list = new List<Dictionary<String, String>>();

        int id,len;

        public ViewPage()
        {
            InitializeComponent();
            Service1Client client = new Service1Client();
            var lst = client.GetPerson();
            id = 0;
            foreach (var person in lst)
            {
                Dictionary<String, String> map = new Dictionary<String, String>()
                {
                    {"Id",person.Id.ToString()},
                    {"Mbnum",person.MobileNumber.ToString()},
                    {"Address",person.Address},
                    {"Email",person.Email},
                    {"Name",person.Name},
                };
                list.Add(map);
            }
            len=list.Count;
//            MessageBox.Show("Length : " + len);
        }

        private void btnview_Click(object sender, RoutedEventArgs e)
        {
            id = 0;
            Dictionary<String, String> person1 = list[id];
                txtid.Text = person1["Id"];
                txtname.Text = person1["Name"];
                txtaddress.Text = person1["Address"];
                txtemail.Text = person1["Email"];
                txtmbnum.Text = person1["Mbnum"];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var viewpagedatagrid = new ViewDataGridPage();
            viewpagedatagrid.Show();
        }

        private void btnnext_Click(object sender, RoutedEventArgs e)
        {
            if (id < len-1)
            {
                Dictionary<String, String> person1 = list[++id];
                txtid.Text = person1["Id"];
                txtname.Text = person1["Name"];
                txtaddress.Text = person1["Address"];
                txtemail.Text = person1["Email"];
                txtmbnum.Text = person1["Mbnum"];
            }
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var crudpage = new PersonPage();
            crudpage.Show();
            this.Close();
        }

        private void btnprevious_Click(object sender, RoutedEventArgs e)
        {
            if (id >= 1)
            {
                Dictionary<String, String> person1 = list[--id];
                txtid.Text = person1["Id"];
                txtname.Text = person1["Name"];
                txtaddress.Text = person1["Address"];
                txtemail.Text = person1["Email"];
                txtmbnum.Text = person1["Mbnum"];
            }

        }
    }
}
