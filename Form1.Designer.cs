namespace Pascoa
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerenciarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Novo";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(107, 226);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Pedidos";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.pedidosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// novoToolStripMenuItem
			// 
			this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem});
			this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
			this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.novoToolStripMenuItem.Text = "Novo";
			// 
			// gerenciarToolStripMenuItem
			// 
			this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
			this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gerenciarToolStripMenuItem.Text = "Gerenciar";
			this.gerenciarToolStripMenuItem.Click += new System.EventHandler(this.gerenciarToolStripMenuItem_Click);
			// 
			// pedidosToolStripMenuItem
			// 
			this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem1});
			this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
			this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.pedidosToolStripMenuItem.Text = "Pedidos";
			// 
			// gerenciarToolStripMenuItem1
			// 
			this.gerenciarToolStripMenuItem1.Name = "gerenciarToolStripMenuItem1";
			this.gerenciarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.gerenciarToolStripMenuItem1.Text = "Gerenciar";
			this.gerenciarToolStripMenuItem1.Click += new System.EventHandler(this.gerenciarToolStripMenuItem1_Click);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem1;
	}
}

