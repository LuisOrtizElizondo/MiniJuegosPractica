namespace TATETI
{
    partial class PantallaPpal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.barraMenuJuegos = new System.Windows.Forms.ToolStripMenuItem();
            this.barraMenuTateti = new System.Windows.Forms.ToolStripMenuItem();
            this.barraMenuAhorcado = new System.Windows.Forms.ToolStripMenuItem();
            this.barraMenuAhorcado1J = new System.Windows.Forms.ToolStripMenuItem();
            this.barraMenuAhorcado2J = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraMenuJuegos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // barraMenuJuegos
            // 
            this.barraMenuJuegos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraMenuTateti,
            this.barraMenuAhorcado});
            this.barraMenuJuegos.Name = "barraMenuJuegos";
            this.barraMenuJuegos.Size = new System.Drawing.Size(55, 20);
            this.barraMenuJuegos.Text = "Juegos";
            // 
            // barraMenuTateti
            // 
            this.barraMenuTateti.Name = "barraMenuTateti";
            this.barraMenuTateti.Size = new System.Drawing.Size(180, 22);
            this.barraMenuTateti.Text = "Tateti";
            this.barraMenuTateti.Click += new System.EventHandler(this.barraMenuTateti_Click);
            // 
            // barraMenuAhorcado
            // 
            this.barraMenuAhorcado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraMenuAhorcado1J,
            this.barraMenuAhorcado2J});
            this.barraMenuAhorcado.Name = "barraMenuAhorcado";
            this.barraMenuAhorcado.Size = new System.Drawing.Size(180, 22);
            this.barraMenuAhorcado.Text = "Ahorcado";
            // 
            // barraMenuAhorcado1J
            // 
            this.barraMenuAhorcado1J.Name = "barraMenuAhorcado1J";
            this.barraMenuAhorcado1J.Size = new System.Drawing.Size(180, 22);
            this.barraMenuAhorcado1J.Text = "1 Jugador";
            this.barraMenuAhorcado1J.Click += new System.EventHandler(this.barraMenuAhorcado1J_Click);
            // 
            // barraMenuAhorcado2J
            // 
            this.barraMenuAhorcado2J.Name = "barraMenuAhorcado2J";
            this.barraMenuAhorcado2J.Size = new System.Drawing.Size(180, 22);
            this.barraMenuAhorcado2J.Text = "2 Jugadores";
            this.barraMenuAhorcado2J.Click += new System.EventHandler(this.barraMenuAhorcado2J_Click);
            // 
            // PantallaPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 749);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(600, 900);
            this.MinimumSize = new System.Drawing.Size(600, 726);
            this.Name = "PantallaPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Juegos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem barraMenuJuegos;
        private System.Windows.Forms.ToolStripMenuItem barraMenuTateti;
        private System.Windows.Forms.ToolStripMenuItem barraMenuAhorcado;
        private System.Windows.Forms.ToolStripMenuItem barraMenuAhorcado1J;
        private System.Windows.Forms.ToolStripMenuItem barraMenuAhorcado2J;
    }
}