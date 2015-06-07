using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDesignSimulator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //
        UserMode UM = new UserMode();
        //
        private void modoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UM.Show();
        }
        //
        Login LG = new Login();
        //
        private void modoAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LG.Show();
            
        }

        private void cerraSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta por cerra la sesion.\n¿Confirma esta accion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                //OPCION YES 
            }
            else
            {
                //OPCION NO
                this.Close();
            }
        }
    }
}
