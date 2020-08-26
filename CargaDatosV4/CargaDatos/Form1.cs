using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargaDatos
{
    public partial class frmInicio : Form
    {
        private string[] Nombres = new string[1];
        private string[] Apellidos = new string[1];
        
        Lista Nombre = new Lista();
        Pepe Var = new Pepe();
        Pepe Var2 = new Pepe();

        //Lista ListaDeNombres = new Lista();
        //Lista ListaDeApellidos = new Lista();

        int Indice = 0;

        public frmInicio()
        {
            InitializeComponent();
            //ListaDeNombres.Redimension();
            //ListaDeApellidos.Redimension();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            if (Indice < Nombres.Length)
            {
                CargaDatos();
            }
            else
            {
                //actualizo la dimensión de Nombres
                Nombres = Redimension(Nombres);

                //actualizo la dimensión de Apellidos
                //string[] tempa = new string[Apellidos.Length + 1];
                //for (int i = 0; i < Apellidos.Length; i++)
                //{
                //    tempa[i] = Apellidos[i];
                //}
                //Apellidos = tempa;
                Apellidos = Redimension(Apellidos);

                CargaDatos();
            }
            txtNombre.Focus();
            txtNombre.SelectAll();
        }

        private string[] Redimension(string[] Dato)
        {
            string[] temp = new string[Dato.Length + 1];
            for (int i = 0; i < Dato.Length; i++)
            {
                temp[i] = Dato[i];
            }
            Dato = temp;

            return Dato;
        }

        private void CargaDatos()
        {
            Nombres[Indice] = txtNombre.Text;
            Apellidos[Indice] = txtApellido.Text;
            Indice = Indice + 1;
            lblSalida.Text = lblSalida.Text + "\r\n" + txtNombre.Text + " " + txtApellido.Text;
        }
    }

    //public class Lista
    //{
    //    public string[] Redimension(string[] Dato)
    //    {
    //        string[] temp = new string[Dato.Length + 1];
    //        for (int i = 0; i < Dato.Length; i++)
    //        {
    //            temp[i] = Dato[i];
    //        }
    //        Dato = temp;

    //        return Dato;
    //    }

    //    public string[] OrdenarAlfabeticamente()
    //    {
    //        return new string[1];
    //    }

    //    public string Listar()
    //    {
    //    }

    //    public string[] agregar()
    //    {

    //    }
    //}
}
