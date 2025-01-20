namespace MDIEFLIAGE
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDCLASSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDETUDIANTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.rapportToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDCLASSEToolStripMenuItem,
            this.cRUDETUDIANTToolStripMenuItem});
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // cRUDCLASSEToolStripMenuItem
            // 
            this.cRUDCLASSEToolStripMenuItem.Name = "cRUDCLASSEToolStripMenuItem";
            this.cRUDCLASSEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDCLASSEToolStripMenuItem.Text = "CRUD CLASSE";
            this.cRUDCLASSEToolStripMenuItem.Click += new System.EventHandler(this.cRUDCLASSEToolStripMenuItem_Click);
            // 
            // cRUDETUDIANTToolStripMenuItem
            // 
            this.cRUDETUDIANTToolStripMenuItem.Name = "cRUDETUDIANTToolStripMenuItem";
            this.cRUDETUDIANTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDETUDIANTToolStripMenuItem.Text = "CRUD ETUDIANT";
            this.cRUDETUDIANTToolStripMenuItem.Click += new System.EventHandler(this.cRUDETUDIANTToolStripMenuItem_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 557);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI LIAGE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDCLASSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDETUDIANTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
    }
}

