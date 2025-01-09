using MySql.Data.MySqlClient;
using System.Printing;
using System.Windows;

namespace mysql
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Connect();
        }

        private void Connect()
        {
            //MessageBox.Show("Connection à la base de données");
            string connexionString = "server=localhost;database=test;uid=root;password=;";
            MySqlConnection connexion = new MySqlConnection(connexionString);

            try {
                connexion.Open();
                MessageBox.Show("Base de données ouverte !");
                connexion.Close();
            }
            catch(Exception e) {
                throw new Exception("Erreur à l'ouverture de la base de données : " + e.Message);
            }


        }
    }
}