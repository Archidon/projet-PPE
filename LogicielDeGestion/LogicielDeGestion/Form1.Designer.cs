namespace LogicielGestion
{
    partial class Form
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
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblInfosClients = new System.Windows.Forms.Label();
            this.lblHistorique = new System.Windows.Forms.Label();
            this.lBoxInfosClients = new System.Windows.Forms.ListBox();
            this.lBoxHistorique = new System.Windows.Forms.ListBox();
            this.cBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(20, 20);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(154, 13);
            this.lblEnterName.TabIndex = 0;
            this.lblEnterName.Text = "Entrer nom du client à afficher :";
            // 
            // lblInfosClients
            // 
            this.lblInfosClients.AutoSize = true;
            this.lblInfosClients.Location = new System.Drawing.Point(10, 60);
            this.lblInfosClients.Name = "lblInfosClients";
            this.lblInfosClients.Size = new System.Drawing.Size(97, 13);
            this.lblInfosClients.TabIndex = 2;
            this.lblInfosClients.Text = "Informations clients";
            // 
            // lblHistorique
            // 
            this.lblHistorique.AutoSize = true;
            this.lblHistorique.Location = new System.Drawing.Point(420, 60);
            this.lblHistorique.Name = "lblHistorique";
            this.lblHistorique.Size = new System.Drawing.Size(54, 13);
            this.lblHistorique.TabIndex = 3;
            this.lblHistorique.Text = "Historique";
            // 
            // lBoxInfosClients
            // 
            this.lBoxInfosClients.FormattingEnabled = true;
            this.lBoxInfosClients.Location = new System.Drawing.Point(10, 80);
            this.lBoxInfosClients.Name = "lBoxInfosClients";
            this.lBoxInfosClients.Size = new System.Drawing.Size(370, 472);
            this.lBoxInfosClients.TabIndex = 4;
            // 
            // lBoxHistorique
            // 
            this.lBoxHistorique.FormattingEnabled = true;
            this.lBoxHistorique.Location = new System.Drawing.Point(400, 80);
            this.lBoxHistorique.Name = "lBoxHistorique";
            this.lBoxHistorique.Size = new System.Drawing.Size(370, 472);
            this.lBoxHistorique.TabIndex = 5;
            // 
            // cBox
            // 
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(180, 17);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(250, 21);
            this.cBox.TabIndex = 6;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.lBoxHistorique);
            this.Controls.Add(this.lBoxInfosClients);
            this.Controls.Add(this.lblHistorique);
            this.Controls.Add(this.lblInfosClients);
            this.Controls.Add(this.lblEnterName);
            this.Name = "Form";
            this.Text = "Logiciel Gestion";
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblInfosClients;
        private System.Windows.Forms.Label lblHistorique;
        private System.Windows.Forms.ListBox lBoxInfosClients;
        private System.Windows.Forms.ListBox lBoxHistorique;
        private System.Windows.Forms.ComboBox cBox;
    }
}

