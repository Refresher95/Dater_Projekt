/// eigens hinzugefügt START
using MySql.Data.MySqlClient;
using System.Data;
/// eigens hinzugefügt STOP
using System.Windows;


namespace daterprojekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string query = "SELECT * FROM benutzer_table";


            MySqlConnection con = new MySqlConnection("server=127.0.0.1;username=root;password=;database=dater_benutzer_datensätze");
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable DT = new DataTable();
            msda.Fill(DT);
            Daaer.DataContext = DT.DefaultView;
            Infobox.Text = "Hier könnte was stehen";
            Reglab.Content = Title;
        }

        private void Alles_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM benutzer_table";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;username=root;password=;database=dater_benutzer_datensätze");
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable DT = new DataTable();
            msda.Fill(DT);
            Daaer.DataContext = DT.DefaultView;
            Infobox.Text = " Hier sehen Sie ALLES";
        }

        private void Name_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT Benutzer_Vorname,Benutzer_Nachname FROM benutzer_table";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;username=root;password=;database=dater_benutzer_datensätze");
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable DT = new DataTable();
            msda.Fill(DT);
            Daaer.DataContext = DT.DefaultView;
            Infobox.Text = " Hier sehen Sie NUR die Vor- und Nachnamen";
        }

        private void ND_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT Benutzer_Nutzername,Benutzer_Passwort FROM benutzer_table";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;username=root;password=;database=dater_benutzer_datensätze");
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable DT = new DataTable();
            msda.Fill(DT);
            Daaer.DataContext = DT.DefaultView;
            Infobox.Text = " Hier sehen Sie NUR die Nutzerdaten";
        }
    }
}
