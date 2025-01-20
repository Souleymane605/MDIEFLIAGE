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
        }
    }
}
