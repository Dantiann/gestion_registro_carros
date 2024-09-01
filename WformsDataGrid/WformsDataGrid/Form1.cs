using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WformsDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string placa, tipo, modelo;

            placa = txtPlaca.Text;
            tipo = txtTipo.Text;
            modelo = txtModelo.Text;
            
            dgvVehiculos.Rows.Add(placa, tipo, modelo);
            
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtTipo.Text = "";
                     
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvVehiculos.Rows.Clear();
        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
