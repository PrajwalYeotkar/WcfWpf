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
        int id = 0;

        public ViewPage()
        {
            InitializeComponent();
            Service1Client client = new Service1Client();
            var lst = client.GetPerson();

            foreach (var person in lst)
            {
                Dictionary<String, String> map = new Dictionary<String, String>()
                {
                    {"id",person.Id.ToString()},
                    {"Mbnum",person.MobileNumber.ToString()},
                    {"Address",person.Address},
                    {"Email",person.Email},
                    {"Name",person.Name},
                };
                list.Add(map);
            }

        }

        private void btnview_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<String, String> person1 = list[id];
                txtid.Text = person1["id"];
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
            Dictionary<String, String> person1 = list[++id];
            txtid.Text = person1["id"];
            txtname.Text = person1["Name"];
            txtaddress.Text = person1["Address"];
            txtemail.Text = person1["Email"];
            txtmbnum.Text = person1["Mbnum"];

        }

        private void btnprevious_Click(object sender, RoutedEventArgs e)
        {
            if (id >= 1)
            {
                Dictionary<String, String> person1 = list[--id];
                txtid.Text = person1["id"];
                txtname.Text = person1["Name"];
                txtaddress.Text = person1["Address"];
                txtemail.Text = person1["Email"];
                txtmbnum.Text = person1["Mbnum"];
            }

        }
    }
}
