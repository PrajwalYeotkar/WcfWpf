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

namespace WpfEntityCrud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WcfDBEntities _db = new WcfDBEntities();
        public static DataGrid dg;

        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            myDataGrid.ItemsSource = _db.GenderTables.ToList();
            dg = myDataGrid;
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {
            InsertPage IPage = new InsertPage();    
            IPage.ShowDialog(); 
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as GenderTable).Id;
            UpdatePage UPage = new UpdatePage(Id);
            UPage.ShowDialog(); 
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as GenderTable).Id;
            var deleteMember = _db.GenderTables.Where(t => t.Id == Id).Single();
            _db.GenderTables.Remove(deleteMember);  
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.GenderTables.ToList();
            this.Hide();
        }
    }


}
