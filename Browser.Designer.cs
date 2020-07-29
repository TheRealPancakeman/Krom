namespace Krom
{
    partial class Browser
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAdressBar = new System.Windows.Forms.ToolStripTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BrowserTabs = new System.Windows.Forms.TabControl();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReFresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEnterAdress = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.BrowserTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripButtonForward,
            this.toolStripButtonReFresh,
            this.toolStripButtonHome,
            this.toolStripAdressBar,
            this.toolStripButtonEnterAdress});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1164, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAdressBar
            // 
            this.toolStripAdressBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripAdressBar.Name = "toolStripAdressBar";
            this.toolStripAdressBar.Size = new System.Drawing.Size(400, 25);
            this.toolStripAdressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripAdressBar_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1156, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "+";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1156, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BrowserTabs
            // 
            this.BrowserTabs.Controls.Add(this.tabPage1);
            this.BrowserTabs.Controls.Add(this.tabPage2);
            this.BrowserTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserTabs.Location = new System.Drawing.Point(0, 25);
            this.BrowserTabs.Name = "BrowserTabs";
            this.BrowserTabs.SelectedIndex = 0;
            this.BrowserTabs.Size = new System.Drawing.Size(1164, 582);
            this.BrowserTabs.TabIndex = 1;
            this.BrowserTabs.Click += new System.EventHandler(this.BrowserTabs_Click);
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBack.Image = global::Krom.Properties.Resources.back;
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBack.Text = "Backward";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // toolStripButtonForward
            // 
            this.toolStripButtonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonForward.Image = global::Krom.Properties.Resources.forward;
            this.toolStripButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForward.Name = "toolStripButtonForward";
            this.toolStripButtonForward.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonForward.Text = "Forward";
            this.toolStripButtonForward.Click += new System.EventHandler(this.toolStripButtonForward_Click);
            // 
            // toolStripButtonReFresh
            // 
            this.toolStripButtonReFresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReFresh.Image = global::Krom.Properties.Resources.refresh;
            this.toolStripButtonReFresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReFresh.Name = "toolStripButtonReFresh";
            this.toolStripButtonReFresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReFresh.Text = "Relod";
            this.toolStripButtonReFresh.Click += new System.EventHandler(this.toolStripButtonReFresh_Click);
            // 
            // toolStripButtonHome
            // 
            this.toolStripButtonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHome.Image = global::Krom.Properties.Resources.home;
            this.toolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHome.Name = "toolStripButtonHome";
            this.toolStripButtonHome.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHome.Text = "Home";
            this.toolStripButtonHome.Click += new System.EventHandler(this.toolStripButtonHome_Click);
            // 
            // toolStripButtonEnterAdress
            // 
            this.toolStripButtonEnterAdress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEnterAdress.Image = global::Krom.Properties.Resources.enter;
            this.toolStripButtonEnterAdress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEnterAdress.Name = "toolStripButtonEnterAdress";
            this.toolStripButtonEnterAdress.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEnterAdress.Text = "Enter";
            this.toolStripButtonEnterAdress.Click += new System.EventHandler(this.toolStripButtonEnter_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 607);
            this.Controls.Add(this.BrowserTabs);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Browser";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.BrowserTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonHome;
        private System.Windows.Forms.ToolStripTextBox toolStripAdressBar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEnterAdress;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripButton toolStripButtonForward;
        private System.Windows.Forms.ToolStripButton toolStripButtonReFresh;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl BrowserTabs;
    }
}

