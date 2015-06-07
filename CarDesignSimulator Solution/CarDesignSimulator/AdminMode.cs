using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
namespace CarDesignSimulator
{
    public partial class AdminMode : Form
    {
        public AdminMode()
        {
            InitializeComponent();
        }
        MySqlDataReader lector;
        MySqlDataReader lector2;
        MySqlDataReader lector3;
        MySqlDataReader lector4;
        MySqlDataReader lector5;
        MySqlDataReader lector6;
        MySqlDataReader lectort;
        string datosConexion = "Server=10.24.168.220;Database=autos; Uid=Admin; Pwd=Password";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea usted realmente cerrar la sesion actual?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                //OPCION YES 
            }
            else
            {
                //OPCION NO
                //this.Visible = false;
                this.Close();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int IVA = 16;
            bool DESC = false;
            this.Hide();
        }

        private void AdminMode_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(datosConexion);
            con.Open();
            string textoCmd = "SELECT * FROM Autos;";
            MySqlCommand cmd = new MySqlCommand(textoCmd, con);

            lector = cmd.ExecuteReader();
            int i = 0;
            while (lector.Read())
            {

                Marca.Items.Insert(i, lector["Marca"].ToString());
                // Tipo.Items.Insert(i, lector["Tipo"].ToString());
                i++;
            }
            con.Close();
            cmd.Dispose();
            con.Dispose();
            lector.Close();
            lector.Dispose();


            MySqlConnection con2 = new MySqlConnection(datosConexion);
            con2.Open();
            string textoCmd2 = "SELECT * FROM Llantas;";
            MySqlCommand cmd2 = new MySqlCommand(textoCmd2, con2);

            lector2 = cmd2.ExecuteReader();
            int ii = 0;
            while (lector2.Read())
            {
                Llantas.Items.Insert(ii, lector2["Marca"].ToString());
                // Tipo.Items.Insert(i, lector["Tipo"].ToString());
                ii++;
            }
            con2.Close();
            cmd2.Dispose();
            con2.Dispose();
            lector2.Close();
            lector2.Dispose();

            MySqlConnection con3 = new MySqlConnection(datosConexion);
            con3.Open();
            string textoCmd3 = "SELECT * FROM Llantas;";
            MySqlCommand cmd3 = new MySqlCommand(textoCmd3, con3);

            lector3 = cmd3.ExecuteReader();
            int iii = 0;
            while (lector3.Read())
            {
                Llantas.Items.Insert(iii, lector3["Marca"].ToString());
                // Tipo.Items.Insert(i, lector["Tipo"].ToString());
                iii++;
            }
            con3.Close();
            cmd3.Dispose();
            con3.Dispose();
            lector3.Close();
            lector3.Dispose();


            MySqlConnection con4 = new MySqlConnection(datosConexion);
            con4.Open();
            string textoCmd4 = "SELECT * FROM suspensiones;";
            MySqlCommand cmd4 = new MySqlCommand(textoCmd4, con4);

            lector4 = cmd4.ExecuteReader();
            int iiii = 0;
            while (lector4.Read())
            {

                Suspension.Items.Insert(iiii, lector4["Tipo"].ToString());

                // Tipo.Items.Insert(i, lector["Tipo"].ToString());
                iiii++;
            }
            con4.Close();
            cmd4.Dispose();
            con4.Dispose();
            lector4.Close();
            lector4.Dispose();

            MySqlConnection con5 = new MySqlConnection(datosConexion);
            con5.Open();
            string textoCmd5 = "SELECT * FROM transmisiones;";
            MySqlCommand cmd5 = new MySqlCommand(textoCmd5, con5);

            lector5 = cmd5.ExecuteReader();
            int iiiii = 0;
            while (lector5.Read())
            {
                Transmision.Items.Insert(iiiii, lector5["Modelo"].ToString());

                // Tipo.Items.Insert(i, lector["Tipo"].ToString());
                iiiii++;
            }
            con5.Close();
            cmd5.Dispose();
            con5.Dispose();
            lector5.Close();
            lector5.Dispose();

        }


        MySqlConnection conn = new MySqlConnection("Server=10.24.168.220;Database=autos; Uid=Admin; Pwd=Password");
        private void close_conn() { 
            if (this.conn != null)
                conn.Close();
        }
        private void Marca_SelectedIndexChanged(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(datosConexion);
            con.Open();
            string textoCmd = "SELECT * FROM autos where Marca='" + Marca.Text + "'";
            MySqlCommand cmd = new MySqlCommand(textoCmd, con);
            lector = cmd.ExecuteReader();
            int i = 0;



            while (lector.Read())
            {

                Tipo.Items.Insert(i, lector["Tipo"].ToString());

                i++;
            }

            i = 0;
            con.Close();
            cmd.Dispose();
            con.Dispose();
            lector.Close();
            lector.Dispose();

            if (Marca.Text == "Nissan GT-R")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Diseño Nissan GTR\Exterior\00.jpg");
                TxtDescripcion.Text = "Nissan GT-R";

            }
            if (Marca.Text == "Nissan 370 Z")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Diseño Nissan 370Z\Exterior\00.jpg");
                TxtDescripcion.Text = "Nissan 370 Z";
            }



            MySqlConnection conM = new MySqlConnection(datosConexion);
            conM.Open();
            string textoCmdM = "SELECT * FROM motores ";
            MySqlCommand cmdM = new MySqlCommand(textoCmdM, conM);
            lector6 = cmdM.ExecuteReader();
            int M = 0;
            while (lector6.Read())
            {
                Motor.Items.Insert(i, lector6["Modelo"].ToString());
                //Tipo.Items.Insert(i, lector["Tipo"].ToString());
                M++;
            }
            M = 0;
            conM.Close();
            cmdM.Dispose();
            conM.Dispose();
            lector6.Close();
            lector6.Dispose();
        


        }
    }
}
