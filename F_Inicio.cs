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
	public partial class F_Inicio : Form
	{
		public F_Inicio()
		{
			InitializeComponent();
		}

		private void F_Inicio_Load(object sender, EventArgs e)
		{

		}

		private void bt_voltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cb3_SelectedIndexChanged_1(object sender, EventArgs e)
		{

			if (cb3.Text == "50g")
			{
				MessageBox.Show("Escolha até três sabores");
				checkedListBox1.Enabled = true;
				cb4.Enabled = false;
				cb1.Text = "De Colher";
				cb1.Enabled = false;

			}
			else
			{
				checkedListBox1.Enabled = false;
				cb4.Enabled = true;
				cb1.Enabled = true;
				cb1.Text = null;
			}
		}

		private void cb1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cb1.Text == "Tradicional") 
			{
				cb4.Enabled = false;
			}
		}
	}
}
