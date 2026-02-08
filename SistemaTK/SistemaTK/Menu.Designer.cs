namespace SistemaTK
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnaboutus = new FontAwesome.Sharp.IconMenuItem();
            this.btneventos = new FontAwesome.Sharp.IconMenuItem();
            this.btnlogin = new FontAwesome.Sharp.IconMenuItem();
            this.btnsoporte = new FontAwesome.Sharp.IconMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(888, 67);
            this.menutitulo.TabIndex = 0;
            this.menutitulo.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnaboutus,
            this.btneventos,
            this.btnlogin,
            this.btnsoporte});
            this.menuStrip1.Location = new System.Drawing.Point(0, 67);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(888, 58);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnaboutus
            // 
            this.btnaboutus.AutoSize = false;
            this.btnaboutus.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnaboutus.IconChar = FontAwesome.Sharp.IconChar.NfcSymbol;
            this.btnaboutus.IconColor = System.Drawing.Color.Black;
            this.btnaboutus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnaboutus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnaboutus.Name = "btnaboutus";
            this.btnaboutus.Size = new System.Drawing.Size(122, 54);
            this.btnaboutus.Text = "Acerca de Nosotros";
            this.btnaboutus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btneventos
            // 
            this.btneventos.AutoSize = false;
            this.btneventos.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btneventos.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btneventos.IconColor = System.Drawing.Color.Black;
            this.btneventos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneventos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btneventos.Name = "btneventos";
            this.btneventos.Size = new System.Drawing.Size(122, 54);
            this.btneventos.Text = "Eventos";
            this.btneventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnlogin
            // 
            this.btnlogin.AutoSize = false;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnlogin.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnlogin.IconColor = System.Drawing.Color.Black;
            this.btnlogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(122, 54);
            this.btnlogin.Text = "Salir";
            this.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnsoporte
            // 
            this.btnsoporte.AutoSize = false;
            this.btnsoporte.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnsoporte.IconChar = FontAwesome.Sharp.IconChar.CommentAlt;
            this.btnsoporte.IconColor = System.Drawing.Color.Black;
            this.btnsoporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsoporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnsoporte.Name = "btnsoporte";
            this.btnsoporte.Size = new System.Drawing.Size(122, 54);
            this.btnsoporte.Text = "Soporte";
            this.btnsoporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 339);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(671, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menutitulo;
            this.Name = "Menu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconMenuItem btnaboutus;
        private FontAwesome.Sharp.IconMenuItem btneventos;
        private FontAwesome.Sharp.IconMenuItem btnlogin;
        private FontAwesome.Sharp.IconMenuItem btnsoporte;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

