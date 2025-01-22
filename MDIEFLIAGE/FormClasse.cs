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
    public partial class FormClasse : Form
    {
        private int? selectedClasseId = null;
        public FormClasse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            using (var db = new DBScolaire())
            {
                Classe classe = new Classe();
                classe.Libelle = textLibelle.Text;
                db.Classe.Add(classe);
                db.SaveChanges();
               
                
                    MessageBox.Show("Donnees inserer", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualiser();
                    Refresh();

            }
        }
        private void Actualiser()
        {
            dataGridView1.DataSource =null;
            using (var db = new DBScolaire())
            {
                dataGridView1.DataSource=db.Classe.ToList();

            }
        }

        private void FormClasse_Load(object sender, EventArgs e)
        {
            Actualiser();
            Refresh();
        }

        private void btnUpadateC_Click(object sender, EventArgs e)
        {
            if (selectedClasseId.HasValue)
            {
                using (var db = new DBScolaire())
                {
                    var classe = db.Classe.FirstOrDefault(c => c.Id == selectedClasseId.Value);
                    if (classe != null)
                    {
                        
                        classe.Libelle = textLibelle.Text;

                        db.SaveChanges();

                        MessageBox.Show("Donnees modifier.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Actualiser();
                        Refresh();
                    }
                }
            }

        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            if (selectedClasseId.HasValue)
            {
                var confirmResult = MessageBox.Show(
                    "Voulez vous supprimer cette classe ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    using (var db = new DBScolaire())
                    {
                        var classe = db.Classe.FirstOrDefault(c => c.Id == selectedClasseId.Value);
                        if (classe != null)
                        {
                            db.Classe.Remove(classe);
                            db.SaveChanges();

                            MessageBox.Show("Classe supprimee avec succes.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Actualiser();
                            Refresh();
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                selectedClasseId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                using (var db = new DBScolaire())
                {
                    var classe = db.Classe.FirstOrDefault(c => c.Id == selectedClasseId.Value);
                    if (classe != null)
                    {
                        
                        textLibelle.Text = classe.Libelle;
                        btnUpadateC.Enabled = true;
                        btnDeleteC.Enabled = true;
                    }
                }
            }

        }
        private void Refresh()
        {
            
            textLibelle.Text = string.Empty;
            btnUpadateC.Enabled = false;
            btnDeleteC.Enabled = false;
            selectedClasseId = null;
        }
    }
}
