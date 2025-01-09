using MySql.Data.MySqlClient;
using System.Data;
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
            // Local
            //string connexionString = "server=localhost;database=test;uid=root;password=;";
            // Distant
            string connexionString = "server=109.234.165.136;database=judi6669_test;uid=judi6669_philippe;password=e5P[Ey#l^izP;";

            MySqlConnection connexion = new MySqlConnection(connexionString);
            MySqlCommand cmd = new MySqlCommand("SELECT id as Id, email as EMail, name as Nom FROM users;", connexion);
            DataTable dt = new DataTable();

            try {
                connexion.Open();
                //Execute le lecteur de l'objet cmd (lit les données) puis charge les données dans dt avec Load
                dt.Load(cmd.ExecuteReader());
                connexion.Close();
            }
            catch(Exception e) {
                throw new Exception("Erreur à l'ouverture de la base de données : " + e.Message);
            }

            dg.ItemsSource = dt.DefaultView;
        }

        private void dg_CellEditEnding(object sender, System.Windows.Controls.DataGridCellEditEndingEventArgs e)
        {
            MessageBox.Show("end editing");
        }
    }
}