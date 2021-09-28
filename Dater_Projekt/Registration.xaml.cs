using System;
/// eigens hinzugefügt START
using MySql.Data.MySqlClient;
using System.Data;
/// eigens hinzugefügt STOP
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

namespace daterprojekt
{
    /// <summary>
    /// Interaktionslogik für Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            //Verbindung var herstellen
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=dater_benutzer_datensätze");

            string formatedDateForMySql = "2004-10-12";
            ///string query = "INSERT INTO user (vorname, nachname, geburtsdatum, geschlecht, username, password) VALUES ('" + txtvorname.Text + "','" + txtnachanme.Text + "','" + formatedDateForMySql + "','" + txtgeschlecht.Text + "','" + txtnutzername.Text + "','" + txtpasswort.Text + "');";
            string query = "INSERT INTO user (vorname, nachname, geburtsdatum, geschlecht, username, password) VALUES ('" + txtvorname.Text + "','" + txtnachanme.Text + "','" + formatedDateForMySql + "','" + txtgeschlecht.Text + "','" + txtnutzername.Text + "','" + txtpasswort.Text + "');";
            con.Open();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Register_confirm_Click(object sender, RoutedEventArgs e)
        {
            //      MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=dater_benutzer_datensätze");
            //        string formatedDateForMySql = "2004-10-12";
            //          string query = "INSERT INTO user (vorname, nachname, geburtsdatum, geschlecht, username, password) VALUES ('" + txtvorname.Text + "','" + txtnachanme.Text + "','" + formatedDateForMySql + "','" + txtgeschlecht.Text + "','" + txtnutzername.Text + "','" + txtpasswort.Text + "');";
            //            MySqlCommand sqlCommand = new MySqlCommand(query, con);
            //Verbindung herstellen
            //           con.Open();
            //         sqlCommand.ExecuteNonQuery();
            //       con.Close();
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=dater_benutzer_datensätze");

            try
            {
                string formatedDateForMySql = "2004-10-12";
                string query = "INSERT INTO benutzer_table (Benutzer_vorname,Benutzer_nachname,Benutzer_Geburtstagsdatum,Benutzer_Geschlecht,Benutzer_Nutzername,Benutzer_Passwort) VALUES ('" + txtvorname.Text + "','" + txtnachanme.Text + "','" + formatedDateForMySql + "','" + txtgeschlecht.Text + "','" + txtnutzername.Text + "','" + txtpasswort.Text + "');";
                MySqlCommand sqlCommand = new MySqlCommand(query, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
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
