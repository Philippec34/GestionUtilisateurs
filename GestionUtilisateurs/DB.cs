using Dapper;
using GestionUtilisateurs.Properties;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

namespace GestionUtilisateurs
{
    internal class DB
    {
        private readonly MySqlConnection _dbConnection;

        public DB()
        {
            //Creation de la connection avec le chemin mis en Setting
            _dbConnection = new(Settings.Default.dbConnect);

        }

        //Methode pour récuperer tout les champs de la table utilisateur de la BDD
        public IEnumerable<Utilisateurs> GetUtilisateurs()
        {
            //récupération des données de la table utilisateur
            //test le bon fonctionnement de la requête
            try
            {
                _dbConnection.Open();
                var q = "SELECT * from utilisateurs";
                return _dbConnection.Query<Utilisateurs>(q);
            }
            //ferme la connection même si la requête precedente echoue
            finally
            {
                _dbConnection.Close();
            }
        }

        public int InsertUtilisateur(string nom, string prenom, DateTime dtNaiss)
        {
            try
            {
                _dbConnection.Open();
                var q = "INSERT INTO utilisateurs (Nom, Prenom, DtNaiss) VALUES (@nom, @prenom, @dtNaiss)";
                return _dbConnection.Execute(q, new { nom, prenom, dtNaiss });

            }
            //ferme la connection même si la requête precedente echoue
            finally
            {
                _dbConnection.Close();
            }
        }

        public int DeleteUtilisateur(string nom, string prenom, DateTime dtNaiss)
        {
            try
            {
                _dbConnection.Open();
                var q = "DELETE FROM utilisateurs (Id, nom, prenom, DtNaiss) VALUES @nom, @prenom, @DtNaiss";
                return _dbConnection.Execute(q, new { nom, prenom, dtNaiss });

            }
            //ferme la connection même si la requête precedente echoue
            finally
            {
                _dbConnection.Close();
            }
        }
    }

}        

       
