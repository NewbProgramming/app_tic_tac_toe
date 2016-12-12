namespace app_tic_tac_toe
{
    partial class tic_tac_toe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tic_tac_toe));
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notify_menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.notify_menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.notify_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.notify_menu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Tic Tac Toe";
            this.notify.Visible = true;
            this.notify.Click += new System.EventHandler(this.notify_Click);
            // 
            // notify_menu
            // 
            this.notify_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notify_menu_about,
            this.notify_menu_exit});
            this.notify_menu.Name = "notify_menu";
            this.notify_menu.Size = new System.Drawing.Size(108, 48);
            // 
            // notify_menu_about
            // 
            this.notify_menu_about.Name = "notify_menu_about";
            this.notify_menu_about.Size = new System.Drawing.Size(107, 22);
            this.notify_menu_about.Text = "About";
            this.notify_menu_about.Click += new System.EventHandler(this.notify_menu_about_Click);
            // 
            // notify_menu_exit
            // 
            this.notify_menu_exit.Name = "notify_menu_exit";
            this.notify_menu_exit.Size = new System.Drawing.Size(107, 22);
            this.notify_menu_exit.Text = "Exit";
            this.notify_menu_exit.Click += new System.EventHandler(this.notify_menu_exit_Click);
            // 
            // tic_tac_toe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 49);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tic_tac_toe";
            this.Text = "Tic Tac Toe";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tic_tac_toe_FormClosing);
            this.Load += new System.EventHandler(this.tic_tac_toe_Load);
            this.notify_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip notify_menu;
        private System.Windows.Forms.ToolStripMenuItem notify_menu_about;
        private System.Windows.Forms.ToolStripMenuItem notify_menu_exit;
    }
}

