namespace Pascoa
{
	partial class F_GerenciarPedidos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bt1 = new System.Windows.Forms.Button();
			this.bt2 = new System.Windows.Forms.Button();
			this.bt3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(609, 235);
			this.dataGridView1.TabIndex = 0;
			// 
			// bt1
			// 
			this.bt1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt1.Location = new System.Drawing.Point(12, 253);
			this.bt1.Name = "bt1";
			this.bt1.Size = new System.Drawing.Size(109, 37);
			this.bt1.TabIndex = 1;
			this.bt1.Text = "Editar";
			this.bt1.UseVisualStyleBackColor = true;
			// 
			// bt2
			// 
			this.bt2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt2.Location = new System.Drawing.Point(261, 253);
			this.bt2.Name = "bt2";
			this.bt2.Size = new System.Drawing.Size(109, 37);
			this.bt2.TabIndex = 2;
			this.bt2.Text = "Remover";
			this.bt2.UseVisualStyleBackColor = true;
			// 
			// bt3
			// 
			this.bt3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt3.Location = new System.Drawing.Point(512, 253);
			this.bt3.Name = "bt3";
			this.bt3.Size = new System.Drawing.Size(109, 37);
			this.bt3.TabIndex = 3;
			this.bt3.Text = "Voltar";
			this.bt3.UseVisualStyleBackColor = true;
			this.bt3.Click += new System.EventHandler(this.bt3_Click);
			// 
			// F_GerenciarPedidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 300);
			this.Controls.Add(this.bt3);
			this.Controls.Add(this.bt2);
			this.Controls.Add(this.bt1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "F_GerenciarPedidos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "F_GerenciarPedidos";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button bt1;
		private System.Windows.Forms.Button bt2;
		private System.Windows.Forms.Button bt3;
	}
}