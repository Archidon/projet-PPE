using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicielGestion
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public void initJoueur(
            string pseudo, string nom, string prenom,
            string adresse, DateTime dateNaiss, string mail,
            string numTel, bool confirm)
        {
            string infosClients;

            /*using (var model = new Model())
            {
                utilisateur actif = new utilisateur
                {
                    infosClients = pseudo + ", " + nom + ", " + prenom +
                    ", " + adresse + ", " + dateNaiss.ToString() + ", " + mail +
                    ", " + numTel + ", " + confirm
                };
                    
                lBoxInfosClients.Items.Add(actif.infosClients);
            }*/
        }

        FormWindowState LastWindowState = FormWindowState.Minimized;
        private void Form_Resize(object sender, EventArgs e)
        {
            // When window state changes
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;


                if (WindowState == FormWindowState.Maximized)
                {
                    lBoxHistorique.Location = new Point(970, 80);
                    lBoxHistorique.Size = new Size(940, 970);
                    lblHistorique.Location = new Point(970, 60);
                    lBoxInfosClients.Size = new Size(940, 970);
                }
                if (WindowState == FormWindowState.Normal)
                {
                    lBoxHistorique.Location = new Point(400, 80);
                    lBoxHistorique.Size = new Size(370, 472);
                    lblHistorique.Location = new Point(400, 60);
                    lBoxInfosClients.Size = new Size(370, 472);
                }
            }
        }
    }
}
