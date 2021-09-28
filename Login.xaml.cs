using System;
/// eigens hinzugefügt START
using MySql.Data.MySqlClient;
using System.Data;
/// eigens hinzugefügt STOP
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace daterprojekt
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            var con = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=dater_benutzer_datenbank");
            string query = "SELECT * FROM benutzer_table WHERE Benutzer_Nutzername = '" + txtbox.Text.Trim() + "' AND Benutzer_Passwort = '" + pwbox.Password.Trim() + "'";
            con.Open();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM benutzer_table WHERE Benutzer_Nutzername = '" + txtbox.Text.Trim() + "' AND Benutzer_Passwort = '" + pwbox.Password.Trim() + "'";
            // Login LogInWindow = new Login();
            ///this.Close();

            var con = new MySqlConnection("server=127.0.0.1;username=root;password=;database=dater_benutzer_datenbank");
            try
            {
                MySqlDataAdapter msda = new MySqlDataAdapter(query,con);
                DataTable DT = new DataTable();
                msda.Fill(DT);
                if (DT.Rows.Count == 1 )
                {
                    MainWindow MainWindow = new MainWindow();
                    MainWindow.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            ///            Login LogInWindow = new Login();
            ///            MainWindow MainWindow = new MainWindow();
            ///            MainWindow.Show();
            ///            this.Close();
        }
    }
}
