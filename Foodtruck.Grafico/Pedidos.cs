using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.MultiSelect = false;
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.AutoGenerateColumns = false;
            List<Pedido> clientes = Program.Gerenciador.TodosOsPedidos();
            dgPedidos.DataSource = Pedido;
        }
    }
}
