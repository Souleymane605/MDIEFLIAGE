﻿namespace MDIEFLIAGE
{
    partial class FormClasse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textLibelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpadateC = new System.Windows.Forms.Button();
            this.btnDeleteC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textLibelle
            // 
            this.textLibelle.Location = new System.Drawing.Point(92, 85);
            this.textLibelle.Multiline = true;
            this.textLibelle.Name = "textLibelle";
            this.textLibelle.Size = new System.Drawing.Size(124, 28);
            this.textLibelle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " Libelle de la classe";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "BtnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(428, 378);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnUpadateC
            // 
            this.btnUpadateC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpadateC.Location = new System.Drawing.Point(92, 239);
            this.btnUpadateC.Name = "btnUpadateC";
            this.btnUpadateC.Size = new System.Drawing.Size(115, 38);
            this.btnUpadateC.TabIndex = 4;
            this.btnUpadateC.Text = "Editer";
            this.btnUpadateC.UseVisualStyleBackColor = false;
            this.btnUpadateC.Click += new System.EventHandler(this.btnUpadateC_Click);
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.BackColor = System.Drawing.Color.Red;
            this.btnDeleteC.Location = new System.Drawing.Point(92, 332);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(115, 38);
            this.btnDeleteC.TabIndex = 5;
            this.btnDeleteC.Text = "Supprimer";
            this.btnDeleteC.UseVisualStyleBackColor = false;
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnDeleteC);
            this.Controls.Add(this.btnUpadateC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLibelle);
            this.Name = "FormClasse";
            this.Text = "FormClasse";
            this.Load += new System.EventHandler(this.FormClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLibelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpadateC;
        private System.Windows.Forms.Button btnDeleteC;
    }
}