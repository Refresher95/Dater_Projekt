/// eigens hinzugefügt START
using MySql.Data.MySqlClient;
using System;
using System.Data;
/// eigens hinzugefügt STOP
using System.Windows;

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
            // Redundant aber zum erweitern der APP (FALLS MAN WILL!) wichtig evtl. um z.B. eine erste "Test Verbindung" als bestätigung zu bekommen bevor man sich einloggen will
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=dater_benutzer_datensätze");
            Loginlab.Content = Title;

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {// hier wird eine Variable erstellt    Attribute werden ausgewählt    von der Tabelle "benutzer_table"    mit der Bedingung die in den Boxen sind                       um die geählten Attribute mit den Inhalten von den Textboxen zu 
            string query = "SELECT * FROM benutzer_table WHERE Benutzer_Nutzername = '" + txtbox.Text.Trim() + "' AND Benutzer_Passwort = '" + pwbox.Password.Trim() + "'";
            //string query = "SELECT Benutzer_Vorname,Benutzer_Nachname FROM benutzer_table WHERE Benutzer_Nutzername = '" + txtbox.Text.Trim() + "' AND Benutzer_Passwort = '" + pwbox.Password.Trim() + "'";

            // hier wird versucht eine variable zu erstellen, die sich bei Benutzung mit den benötigten daten zum einloggen... einlogt zum Server mit den benutzten DB und deren Tabellen
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;username=root;password=;database=dater_benutzer_datensätze");
            try
            {
                // msda = hier wird eine sqlanweisung deklariert welche zum ausfüllen später genutzt wird
                MySqlDataAdapter msda_ = new MySqlDataAdapter(query, con);
                // Erstellung einer Variable bezüglich für eine Datentabelle
                DataTable DT = new DataTable();
                // Mit der Var. "msda_"
                msda_.Fill(DT);
                // Abfrage der Zeilen bei der erstellten Datentabelle (DT). Es wird nur eine geben, da man auch nicht mehrere PW und UN eingibt!!!
                if (DT.Rows.Count == 1)
                {
                    MainWindow MainWindow = new MainWindow();
                    MainWindow.Show();
                    this.Close();
                    // Login LogInWindow = new Login();         ALTERNATIV!!!
                    ///this.Close();
                }
                else
                {
                    //Falls falsch eingegeben ercheint dieses Fenster bzw. falls es nicht mit den zwei betreffenden attributen gleicht
                    MessageBox.Show("Falsche Eingabe");
                    Loginlab.Content = Title + " - Lern tippen oder registriere dich neu!";
                    Loginlab.FontSize = 18;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Registration Registration = new Registration();
            Registration.Show();
        }




        //Eigenes Zeug BITTE IGNORIEREN
        //private void Mediumm_MediaEnded(object sender, RoutedEventArgs e)
        //{
        //    Mediumm.Position = TimeSpan.Zero;
        //    Mediumm.Play();
        //}

        //private void Mediumm_MediaOpened(object sender, RoutedEventArgs e)
        //{
        //    Mediumm.Position = TimeSpan.Zero;
        //    Mediumm.Play();
        //}
    }
}
