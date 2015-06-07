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
    public partial class UserMode : Form
    {
        public UserMode()
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
        String MarcaC, TipoC, ModeloC, LlantasC, MotorC,  SsupensionC, TransmisionC;
        string datosConexion = "Server=10.24.168.220;Database=autos; Uid=Admin; Pwd=Password";
       

      

        static void Main2(string[] args)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        //GLOBALES
        Diseño4Caras DS4 = new Diseño4Caras();
        
 
        //
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DS4.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea usted realmente cerrar la sesion actual?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                //OPCION YES 
                Marca = new ComboBox();
                Tipo = new ComboBox();
            }
            else
            {
                //OPCION NO
                this.Visible=false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(TransmisionC) + Convert.ToDouble(LlantasC) + Convert.ToDouble(MotorC)+Convert.ToDouble(SsupensionC)+Convert.ToDouble(ModeloC);
            Document document = new Document();

            PdfWriter.GetInstance(document, new FileStream("Consulta Car Design.pdf", FileMode.OpenOrCreate));
            document.Open();
            //Titulo//
            document.Add(new Paragraph("Servicio de Consultoria MOTOR Group S.A DE C.V\n\nASUNTO: ", FontFactory.GetFont("ARIAL", 18, iTextSharp.text.Font.BOLDITALIC)));
            document.Add(new Paragraph("                         Consulta de diseño automovilistico asistida por VR.\n\n\n"));
            //Descripción//
            document.Add(new Paragraph("Por medio del siguiente documento queda a conocimiento del usuario un resumen completo de las caracteristicas y especificaciones tecnicas de su consulta.\n\nLos detalles de rendimiento y el desglose de su operacion se encuentran al final de este documento.\n\nGracias por usar los servicios de MOTOR Group"));
            //Datos//
            document.Add(new Paragraph("\n\n\nCantidad" + "           " + "Detalles" + "                                          " + "Costo" + "           " + "Disponibilidad\n"));

            //MARCA
            document.Add(new Paragraph("1" + "                       " + Marca.Text + "                                          " + ModeloC + "                " + "SI"));
            //TIPO
            document.Add(new Paragraph("1" + "                       " + Tipo.Text + "                                           " + "No Aplica" + "             " + "SI"));
            //MODELO
            document.Add(new Paragraph("1" + "                       " + Modelo.Text + "                                         " + "No Aplica" + "             " + "SI"));
            //LLANTAS
            document.Add(new Paragraph("1" + "                       " + Llantas.Text + "                                        " + LlantasC + "                " + "SI"));
            //MOTOR
            document.Add(new Paragraph("1" + "                       " + Motor.Text + "                                          " + MotorC + "                  " + "SI"));
            //NO. PASAJEROS
            document.Add(new Paragraph("1" + "                       " + Pasajeros.Text + "                                      " +"No Aplica" + "              " + "SI"));
            //SUSPENSION
            document.Add(new Paragraph("1" + "                       " + Suspension.Text + "                                     " + SsupensionC + "             " + "SI"));
            //TRANSMISION
            document.Add(new Paragraph("1" + "                       " + Transmision.Text + "                                    " + TransmisionC + "            " + "SI"));

            document.Add(new Paragraph("Total:"+total));

            document.Close();
        }

        private void UserMode_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(datosConexion);
            con.Open();
            string textoCmd = "SELECT * FROM Autos;";
            MySqlCommand cmd = new MySqlCommand(textoCmd, con);

            lector = cmd.ExecuteReader();
            int i = 0;
            while (lector.Read())
            {
             
                Marca.Items.Insert(i,lector["Marca"].ToString());
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
             
           
        }

        private void Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(datosConexion);
            con.Open();
            string textoCmd = "SELECT * FROM autos where Marca='" + Marca.Text + "'";
            MySqlCommand cmd = new MySqlCommand(textoCmd, con);
            lector = cmd.ExecuteReader();
            int i = 0;
            while (lector.Read())
            {
                 Modelo.Items.Insert(i, lector["Modelo"].ToString());
                //Tipo.Items.Insert(i, lector["Tipo"].ToString());
                i++;
            }
            i = 0;
            con.Close();
            cmd.Dispose();
            con.Dispose();
            lector.Close();
            lector.Dispose();
        }

        private void Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(datosConexion);
            con.Open();
            string textoCmd = "SELECT * FROM autos where Marca='" + Marca.Text + "'";
            MySqlCommand cmd = new MySqlCommand(textoCmd, con);
            lector = cmd.ExecuteReader();
            int i = 0;
            while (lector.Read())
            {
                ModeloC = lector["Costo"].ToString();
                Pasajeros.Items.Insert(i, lector["Capacidad"].ToString());
                
                i++;
            }
            i = 0;
            con.Close();
            cmd.Dispose();
            con.Dispose();
            lector.Close();
            lector.Dispose();
        }

        private void ImagenMuestra_Click(object sender, EventArgs e)
        {

        }

        private void Llantas_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            //consulta para descripcion

            MySqlConnection con = new MySqlConnection(datosConexion);
            con.Open();
            string textoCmd = "SELECT * FROM llantas where Marca='" + Llantas.Text + "'";
            MySqlCommand cmd = new MySqlCommand(textoCmd, con);
            lector = cmd.ExecuteReader();
            int i = 0;
            while (lector.Read())
            {
                LlantasC = lector["Costo"].ToString();
                TxtDescripcion.Text = "Codigo Llanta: "+ lector["CodigoLlanta"].ToString();
                TxtDescripcion.Text += "Marca:" +lector["Marca"].ToString();
                TxtDescripcion.Text += "Rin: "+lector["Rin"].ToString();
                TxtDescripcion.Text += "Costo: "+lector["Costo"].ToString();
                //Pasajeros.Items.Insert(i, lector["Capacidad"].ToString());

                i++;
            }
            i = 0;
            con.Close();
            cmd.Dispose();
            con.Dispose();
            lector.Close();
            lector.Dispose();

            try
            {

                if (Llantas.Text == "Bridgestone GTII")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\BRIDGESTONE GTII.jpg");
                }
                if (Llantas.Text == "Continental NCT5")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\CONTINENTAL NCT5.jpg");
                }
                if (Llantas.Text == "Continental Ventura")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\CONTINENTAL VENTURA.jpg");
                }
                if (Llantas.Text == "Dunlop Sport 01")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\DunlopSport01.jpg");
                }
                //------------------------------------------------------
                
                if (Llantas.Text == "Dunlop Sport 2000E")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\DUNLOP SPORT 2000E.jpg");
                }
                if (Llantas.Text == "Dunlop Sport Maxx")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\DUNLOP SPORT MAXX.jpg");
                }
                if (Llantas.Text == "Firestone GSD3")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\FIRESTONE GSD3.jpg");
                }
                if (Llantas.Text == "Pirelli Eagle F1")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\PIRELLI EAGLE F1.jpg");
                }
                if (Llantas.Text == "Pirelli Eagle GS")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\PIRELLI EAGLE GS.jpg");
                }
                if (Llantas.Text == "Pirelli Eagle GS-2")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\PIRELLI EAGLE GS-2.jpg");
                }
                if (Llantas.Text == "Toyotires GA")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\TOYOTIRES GA.jpg");
                }
                if (Llantas.Text == "Toyotires Supercar")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\TOYOTIRES SUPERCAR.jpg");
                }
                if (Llantas.Text == "Bridgestone GTII")
                {
                    pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Llantas\BRIDGESTONE GTII.jpg");
                }
            }
            catch(Exception p)
            {

            }
        }

        private void Transmision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cont = new MySqlConnection(datosConexion);
                cont.Open();
                string textoCmdt = "SELECT * FROM transmisiones where Modelo='" + Transmision.Text + "'";
                MySqlCommand cmdt = new MySqlCommand(textoCmdt, cont);
                lectort = cmdt.ExecuteReader();
                int t = 0;
                while (lectort.Read())
                {
                    TransmisionC = lectort["Costo"].ToString();
                    TxtDescripcion.Text = "Codigo Transmision: " + lectort["CodigoTransmision"].ToString();
                    TxtDescripcion.Text += "Tipo:" + lectort["Tipo"].ToString();
                    TxtDescripcion.Text += "Modelo: " + lectort["Modelo"].ToString();
                    TxtDescripcion.Text += "Costo: " + lectort["Costo"].ToString();
                    TxtDescripcion.Text += "Velocidades: " + lectort["Velocidades"].ToString();
     

                    t++;
                }
                t = 0;
                cont.Close();
                cmdt.Dispose();
                cont.Dispose();
                lectort.Close();
                lectort.Dispose();
            }
            catch(Exception t)
            {

            }
            //agregar las condiciones

            if (Transmision.Text == "Hydra-Matic 4L65-E")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Transmisiones\Hydra-Matic 4L65-E.jpg");
            }
            if (Transmision.Text == "MG9 TR6060")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Transmisiones\MG9 TR6060.jpg");
            }
            if (Transmision.Text == "SuperMatic 4L70-E")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Transmisiones\SuperMatic 4L70-E.jpg");
            }
            if (Transmision.Text == "SuperMatic 4L85-E")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Transmisiones\SuperMatic 4L85-E.jpg");
            }
            if (Transmision.Text == "T56 Super Magnum")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Transmisiones\T56 Super Magnum.jpg");
            }
            if (Transmision.Text == "TR6060")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Transmisiones\TR6060.jpg");
            }
        }

        private void Suspension_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection cont = new MySqlConnection(datosConexion);
                cont.Open();
                string textoCmdt = "SELECT * FROM suspensiones where Tipo='" +Suspension .Text + "'";
                MySqlCommand cmdt = new MySqlCommand(textoCmdt, cont);
                lectort = cmdt.ExecuteReader();
                int t = 0;
                while (lectort.Read())
                {
                    SsupensionC = lectort["Costo"].ToString();
                    TxtDescripcion.Text = "Codigo Suspension: " + lectort["CodigoSuspension"].ToString();
                    TxtDescripcion.Text += "Tipo:" + lectort["Tipo"].ToString();
                    
                    TxtDescripcion.Text += "Costo: " + lectort["Costo"].ToString();
                    


                    t++;
                }
                t = 0;
                cont.Close();
                cmdt.Dispose();
                cont.Dispose();
                lectort.Close();
                lectort.Dispose();
            }
            catch (Exception t)
            {

            }







            if(Suspension.Text=="Hidráulica")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Suspensiones\Hidraulica.jpg");
            }
            if (Suspension.Text == "Eje Rígido")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Suspensiones\Eje Rigido.jpg");
            }
            if (Suspension.Text == "Normal")
            {
                pictureBox4.Image = Bitmap.FromFile(@"Diseños Automotrices\Suspensiones\Normal.jpg");
            }
        }

        private void Motor_SelectedIndexChanged(object sender, EventArgs e)
        {





            try
            {
                MySqlConnection cont = new MySqlConnection(datosConexion);
                cont.Open();
                
                string textoCmdt = "SELECT * FROM motores where Modelo='" + Motor.Text + "'";
                MySqlCommand cmdt = new MySqlCommand(textoCmdt, cont);
                lectort = cmdt.ExecuteReader();
                int t = 0;
                while (lectort.Read())
                {
                    MotorC = lectort["Costo"].ToString();
                    TxtDescripcion.Text = "Codigo Motor " + lectort["CodigoMotor"].ToString();
                    TxtDescripcion.Text += "Potencia:" + lectort["Potencia"].ToString();
                    TxtDescripcion.Text += "Modelo: " + lectort["Modelo"].ToString();
                    TxtDescripcion.Text += "Costo: " + lectort["Costo"].ToString();
                    TxtDescripcion.Text += "Tamano: " + lectort["Tamano"].ToString();
                    TxtDescripcion.Text += "Potencia: " + lectort["Potencia"].ToString();
                    TxtDescripcion.Text += "Torque: " + lectort["Torque"].ToString();
                    TxtDescripcion.Text += "Cilindrada: " + lectort["Cilindrada"].ToString();
                    TxtDescripcion.Text += "Peso: " + lectort["Peso"].ToString();



                    t++;
                }
                t = 0;
                cont.Close();
                cmdt.Dispose();
                cont.Dispose();
                lectort.Close();
                lectort.Dispose();
            }
            catch (Exception t)
            {

            }
        }
    }
}