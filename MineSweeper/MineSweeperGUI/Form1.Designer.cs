namespace MineSweeperGUI
{
    partial class Form1
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MenuMineSweeper = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaIgraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pomočToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiBombeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.MenuMineSweeper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(6, 19);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1056, 365);
            this.pnlButtons.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlButtons);
            this.groupBox2.Location = new System.Drawing.Point(11, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1065, 389);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Igralna površina";
            // 
            // MenuMineSweeper
            // 
            this.MenuMineSweeper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuMineSweeper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.pomočToolStripMenuItem});
            this.MenuMineSweeper.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuMineSweeper.Location = new System.Drawing.Point(0, 0);
            this.MenuMineSweeper.Name = "MenuMineSweeper";
            this.MenuMineSweeper.Size = new System.Drawing.Size(1088, 24);
            this.MenuMineSweeper.TabIndex = 4;
            this.MenuMineSweeper.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaIgraToolStripMenuItem,
            this.zapriToolStripMenuItem1});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.gameToolStripMenuItem.Text = "Igra";
            // 
            // novaIgraToolStripMenuItem
            // 
            this.novaIgraToolStripMenuItem.Name = "novaIgraToolStripMenuItem";
            this.novaIgraToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.novaIgraToolStripMenuItem.Text = "Nova igra";
            this.novaIgraToolStripMenuItem.Click += new System.EventHandler(this.novaIgraToolStripMenuItem_Click);
            // 
            // zapriToolStripMenuItem1
            // 
            this.zapriToolStripMenuItem1.Name = "zapriToolStripMenuItem1";
            this.zapriToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.zapriToolStripMenuItem1.Text = "Zapri";
            this.zapriToolStripMenuItem1.Click += new System.EventHandler(this.zapriToolStripMenuItem1_Click);
            // 
            // pomočToolStripMenuItem
            // 
            this.pomočToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiBombeToolStripMenuItem});
            this.pomočToolStripMenuItem.Name = "pomočToolStripMenuItem";
            this.pomočToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomočToolStripMenuItem.Text = "Pomoč";
            // 
            // prikažiBombeToolStripMenuItem
            // 
            this.prikažiBombeToolStripMenuItem.Name = "prikažiBombeToolStripMenuItem";
            this.prikažiBombeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.prikažiBombeToolStripMenuItem.Text = "Prikaži bombe";
            this.prikažiBombeToolStripMenuItem.Click += new System.EventHandler(this.prikažiBombeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MenuMineSweeper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuMineSweeper;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minolovec";
            this.groupBox2.ResumeLayout(false);
            this.MenuMineSweeper.ResumeLayout(false);
            this.MenuMineSweeper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip MenuMineSweeper;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaIgraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomočToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiBombeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapriToolStripMenuItem1;


    }
}

