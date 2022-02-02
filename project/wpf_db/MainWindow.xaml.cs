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

namespace EmployeeDetails
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
        void getdata()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=apoorva;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from employee_new1", con);

            DataTable dt = new DataTable("student");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            Datagridview.ItemsSource = dt.DefaultView;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=apoorva;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into employee_new1(id ,name,date_of_Birth) values(@id,@name,@date_of_birth) ", con);

            cmd.Parameters.AddWithValue("@id", textid.Text);
            cmd.Parameters.AddWithValue("@name", textname.Text);
            cmd.Parameters.AddWithValue("@date_of_birth", textdateofbirth.Text.ToString());




            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            getdata();

            MessageBox.Show("Data inserted");


        }


        private void update_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=apoorva;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update employee_new1 set name = @name ,date_of_Birth=@date_of_birth where id = @id", con);
            cmd.Parameters.AddWithValue("@id", textid.Text);
            cmd.Parameters.AddWithValue("@name", textname.Text);
            cmd.Parameters.AddWithValue("@date_of_birth", textdateofbirth.Text.ToString());

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data updated");
            getdata();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            getdata();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=apoorva;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Delete from employee_new1 where id = @id", con);
            cmd.Parameters.AddWithValue("@id", textid.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            getdata();
            MessageBox.Show("Data deleted Sucessfully");

        }



    }


}
