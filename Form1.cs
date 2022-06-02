using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3EnRaya
{
    public partial class Form1 : Form
    {
        LogicaInterfaz log = new LogicaInterfaz();
        List<Jugador> listaGuadores;
        Jugador jug0;
        Jugador jug1;
        PictureBox[] posTablero;

        int equisOCirculo = 0;

        public Form1()
        {
            posTablero = new PictureBox[9];
            
            InitializeComponent();

            posTablero[0] = pb1;
            posTablero[1] = pb2;
            posTablero[2] = pb3;
            posTablero[3] = pb4;
            posTablero[4] = pb5;
            posTablero[5] = pb6;
            posTablero[6] = pb7;
            posTablero[7] = pb8;
            posTablero[8] = pb9;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaGuadores = new List<Jugador>();
            jug0 = new Jugador("Jugador O", 0);
            jug1 = new Jugador("Jugador X", 1);

            listaGuadores.Add(jug0);
            listaGuadores.Add(jug1);

            pararTablero();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            foreach (var pic in posTablero)
            {
                pic.Enabled = true;
                pic.BackgroundImage = null;
                pic.Tag = "";
            }

            lblPuntosO.Text = jug0.Puntos.ToString();
            lblPuntosX.Text = jug1.Puntos.ToString();
        }


       

        private void pb1_Click(object sender, EventArgs e)
        {
            clickPos(pb1);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            clickPos(pb2);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            clickPos(pb3);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            clickPos(pb4);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            clickPos(pb5);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            clickPos(pb6);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            clickPos(pb7);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            clickPos(pb8);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            clickPos(pb9);
        }


        private void pararTablero()
        {
            foreach (var pic in posTablero)
            {
                pic.Enabled = false;
            }
        }
        private void quienGana()
        {
            if (pb1.Tag.ToString() == "1" && pb2.Tag.ToString() == "1" && pb3.Tag.ToString() == "1")
            {
                jug1.Puntos++;
                lblPuntosX.Text = listaGuadores[1].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb1.Tag.ToString() == "0" && pb2.Tag.ToString() == "0" && pb3.Tag.ToString() == "0")
            {
                jug0.Puntos++;
                lblPuntosO.Text = listaGuadores[0].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb4.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb6.Tag.ToString() == "1")
            {
                jug1.Puntos++;
                lblPuntosX.Text = listaGuadores[1].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb4.Tag.ToString() == "0" && pb5.Tag.ToString() == "0" && pb6.Tag.ToString() == "0")
            {
                jug0.Puntos++;
                lblPuntosO.Text = listaGuadores[0].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb7.Tag.ToString() == "1" && pb8.Tag.ToString() == "1" && pb9.Tag.ToString() == "1")
            {
                jug1.Puntos++;
                lblPuntosX.Text = listaGuadores[1].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb7.Tag.ToString() == "0" && pb8.Tag.ToString() == "0" && pb9.Tag.ToString() == "0")
            {
                jug0.Puntos++;
                lblPuntosO.Text = listaGuadores[0].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb1.Tag.ToString() == "1" && pb4.Tag.ToString() == "1" && pb7.Tag.ToString() == "1")
            {
                jug1.Puntos++;
                lblPuntosX.Text = listaGuadores[1].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb1.Tag.ToString() == "0" && pb4.Tag.ToString() == "0" && pb7.Tag.ToString() == "0")
            {
                jug0.Puntos++;
                lblPuntosO.Text = listaGuadores[0].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb2.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb8.Tag.ToString() == "1")
            {
                jug1.Puntos++;
                lblPuntosX.Text = listaGuadores[1].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb2.Tag.ToString() == "0" && pb5.Tag.ToString() == "0" && pb8.Tag.ToString() == "0")
            {
                jug0.Puntos++;
                lblPuntosO.Text = listaGuadores[0].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb3.Tag.ToString() == "1" && pb6.Tag.ToString() == "1" && pb9.Tag.ToString() == "1")
            {
                jug1.Puntos++;
                lblPuntosX.Text = listaGuadores[1].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb3.Tag.ToString() == "0" && pb6.Tag.ToString() == "0" && pb9.Tag.ToString() == "0")
            {
                jug0.Puntos++;
                lblPuntosO.Text = listaGuadores[0].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb1.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb9.Tag.ToString() == "1")
            {
                jug1.Puntos++;
                lblPuntosX.Text = listaGuadores[1].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb1.Tag.ToString() == "0" && pb5.Tag.ToString() == "0" && pb9.Tag.ToString() == "0")
            {
                jug0.Puntos++;
                lblPuntosO.Text = listaGuadores[0].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb3.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb7.Tag.ToString() == "1")
            {
                jug1.Puntos++;
                lblPuntosX.Text = listaGuadores[1].Puntos.ToString();

                pararTablero();

                return;
            }

            if (pb3.Tag.ToString() == "0" && pb5.Tag.ToString() == "0" && pb7.Tag.ToString() == "0")
            {
                jug0.Puntos++;
                lblPuntosO.Text = listaGuadores[0].Puntos.ToString();

                pararTablero();

                return;
            }



        }

        private void clickPos(PictureBox p)
        {
            log.EfectoPulsacion(p);
  
            if (listaGuadores[0].Numero == equisOCirculo)
            {
                p.BackgroundImage = Properties.Resources.circulo;
                p.Tag = "0";
            }

            if (listaGuadores[1].Numero == equisOCirculo)
            {
                p.BackgroundImage = Properties.Resources.x;
                p.Tag = "1";
            }
            p.Enabled = false;

            quienGana();
            equisOcirculo();
        }

        private void equisOcirculo()
        {

            equisOCirculo++;

            if (equisOCirculo % 2 == 0)
            {
                equisOCirculo = 0;
            }
            if (equisOCirculo % 2 == 1)
            {
                equisOCirculo = 1;
            }
           
        }
    }
}
