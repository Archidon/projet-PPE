using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using direction_appli;

namespace direction_appli
{
    public partial class direction : Form
    {
        controleur thecontroleur;
        public direction()
        {
            InitializeComponent();
            thecontroleur = new controleur();
            initliste();
        }
        public void initliste()
        {
            
            

        }
    }
}
