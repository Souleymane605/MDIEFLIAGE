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
        private int? etudiantSelectedId = null;

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
            refresh();

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
            refresh();
        }
        private void Actualiser()
        {
            dataGridView1.DataSource = null;
            using (var db = new DBScolaire())
            {
                dataGridView1.DataSource = db.Etudiant
                    .Select(e => new ViewEtudiant
                    {
                        Id = e.Id,
                        Prenom = e.Prenom,
                        Nom = e.Nom,
                        Libelle = e.classe.Libelle
                    })
                    .ToList();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (etudiantSelectedId.HasValue)
            {
                using (var db = new DBScolaire())
                {
                    var etudiant = db.Etudiant.FirstOrDefault(et => et.Id == etudiantSelectedId.Value);
                    if (etudiant != null)
                    {
    
                        etudiant.Prenom = textPrenom.Text;
                        etudiant.Nom = textNom.Text;
                        etudiant.IdClasse = (int)comboBox1.SelectedValue;

                        db.SaveChanges();
                        MessageBox.Show("Données mises à jour avec succès.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Actualiser();
                        refresh();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (etudiantSelectedId.HasValue)
            {
                var confirmResult = MessageBox.Show(
                    "Voulez vous supprimer cet étudiant ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    using (var db = new DBScolaire())
                    {
                        var etudiant = db.Etudiant.FirstOrDefault(et => et.Id == etudiantSelectedId.Value);
                        if (etudiant != null)
                        {
                            db.Etudiant.Remove(etudiant);
                            db.SaveChanges();
                            MessageBox.Show("Étudiant supprimé avec succès.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Actualiser();
                            refresh();
                        }
                    }
                }
            }
        }
        
        private void refresh()
        {
            textPrenom.Text = string.Empty;
            textNom.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            etudiantSelectedId = null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                etudiantSelectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                using (var db = new DBScolaire())
                {
                    var etudiant = db.Etudiant.FirstOrDefault(et => et.Id == etudiantSelectedId.Value);
                    if (etudiant != null)
                    {
                        
                        textPrenom.Text = etudiant.Prenom;
                        textNom.Text = etudiant.Nom;
                        comboBox1.SelectedValue = etudiant.IdClasse;

                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
            }

        }

    }
}
