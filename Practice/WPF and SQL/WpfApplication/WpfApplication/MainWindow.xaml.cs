using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection con = new SqlConnection("Data Source=IN-LP-TR-09\\SQLEXPRESS;Initial Catalog=WcfDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void clear()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtgender.Text = "";
        }
        private void show()
        {
            da = new SqlDataAdapter("Select * from GenderTable", con);
            dt = new DataTable();
            da.Fill(dt);
            gdView.ItemsSource = dt.DefaultView;
            txtid.Focus();
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Crud_Loaded(object sender, RoutedEventArgs e)
        {
            show();
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {
            cmd = new SqlCommand("Insert into GenderTable(Id,Name,Gender) values(@Id,@Name,@Gender)", con);
            cmd.Parameters.AddWithValue("@Id", txtid.Text);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Gender", txtgender.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted successfuly");
            show();
            clear();
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            cmd = new SqlCommand("Update GenderTable Set Name=@Name, Gender=@Gender where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", txtid.Text);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Gender", txtgender.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated successfuly");
            show();
            clear();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            cmd = new SqlCommand("Delete from GenderTable where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", txtid.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted successfuly");
            show();
            clear();
        }

        private void gdView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            try
            {
                if(gdView.Items.Count > 0)
                {
                    txtid.Text = ((DataRowView)gdView.SelectedItem).Row["Id"].ToString();
                    txtname.Text = ((DataRowView)gdView.SelectedItem).Row["Name"].ToString();
                    txtgender.Text = ((DataRowView)gdView.SelectedItem).Row["Gender"].ToString();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
