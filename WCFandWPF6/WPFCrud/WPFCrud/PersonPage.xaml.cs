using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
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
using WPFCrud.ServiceReference1;

namespace WPFCrud
{
    /// <summary>
    /// Interaction logic for PersonPage.xaml
    /// </summary>
    public partial class PersonPage : Window
    {
        public PersonPage()
        {
            InitializeComponent();
        }

        private void Crud_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnview_Click(object sender, RoutedEventArgs e)
        {
            var viewpage = new ViewPage();
            viewpage.Show();
            
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {
            int id, mobilenumber;
            string name, address, email;
            Int32.TryParse(txtid.Text, out id);
            Int32.TryParse(txtmbnum.Text, out mobilenumber);
            name = txtname.Text;
            address = txtaddress.Text;
            email = txtemail.Text;
            Service1Client client = new Service1Client();
            var p = client.conv(id, mobilenumber, name, address, email);
            client.InsertPerson(p);
            MessageBox.Show("Successfully Inserted");
            txtid.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtmbnum.Text = "";
            txtname.Text = "";
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            int id, mobilenumber;
            string name, address, email;
            Int32.TryParse(txtid.Text, out id);
            Int32.TryParse(txtmbnum.Text, out mobilenumber);
            name = txtname.Text;
            address = txtaddress.Text;
            email = txtemail.Text;
            Service1Client client = new Service1Client();
            var p = client.conv(id, mobilenumber, name, address, email);
            client.UpdatePerson(p);
            MessageBox.Show("Successfully Updated");
            txtid.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtmbnum.Text = "";
            txtname.Text = "";
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            int id;
            Int32.TryParse(txtid.Text, out id);
            Service1Client client = new Service1Client();
            client.DeletePerson(id);
            MessageBox.Show("Successfully Deleted");
            txtid.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtmbnum.Text = "";
            txtname.Text = "";


        }

        
    }
}
