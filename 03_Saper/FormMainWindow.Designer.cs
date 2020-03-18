namespace _03_Saper
{
    partial class FormMainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trudnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prostaToolStripMenuItem,
            this.średniaToolStripMenuItem,
            this.trudnaToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // prostaToolStripMenuItem
            // 
            this.prostaToolStripMenuItem.Name = "prostaToolStripMenuItem";
            this.prostaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prostaToolStripMenuItem.Text = "Prosta";
            this.prostaToolStripMenuItem.Click += new System.EventHandler(this.prostaToolStripMenuItem_Click);
            // 
            // średniaToolStripMenuItem
            // 
            this.średniaToolStripMenuItem.Name = "średniaToolStripMenuItem";
            this.średniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.średniaToolStripMenuItem.Text = "Średnia";
            this.średniaToolStripMenuItem.Click += new System.EventHandler(this.średniaToolStripMenuItem_Click);
            // 
            // trudnaToolStripMenuItem
            // 
            this.trudnaToolStripMenuItem.Name = "trudnaToolStripMenuItem";
            this.trudnaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trudnaToolStripMenuItem.Text = "Trudna";
            this.trudnaToolStripMenuItem.Click += new System.EventHandler(this.trudnaToolStripMenuItem_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 24);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(800, 426);
            this.panelButtons.TabIndex = 1;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMainWindow";
            this.Text = "Saper v0.1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prostaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trudnaToolStripMenuItem;
        private System.Windows.Forms.Panel panelButtons;
    }
}

