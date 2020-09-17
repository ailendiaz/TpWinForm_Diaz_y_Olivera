﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApp
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Elimine el codigo de prueba

            ArticulosNegocio auxNegocio = new ArticulosNegocio();
            Articulos auxArticulo = new Articulos();
            

            auxArticulo.marca = new Marca();
            auxArticulo.categoria = new Categoria();

            auxArticulo = auxNegocio.buscar(txtBuscar.Text);
            List<Articulos> lista = new List<Articulos>();
            lista.Add(auxArticulo);
            
            dgvBuscar.DataSource = lista;
            //txtImporte.Text = (String)auxArticulo.Precio;

        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            frmModificar modificar = new frmModificar();
            modificar.ShowDialog();
        }
    }
}
