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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WcfService3;

namespace WpfApp3
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

        private void DisplayBtn_Click(object sender, RoutedEventArgs e)
        {
            PrajwalServiceClient client = new PrajwalServiceClient();

            // Use the 'client' variable to call operations on the service.
            var output = client.GetData(11);
            text1.Text = output.ToString();
            // Always close the client.
            client.Close();
        }

        
        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PrajwalServiceClient client = new PrajwalServiceClient();

                // Use the 'client' variable to call operations on the service.
                GenderTable g = new GenderTable();
                g.Id = Convert.ToInt32(idtextbox.Text);
                g.Name = nametextbox.Text;
                g.Gender = gendercombobox.Text;

                if (client.Insert(g) == 1)
                {
                    MessageBox.Show("person information inserted sucesfully");
                }
                client.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {
            var viewWindow = new View();
            viewWindow.Show();
            this.Close();
        }
    }
}
