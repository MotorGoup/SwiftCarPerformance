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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }
        //
        AdminMode AM = new AdminMode();
        //
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "root" && textBox2.Text == "toor")
            {
                AM.Show();
                textBox1.Clear();
                textBox2.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de Login\nIntentelo de nuevo.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
