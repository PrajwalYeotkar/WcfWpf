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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        int Id = 1;
        public View()
        {
            InitializeComponent();
        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {
                int Id = 1;
                PrajwalServiceClient client = new PrajwalServiceClient();
                Dictionary<String, String> Member = client.View(Id);
                labelid.Content = Member["Id"];
                labelname.Content = Member["Name"];
                labelgender.Content = Member["Gender"];

                client.Close();
            
        }

        private void previousbtn_Click(object sender, RoutedEventArgs e)
        {
            if (Id >= 1)
            {
                PrajwalServiceClient client = new PrajwalServiceClient();
                Dictionary<String, String> Member = client.View(Id);

                labelid.Content = Member["Id"];
                labelname.Content = Member["Name"];
                labelgender.Content = Member["Gender"];

                client.Close();
                Id--;
            }
            else
            {
                this.Close();
            }
        }

        private void nextbtn_Click(object sender, RoutedEventArgs e)
        {
            if (Id <= 5)
            {
                PrajwalServiceClient client = new PrajwalServiceClient();
                Dictionary<String, String> Member = client.View(Id);

                labelid.Content = Member["Id"];
                labelname.Content = Member["Name"];
                labelgender.Content = Member["Gender"];

                client.Close();
                Id++;
            }
            else
            {
                this.Close();
            }
        }
    }
}
