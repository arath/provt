namespace provident.win.ui {
  partial class Shell {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.ux_main_menu = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ux_main_menu.SuspendLayout();
      this.SuspendLayout();
      // 
      // ux_main_menu
      // 
      this.ux_main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.ux_main_menu.Location = new System.Drawing.Point(0, 0);
      this.ux_main_menu.Name = "ux_main_menu";
      this.ux_main_menu.Size = new System.Drawing.Size(735, 24);
      this.ux_main_menu.TabIndex = 1;
      this.ux_main_menu.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // customersToolStripMenuItem
      // 
      this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
      this.customersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.customersToolStripMenuItem.Text = "Customers";
      // 
      // Shell
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(735, 565);
      this.Controls.Add(this.ux_main_menu);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.ux_main_menu;
      this.Name = "Shell";
      this.Text = "Provident";
      this.ux_main_menu.ResumeLayout(false);
      this.ux_main_menu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip ux_main_menu;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
  }
}

