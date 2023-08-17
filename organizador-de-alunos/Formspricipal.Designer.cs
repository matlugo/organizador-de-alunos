namespace organizador_de_alunos
{
    partial class Formspricipal
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
            this.estudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEstudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEstudantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRemoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudanteToolStripMenuItem,
            this.curoToolStripMenuItem,
            this.nOTASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // estudanteToolStripMenuItem
            // 
            this.estudanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEstudanteToolStripMenuItem,
            this.listarEstudantesToolStripMenuItem,
            this.estatisticasToolStripMenuItem,
            this.editarRemoverToolStripMenuItem});
            this.estudanteToolStripMenuItem.Name = "estudanteToolStripMenuItem";
            this.estudanteToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.estudanteToolStripMenuItem.Text = "ESTUDANTES";
            this.estudanteToolStripMenuItem.Click += new System.EventHandler(this.estudanteToolStripMenuItem_Click);
            // 
            // inserirEstudanteToolStripMenuItem
            // 
            this.inserirEstudanteToolStripMenuItem.Name = "inserirEstudanteToolStripMenuItem";
            this.inserirEstudanteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.inserirEstudanteToolStripMenuItem.Text = "Inserir Estudante";
            this.inserirEstudanteToolStripMenuItem.Click += new System.EventHandler(this.inserirEstudanteToolStripMenuItem_Click);
            // 
            // listarEstudantesToolStripMenuItem
            // 
            this.listarEstudantesToolStripMenuItem.Name = "listarEstudantesToolStripMenuItem";
            this.listarEstudantesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listarEstudantesToolStripMenuItem.Text = "Listar Estudantes";
            // 
            // estatisticasToolStripMenuItem
            // 
            this.estatisticasToolStripMenuItem.Name = "estatisticasToolStripMenuItem";
            this.estatisticasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.estatisticasToolStripMenuItem.Text = "Estatisticas";
            // 
            // editarRemoverToolStripMenuItem
            // 
            this.editarRemoverToolStripMenuItem.Name = "editarRemoverToolStripMenuItem";
            this.editarRemoverToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editarRemoverToolStripMenuItem.Text = "Editar/Remover";
            // 
            // curoToolStripMenuItem
            // 
            this.curoToolStripMenuItem.Name = "curoToolStripMenuItem";
            this.curoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.curoToolStripMenuItem.Text = "CURSO";
            // 
            // nOTASToolStripMenuItem
            // 
            this.nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            this.nOTASToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.nOTASToolStripMenuItem.Text = "NOTAS";
            // 
            // Formspricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(232)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formspricipal";
            this.Text = "SGA-Pricipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEstudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEstudantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRemoverToolStripMenuItem;
    }
}