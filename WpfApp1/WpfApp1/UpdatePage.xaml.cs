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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        WcfDBEntities _db = new WcfDBEntities();
        int id;
        public UpdatePage(int GenderTableId)
        {
            InitializeComponent();
            id = GenderTableId;
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            GenderTable UpdateGenderTable = (from g in _db.GenderTables
                                             where g.Id == id
                                             select g).Single();
            UpdateGenderTable.Name = nametextbox.Text;
            UpdateGenderTable.Gender = gendercomboBox.Text;
            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.GenderTables.ToList();
            this.Hide();
        }
    }
}
