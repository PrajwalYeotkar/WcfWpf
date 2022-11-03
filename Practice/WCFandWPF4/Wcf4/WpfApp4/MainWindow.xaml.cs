using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp4.ServiceReference1;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CrudDemo_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {
            Service1Client client = new Service1Client();

            // Use the 'client' variable to call operations on the service.
            InsertGender g = new InsertGender();
            g.Name = txtname.Text;
            g.Gender = comboboxgender.Text;

            string r = client.Insert(g);
            

            // Always close the client.
            client.Close();
        }

        private void btnview_Click(object sender, RoutedEventArgs e)
        {
            Service1Client client = new Service1Client();
            gettestdata g = new gettestdata();
            g = client.GetInfo();
            DataTable dt = new DataTable();
            dt = g.GenderTable;
            GridView1.DataContext = dt;  
        }
    }
}
