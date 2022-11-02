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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WcfDBEntities _db = new WcfDBEntities();
        public static DataGrid datagrid;
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        //private readonly Random _random = new Random(); 
        //private void b1_Click(object sender, RoutedEventArgs e)
        //{
        //    PrajwalServiceClient client = new PrajwalServiceClient();
        //    var output = client.GetData(_random.Next(1000));
        //    text1.Text = output.ToString();
        //    client.Close();
        //}

        private void Load()
        {
            myDataGrid.ItemsSource = _db.GenderTables.ToList();
            datagrid = myDataGrid;
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            InsertPage Ipage = new InsertPage();
            Ipage.ShowDialog();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = (myDataGrid.SelectedItem as GenderTable).Id;
            UpdatePage UPage = new UpdatePage(id);
            UPage.ShowDialog(); 
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = (myDataGrid.SelectedItem as GenderTable).Id;
            var deleteGenderTable = _db.GenderTables.Where(g => g.Id == id).FirstOrDefault(); // Single()
            _db.GenderTables.Remove(deleteGenderTable);
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.GenderTables.ToList();
            this.Hide();
        }
    }
}
