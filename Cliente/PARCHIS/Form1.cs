using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace PARCHIS
{
    public partial class Form1 : Form
    {
        int puerto = 9070;
        Socket server;
        Thread atender;

        public string nombreUsuario, correo, contrasena;
        public void AtenderServidor()
        {
            while (true)
            {
                byte[] buffer = new byte[2000];
                server.Receive(buffer);
                string[] trozos = Encoding.ASCII.GetString(buffer).Split('/');
                int cod = Convert.ToInt32(trozos[0]);
                string msg;

                if (cod == 1)
                {
                    msg= trozos[1].Split('\0')[0];
                    if (msg == "1")
                    {
                        MessageBox.Show("Registro completado exitosamente. \n");
                        //this.logeado = true;
                        //OcultarElementosSignUp();
                        //OcultarElementosUnsubscirbe();
                        //this.Hide();
                        //PonerEnMarchaFormulario();
                    }
                    else if (msg == "-1")
                    {
                        MessageBox.Show("El usuario existe");
                    }
                    else 
                    {
                        MessageBox.Show("Otro error.");
                    }
                }
                if (cod == 2)
                {
                    msg = trozos[1].Split('\0')[0];
                    if (msg == "1")
                    {
                        MessageBox.Show("Bienvenido !!! :)");
                        //this.logeado = true;
                        //OcultarElementosLogin();
                        //OcultarElementosUnsubscribe();
                        //this.Hide();
                        //PonerEmMarchaFormulario();
                    }
                    else if (msg == "-1")
                    {
                        MessageBox.Show("Los datos son incorrectos o el usuario no existe");
                    }
                    else if (msg == "-2")
                    {
                        MessageBox.Show("El usuario ya esta conectado");
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        private void button1_Iniciar_Sesion_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPont con el ip del servidor y el puerto del servidor al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("10.0.2.15");
            IPEndPoint ipep = new IPEndPoint(direc, 9080);

            //Creamos el socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                //MessageBox.Show("Conectado")

                if (radioButton_nombre.Checked)
                {
                    string mensaje = "1/" + nombreBox.Text;
                    //Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("Tu nombre es:" + mensaje);
                }
                else if (radioButton_mail.Checked)
                {
                    string mensaje = "2/" + mailBox.Text;

                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("Tu mail es:" + mensaje);
                }

                else {
                    string mensaje = "3/" + contraseñaBox.Text;

                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("Tu contraseña es:" + mensaje);
                }
            }
            finally { server.Close(); }
            //Se terminó el servicio
            //Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();


            MostrarElementosLogin();
            //OcultarElementosSignUp();
            //OcultarElementosUnsubscribe();
        }

        private void button2_Regsitrarse_Click(object sender, EventArgs e)
        {

            //Creamos un IPEndPont con el ip del servidor y el puerto del servidor al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("10.0.2.15");
            IPEndPoint ipep = new IPEndPoint(direc, 9080);

            //Creamos el socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                //MessageBox.Show("Conectado")

                if (radioButton_nombre.Checked)
                {
                    string mensaje = "1/" + nombreBox.Text;
                    //Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("Tu nombre es:" + mensaje);
                }
                else if (radioButton_mail.Checked)
                {
                    string mensaje = "2/" + mailBox.Text;

                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("Tu mail es:" + mensaje);
                }

                else
                {
                    string mensaje = "3/" + contraseñaBox.Text;

                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("Tu contraseña es:" + mensaje);
                }
            }
            finally { server.Close(); }
            //Se terminó el servicio
            //Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();





            //signupLabel.Visible = true;
            //signupCorreoLabel.Visible = true;
            //signupUsuarioLabel.Visible = true;
            //signupContraseñaLabel.Visible = true;
            //signupCorreotextBox.Visible = true;
            //signupUsuariotextBox.Visible = true;
            //signupContraseñatextBox.Visible = true;
            //signupRegistrarButton.Visible = true;
        }

        private void MostrarElementosLogin()
        {
            //loginLabel.Visible = true;
            //loginUsuarioLabel.Visible = true;
            //loginContraseñaLabel.Visible = true;
            //loginUsuariotextBox.Visible = true;
            //loginContraseñatextBox.Visible = true;
            //loginEntrarButton.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
