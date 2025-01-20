using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIEFLIAGE
{
    public partial class FormEtudiant : Form

    {
        private int? selectedEtudiantId = null;
        public FormEtudiant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEtudiant_Load(object sender, EventArgs e)
        {
            using (var db = new DBScolaire())
            {
                comboBox1.DataSource = db.Classe.ToList();
                comboBox1.DisplayMember = "Libelle";
                comboBox1.ValueMember = "Id";
            }
            Actualiser();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            using (var db = new DBScolaire())
            {
                Etudiant etudiant = new Etudiant();
                etudiant.Prenom = textPrenom.Text;
                etudiant.Nom = textNom.Text;
                etudiant.IdClasse = (int)comboBox1.SelectedValue; 
                etudiant.classe = db.Classe.FirstOrDefault(c => c.Id == etudiant.IdClasse);
                db.Etudiant.Add(etudiant);
                db.SaveChanges();
                MessageBox.Show("Donnees inserer", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Actualiser();
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private void Actualiser()
        {
            dataGridView1.DataSource = null;
            using (var db = new DBScolaire())
            {
                dataGridView1.DataSource = db.Etudiant.Select(e => new ViewEtudiant { Id = e.Id,Prenom = e.Prenom,
                Nom = e.Nom,Libelle = e.classe.Libelle}).ToList();

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEtudiantId.HasValue)
            {
                using (var db = new DBScolaire())
                {
                    var Etudiant = db.Etudiant.FirstOrDefault(et => et.Id == selectedEtudiantId.Value);
                    if (Etudiant != null)
                    {
                        
                        Etudiant.Prenom = textPrenom.Text;
                        Etudiant.Nom = textNom.Text;
                        Etudiant.IdClasse = (int)comboBox1.SelectedValue;

                        db.SaveChanges();
                        MessageBox.Show("Données mises à jour avec succès.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Actualiser();
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                    }
                }
            }
        }
    }
}
