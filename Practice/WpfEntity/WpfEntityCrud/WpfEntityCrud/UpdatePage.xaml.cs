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
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        WcfDBEntities _db = new WcfDBEntities();
        int Id;
        public UpdatePage(int memberId)
        {
            InitializeComponent();
            Id = memberId;  
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            GenderTable updategender = (from g in _db.GenderTables
                                        where g.Id == Id
                                        select g).Single();
            updategender.Name = txtname.Text;
            updategender.Gender = gendercombobox.Text;

            _db.SaveChanges();
            MainWindow.dg.ItemsSource = _db.GenderTables.ToList();
            this.Hide();
        }

    }
}
