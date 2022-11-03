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

namespace WpfEntityCrud
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
        WcfDBEntities _db = new WcfDBEntities();
        public InsertPage()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {
            GenderTable gendertbl = new GenderTable()
            {
                Name = txtname.Text,
                Gender = gendercombobox.Text
            };

            _db.GenderTables.Add(gendertbl);
            _db.SaveChanges();
            MainWindow.dg.ItemsSource = _db.GenderTables.ToList();
                this.Hide();
        }
    }
}
