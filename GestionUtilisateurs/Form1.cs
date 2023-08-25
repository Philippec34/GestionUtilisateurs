using System.ComponentModel;


namespace GestionUtilisateurs
{
    public partial class Form1 : Form
    {
        //creation d'un objet db pour utiliser la class db
        DB _db = new DB();

        //creation d'une collection d'utilisateur qui permet le binding
        BindingList<Utilisateurs> _utils = new();

        public Form1()
        {
            InitializeComponent();
            //appel de la m�thode InitializeBinding() qui cr�� les bind (association) entre les �l�ments
            InitializeBinding();
        }


        //methode pour initier les bind
        //!!!!!!!!!!!! Les bind ne doivent pas �tre modifier pendant l'application
        private void InitializeBinding()
        {
            _utils = new BindingList<Utilisateurs>();
            bsUtilisateur.DataSource = _utils;
            dgvUtilisateur.DataSource = bsUtilisateur;
            txtNom.DataBindings.Add("Text", bsUtilisateur, "Nom", false, DataSourceUpdateMode.Never);
            txtPrenom.DataBindings.Add("Text", bsUtilisateur, "Prenom", false, DataSourceUpdateMode.Never);
            dtpNaiss.DataBindings.Add("Text", bsUtilisateur, "DtNaiss", false, DataSourceUpdateMode.Never);

            dgvUtilisateur.Columns["Id"].Visible = false;

            dgvUtilisateur.Columns["DtNaiss"].DefaultCellStyle.Format = "D";

        }



        private void btRefresh_Click_1(object sender, EventArgs e)
        {
            Utilisateurs current = bsUtilisateur.Current as Utilisateurs;

            //efface la collection pour eviter de la r�p�ter 
            _utils.Clear();

            //cr�tion d'une variable qui r�cup�re les donn� r�cup�r� grace a la m�thode GetUtilisateurs()
            var u = _db.GetUtilisateurs();

            //ajout des utilisateurs r�cup�r� dans notre binding list
            foreach (Utilisateurs utilisateur in u)
                _utils.Add(utilisateur);

            //permet de r�cuperer la position de la selection dans le DataGridView
            if (current is not null)
            {
                bsUtilisateur.Position = _utils.IndexOf(_utils.Where(u => u.Id == current.Id).FirstOrDefault());
            }
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            var nb = _db.InsertUtilisateur(txtNom.Text, txtPrenom.Text, dtpNaiss.Value);
            btRefresh.PerformClick();
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            var nb = _db.DeleteUtilisateur(txtNom.Text, txtPrenom.Text, dtpNaiss.Value);
            btRefresh.PerformClick();
        }
    }
}