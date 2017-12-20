namespace logicielCompta
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
            this.lblClients = new System.Windows.Forms.Label();
            this.lblInfosClient = new System.Windows.Forms.Label();
            this.lBoxInfosClient = new System.Windows.Forms.ListBox();
            this.lBoxHistoriqueCredits = new System.Windows.Forms.ListBox();
            this.lblHistoriqueCredits = new System.Windows.Forms.Label();
            this.btnChargerClient = new System.Windows.Forms.Button();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Location = new System.Drawing.Point(20, 30);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(121, 13);
            this.lblClients.TabIndex = 1;
            this.lblClients.Text = "Entrer le nom du client : ";
            // 
            // lblInfosClient
            // 
            this.lblInfosClient.AutoSize = true;
            this.lblInfosClient.Location = new System.Drawing.Point(9, 62);
            this.lblInfosClient.Name = "lblInfosClient";
            this.lblInfosClient.Size = new System.Drawing.Size(120, 13);
            this.lblInfosClient.TabIndex = 2;
            this.lblInfosClient.Text = "Informations sur le client";
            // 
            // lBoxInfosClient
            // 
            this.lBoxInfosClient.FormattingEnabled = true;
            this.lBoxInfosClient.Items.AddRange(new object[] {
            "Id : ",
            "Nom : ",
            "Prénom : ",
            "Date de naissance : ",
            "Adresse : ",
            "E-mail : ",
            "Téléphone : ",
            "Mail confirmé : "});
            this.lBoxInfosClient.Location = new System.Drawing.Point(12, 78);
            this.lBoxInfosClient.Name = "lBoxInfosClient";
            this.lBoxInfosClient.Size = new System.Drawing.Size(370, 472);
            this.lBoxInfosClient.TabIndex = 4;
            // 
            // lBoxHistoriqueCredits
            // 
            this.lBoxHistoriqueCredits.FormattingEnabled = true;
            this.lBoxHistoriqueCredits.Items.AddRange(new object[] {
            "Date : , Crédits : "});
            this.lBoxHistoriqueCredits.Location = new System.Drawing.Point(402, 80);
            this.lBoxHistoriqueCredits.Name = "lBoxHistoriqueCredits";
            this.lBoxHistoriqueCredits.Size = new System.Drawing.Size(370, 472);
            this.lBoxHistoriqueCredits.TabIndex = 5;
            // 
            // lblHistoriqueCredits
            // 
            this.lblHistoriqueCredits.AutoSize = true;
            this.lblHistoriqueCredits.Location = new System.Drawing.Point(399, 62);
            this.lblHistoriqueCredits.Name = "lblHistoriqueCredits";
            this.lblHistoriqueCredits.Size = new System.Drawing.Size(108, 13);
            this.lblHistoriqueCredits.TabIndex = 3;
            this.lblHistoriqueCredits.Text = "Historique des crédits";
            // 
            // btnChargerClient
            // 
            this.btnChargerClient.Location = new System.Drawing.Point(353, 25);
            this.btnChargerClient.Name = "btnChargerClient";
            this.btnChargerClient.Size = new System.Drawing.Size(75, 23);
            this.btnChargerClient.TabIndex = 6;
            this.btnChargerClient.Text = "Charger";
            this.btnChargerClient.UseVisualStyleBackColor = true;
            this.btnChargerClient.Click += new System.EventHandler(this.btnChargerClient_Click);
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(147, 27);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(200, 21);
            this.cbClients.TabIndex = 7;
            this.cbClients.Text = "Saisir un nom";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.btnChargerClient);
            this.Controls.Add(this.lBoxHistoriqueCredits);
            this.Controls.Add(this.lBoxInfosClient);
            this.Controls.Add(this.lblHistoriqueCredits);
            this.Controls.Add(this.lblInfosClient);
            this.Controls.Add(this.lblClients);
            this.Name = "Form1";
            this.Text = "Logiciel de comptabilité";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Label lblInfosClient;
        private System.Windows.Forms.ListBox lBoxInfosClient;
        private System.Windows.Forms.ListBox lBoxHistoriqueCredits;
        private System.Windows.Forms.Label lblHistoriqueCredits;
        private System.Windows.Forms.Button btnChargerClient;
        private System.Windows.Forms.ComboBox cbClients;
    }
}

