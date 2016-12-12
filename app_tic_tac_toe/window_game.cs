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
    public partial class window_game : Form
    {
        public bool minimized = false;
        bool turn = true; // true = X; false = O

        private bool CheckIfTurnAvailable()
        {
            if (A1.Enabled == true || A2.Enabled == true || A3.Enabled == true)
            {
                return true;
            }

            if (B1.Enabled == true || B2.Enabled == true || B3.Enabled == true)
            {
                return true;
            }

            if (C1.Enabled == true || C2.Enabled == true || C3.Enabled == true)
            {
                return true;
            }
            return false;
        }

        private bool CheckForWinner()
        {
            // Horizontal Checks
            if(A1.Enabled == false && A1.Text == A2.Text && A2.Text == A3.Text)
            {
                return true;
            }

            if(B1.Enabled == false && B1.Text == B2.Text && B2.Text == B3.Text)
            {
                return true;
            }

            if(C1.Enabled == false && C1.Text == C2.Text && C2.Text == C3.Text)
            {
                return true;
            }

            // Vertical Checks
            if(A1.Enabled == false && A1.Text == B1.Text && B1.Text == C1.Text)
            {
                return true;
            }

            if(A2.Enabled == false && A2.Text == B2.Text && B2.Text == C2.Text)
            {
                return true;
            }

            if(A3.Enabled == false && A3.Text == B3.Text && B3.Text == C3.Text)
            {
                return true;
            }

            // Diagonal Checks
            if(A1.Enabled == false && A1.Text == B2.Text && B2.Text == C3.Text)
            {
                return true;
            }

            if(A3.Enabled == false && A3.Text == B2.Text && B2.Text == C1.Text)
            {
                return true;
            }
            return false;
        }

        private void Reset()
        {
            A1.Enabled = false; A2.Enabled = false; A3.Enabled = false;
            B1.Enabled = false; B2.Enabled = false; B3.Enabled = false;
            C1.Enabled = false; C2.Enabled = false; C3.Enabled = false;

            A1.ForeColor = Color.Black; A2.ForeColor = Color.Black; A3.ForeColor = Color.Black;
            B1.ForeColor = Color.Black; B2.ForeColor = Color.Black; B3.ForeColor = Color.Black;
            C1.ForeColor = Color.Black; C2.ForeColor = Color.Black; C3.ForeColor = Color.Black;

            A1.Text = string.Empty; A2.Text = string.Empty; A3.Text = string.Empty;
            B1.Text = string.Empty; B2.Text = string.Empty; B3.Text = string.Empty;
            C1.Text = string.Empty; C2.Text = string.Empty; C3.Text = string.Empty;
            
            A1.Enabled = true; A2.Enabled = true; A3.Enabled = true;
            B1.Enabled = true; B2.Enabled = true; B3.Enabled = true;
            C1.Enabled = true; C2.Enabled = true; C3.Enabled = true;

            // X will always go first.
            this.turn = true;
            this.Focus();
        }

        public window_game()
        {
            InitializeComponent();
        }

        private void window_game_Load(object sender, EventArgs e)
        {
            Reset();
        }
        
        private void button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.Enabled = false;
            button.Text = (this.turn == true) ? "X": "O";
            button.ForeColor = (this.turn == true) ? Color.Red : Color.Blue;

            if(CheckForWinner() == true)
            {
                MessageBox.Show(string.Format("{0} won!", button.Text));

                Reset();
                return;
            }

            if(CheckIfTurnAvailable() == false)
            {
                MessageBox.Show(string.Format("Draw!"));

                Reset();
                return;
            }

            this.turn = !this.turn;
            this.Focus();
        }

        private void window_game_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                this.minimized = true;
                this.Hide();
            }
            else 
            {
                this.minimized = false;
            }
        }
    }
}
