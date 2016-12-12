using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_tic_tac_toe
{
    public partial class tic_tac_toe : Form
    {
        bool close = false;
        window_game game = new window_game();

        private static void GoToSite(string url)
        {
            System.Diagnostics.Process.Start("cmd", "/C start" + " " + url);
        }

        public tic_tac_toe()
        {
            InitializeComponent();
        }

        private void tic_tac_toe_Load(object sender, EventArgs e)
        {
            this.Hide();

            game.FormClosing += Game_FormClosing;
            game.Show();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.close = true;
            Application.Exit();
        }

        private void tic_tac_toe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.close == false)
            {
                e.Cancel = true;

                this.Hide();
            }
        }

        private void notify_menu_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This app was created by NewbProgramming.\n" +
                "New apps will be released at least once per week. Thank you for playing."
            );

            GoToSite("http://www.Facebook.com/NewbProgramming");
        }

        private void notify_Click(object sender, EventArgs e)
        {
            if(game.minimized == true)
            {
                game.Show();
                game.BringToFront();
            }
        }

        private void notify_menu_exit_Click(object sender, EventArgs e)
        {
            this.close = true;
            Application.Exit();
        }
    }
}
