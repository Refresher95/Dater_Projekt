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
            string formatedDateForMySql = "2004-10-12";
            ///string query = "INSERT INTO user (vorname, nachname, geburtsdatum, geschlecht, username, password) VALUES ('" + txtvorname.Text + "','" + txtnachanme.Text + "','" + formatedDateForMySql + "','" + txtgeschlecht.Text + "','" + txtnutzername.Text + "','" + txtpasswort.Text + "');";
            string query = "INSERT INTO user (vorname, nachname, geburtsdatum, geschlecht, username, password) VALUES ('" + txtvorname.Text + "','" + txtnachanme.Text + "','" + formatedDateForMySql + "','" + txtgeschlecht.Text + "','" + txtnutzername.Text + "','" + txtpasswort.Text + "');";


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Register_confirm_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
