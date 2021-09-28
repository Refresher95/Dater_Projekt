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
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=dater_benutzer_datensätze");
            string query = "SELECT Benutzer_Vorname,Benutzer_Nachname FROM benutzer_table WHERE Benutzer_Nutzername = '" + txtbox.Text.Trim() + "' AND Benutzer_Passwort = '" + pwbox.Password.Trim() + "'";
            con.Open();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT Benutzer_Vorname,Benutzer_Nachname FROM benutzer_table WHERE Benutzer_Nutzername = '" + txtbox.Text.Trim() + "' AND Benutzer_Passwort = '" + pwbox.Password.Trim() + "'";
            // Login LogInWindow = new Login();
            ///this.Close();

            MySqlConnection con = new MySqlConnection("server=127.0.0.1;username=root;password=;database=dater_benutzer_datensätze");
            try
            {
                MySqlDataAdapter msda = new MySqlDataAdapter(query,con);
                DataTable DT = new DataTable();
                msda.Fill(DT);
                if (DT.Rows.Count == 1)
                {
                    Registration Registration = new Registration();
                    MainWindow MainWindow = new MainWindow();
                    MainWindow.Show();
                    Registration.Show();
                    this.Close();
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
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT Benutzer_Vorname,Benutzer_Nachname FROM benutzer_table WHERE Benutzer_Nutzername = '" + txtbox.Text.Trim() + "' AND Benutzer_Passwort = '" + pwbox.Password.Trim() + "'";

            MySqlConnection con = new MySqlConnection("server=127.0.0.1;username=root;password=;database=dater_benutzer_datensätze");
            try
            {
                    Registration Registration = new Registration();
                    Registration.Show();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
