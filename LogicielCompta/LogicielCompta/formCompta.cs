using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logicielCompta
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Controleur leControleur;
        public Form1()
        {
            InitializeComponent();
            leControleur = new Controleur();
        }

        FormWindowState LastWindowState = FormWindowState.Minimized;

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Lorsque l'état du formulaire change
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;

                if (WindowState == FormWindowState.Maximized)
                {
                    lBoxHistoriqueCredits.Location = new Point(970, 80);
                    lBoxHistoriqueCredits.Size = new Size(940, 970);
                    lblHistoriqueCredits.Location = new Point(970, 60);
                    lBoxInfosClient.Size = new Size(940, 970);
                }
                if (WindowState == FormWindowState.Normal)
                {
                    lBoxHistoriqueCredits.Location = new Point(400, 80);
                    lBoxHistoriqueCredits.Size = new Size(370, 472);
                    lblHistoriqueCredits.Location = new Point(400, 60);
                    lBoxInfosClient.Size = new Size(370, 472);
                }
            }
        }

        private void cbClients_TextChanged(object sender, EventArgs e)
        {
            cbClients.Items.Add(leControleur.getUtilisateurs(cbClients.Text));
        }

        private void btnChargerClient_Click(object sender, EventArgs e)
        {
            if(cbClients.Items.Count == 0)
            {
                MessageBox.Show("Le champs de saisie est vide, veuillez le remplir");
            }
            else
            {
                lBoxInfosClient.Items.Add(leControleur.getInfosClient());
                lBoxHistoriqueCredits.Items.Add(leControleur.getInfosCredits());
            }
        }
    }
}
