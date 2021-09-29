/// eigens hinzugefügt START
using MySql.Data.MySqlClient;
using System;
/// eigens hinzugefügt STOP
using System.Windows;

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
            //Verbindung var. herstellen
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=dater_benutzer_datensätze");


            //string query = "INSERT INTO benutzer_table (vorname, nachname, geburtsdatum, geschlecht, username, password) VALUES ('" + txtvorname.Text + "','" + txtnachanme.Text + "','" + txtgeburtstagsdatum.Text + "','" + txtgeschlecht.Text + "','" + txtnutzername.Text + "','" + txtpasswort.Text + "');";
            con.Open();
            Reglab.Content = Title;

        }

        private void Register_confirm_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=dater_benutzer_datensätze");

            try
            {
                // string formatedDateForMySql = txtgeburtstagsdatum.Text; Wegen SQL Datatype Problemen unbrauchbar
                //string formatedDateForMySql2 = Convert.ToDateTime(txtgeburtstagsdatum.Text); """"""""""""""

                string query = "INSERT INTO benutzer_table (Benutzer_vorname,Benutzer_nachname,Benutzer_Geburtstagsdatum,Benutzer_Geschlecht,Benutzer_Nutzername,Benutzer_Passwort) VALUES ('" + txtvorname.Text + "','" + txtnachanme.Text + "','" + txtgeburtstagsdatum.Text + "','" + txtgeschlecht.Text + "','" + txtnutzername.Text + "','" + txtpasswort.Text + "');";

                MySqlCommand sqlCommand = new MySqlCommand(query, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();

            }// catch fängt fehler ab in dem fall wird ein fenster mit dem fehler angezeigt
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally           unnötig aber wenn man will dass das programm sich bei einem fehler schließen soll ist es sinvnoll
            //{
            //    con.Close();
            //}
        }
    }
}
