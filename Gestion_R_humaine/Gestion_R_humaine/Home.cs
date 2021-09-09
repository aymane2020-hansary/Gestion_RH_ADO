using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_R_humaine
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();

            nb_employées.Text = Global_session.nb_employées;
            nb_projets.Text = Global_session.nb_projets;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}