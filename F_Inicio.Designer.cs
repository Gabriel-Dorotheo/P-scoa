namespace Pascoa
{
	partial class F_Inicio
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
			this.bt_voltar = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bt_adicionar = new System.Windows.Forms.Button();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.cb3 = new System.Windows.Forms.ComboBox();
			this.cb4 = new System.Windows.Forms.ComboBox();
			this.cb1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_nome = new System.Windows.Forms.Label();
			this.lb_pedido = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bt_voltar
			// 
			this.bt_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_voltar.Location = new System.Drawing.Point(186, 350);
			this.bt_voltar.Name = "bt_voltar";
			this.bt_voltar.Size = new System.Drawing.Size(90, 33);
			this.bt_voltar.TabIndex = 25;
			this.bt_voltar.Text = "Voltar";
			this.bt_voltar.UseVisualStyleBackColor = true;
			this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Branco",
            "Ao leite"});
			this.comboBox1.Location = new System.Drawing.Point(112, 241);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(194, 24);
			this.comboBox1.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(21, 242);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 19);
			this.label4.TabIndex = 23;
			this.label4.Text = "Chocolate";
			// 
			// bt_adicionar
			// 
			this.bt_adicionar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_adicionar.Location = new System.Drawing.Point(53, 350);
			this.bt_adicionar.Name = "bt_adicionar";
			this.bt_adicionar.Size = new System.Drawing.Size(90, 33);
			this.bt_adicionar.TabIndex = 22;
			this.bt_adicionar.Text = "Adicionar";
			this.bt_adicionar.UseVisualStyleBackColor = true;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Chocolate ao leite",
            "Paçoca",
            "Sensação",
            "Beijinho",
            "Prestigio",
            "Brownie"});
			this.checkedListBox1.Location = new System.Drawing.Point(186, 123);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
			this.checkedListBox1.TabIndex = 21;
			// 
			// cb3
			// 
			this.cb3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb3.FormattingEnabled = true;
			this.cb3.Items.AddRange(new object[] {
            "50g",
            "250g",
            "500g"});
			this.cb3.Location = new System.Drawing.Point(105, 145);
			this.cb3.Name = "cb3";
			this.cb3.Size = new System.Drawing.Size(75, 21);
			this.cb3.TabIndex = 20;
			this.cb3.SelectedIndexChanged += new System.EventHandler(this.cb3_SelectedIndexChanged_1);
			// 
			// cb4
			// 
			this.cb4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb4.FormattingEnabled = true;
			this.cb4.Items.AddRange(new object[] {
            "Chocolate ao leite",
            "Paçoca",
            "Sensação",
            "Beijinho",
            "Prestigio",
            "Brownie",
            "Nozes"});
			this.cb4.Location = new System.Drawing.Point(83, 287);
			this.cb4.Name = "cb4";
			this.cb4.Size = new System.Drawing.Size(223, 24);
			this.cb4.TabIndex = 19;
			// 
			// cb1
			// 
			this.cb1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb1.FormattingEnabled = true;
			this.cb1.Items.AddRange(new object[] {
            "Tradicional",
            "Trufado",
            "De Colher"});
			this.cb1.Location = new System.Drawing.Point(83, 193);
			this.cb1.Name = "cb1";
			this.cb1.Size = new System.Drawing.Size(97, 21);
			this.cb1.TabIndex = 18;
			this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(83, 97);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(223, 20);
			this.textBox1.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 19);
			this.label3.TabIndex = 16;
			this.label3.Text = "Tamanho";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 292);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 19);
			this.label2.TabIndex = 15;
			this.label2.Text = "Sabor";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 19);
			this.label1.TabIndex = 14;
			this.label1.Text = "Tipo";
			// 
			// lb_nome
			// 
			this.lb_nome.AutoSize = true;
			this.lb_nome.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nome.Location = new System.Drawing.Point(21, 96);
			this.lb_nome.Name = "lb_nome";
			this.lb_nome.Size = new System.Drawing.Size(61, 19);
			this.lb_nome.TabIndex = 13;
			this.lb_nome.Text = "Cliente";
			// 
			// lb_pedido
			// 
			this.lb_pedido.AutoSize = true;
			this.lb_pedido.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_pedido.Location = new System.Drawing.Point(77, 25);
			this.lb_pedido.Name = "lb_pedido";
			this.lb_pedido.Size = new System.Drawing.Size(194, 36);
			this.lb_pedido.TabIndex = 26;
			this.lb_pedido.Text = "Novo Pedido";
			// 
			// F_Inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 401);
			this.Controls.Add(this.lb_pedido);
			this.Controls.Add(this.bt_voltar);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bt_adicionar);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.cb3);
			this.Controls.Add(this.cb4);
			this.Controls.Add(this.cb1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_nome);
			this.MaximizeBox = false;
			this.Name = "F_Inicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "F_Inicio";
			this.Load += new System.EventHandler(this.F_Inicio_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_voltar;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bt_adicionar;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.ComboBox cb3;
		private System.Windows.Forms.ComboBox cb4;
		private System.Windows.Forms.ComboBox cb1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lb_nome;
		private System.Windows.Forms.Label lb_pedido;
	}
}