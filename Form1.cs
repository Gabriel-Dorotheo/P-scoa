using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pascoa
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			F_Inicio abrir = new F_Inicio();
			abrir.Show();
		}


		private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			F_Inicio abrir = new F_Inicio();
			abrir.Show();
		}

		private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			F_GerenciarPedidos abrir = new F_GerenciarPedidos();
			abrir.Show();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			F_GerenciarPedidos abrir = new F_GerenciarPedidos();
			abrir.Show();
		}
	}
}
