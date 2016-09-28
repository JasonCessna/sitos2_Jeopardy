/* Created by Jason Cessna 2016
 * Any code is free to duplicate but please give credit in the comments
 * Thanks for reading, any advice is always appreciated!
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sitos_jeapordy
{
    public partial class sitos2Jeopardy : Form
    {
        public sitos2Jeopardy()
        {
            InitializeComponent();
            
           
        }
        public bool startGame = false;
        public int teamTurn = 0;
        public int amtTeams = 0;
        int team1Amt = 0;
        int team2Amt = 0;
        int team3Amt = 0;
        int team4Amt = 0;
        int team5Amt = 0;
        int team6Amt = 0;
        int team7Amt = 0;
        int team8Amt = 0;
        string[] teamNames = new string[8];


        

        /* ------------------------------------------------------- *
         * -----------Functions for button click calls------------ *
         * ------------------------------------------------------- */
        void buttonClick(Button btn, int value)
        {
            btn.ForeColor = Color.Firebrick;
            btn.Enabled = false;
            btn.BackColor = Color.Firebrick;
            teamTurn = value;
        
        }
        
        void buttonClick(Button btn, int value, char column, string boxQuestion)
        {
            if (teamTurn == 0)
                MessageBox.Show("Select a team to pick!");
            else
                using (question frm = new question(value, column, boxQuestion, teamTurn, amtTeams, teamNames))
                {
                    if (startGame != false)
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            int[] Scores = frm.UpdateScores;
                            team1Amt += Scores[0];
                            team2Amt += Scores[1];
                            team3Amt += Scores[2];
                            team4Amt += Scores[3];
                            team5Amt += Scores[4];
                            team6Amt += Scores[5];
                            team7Amt += Scores[6];
                            team8Amt += Scores[7];
                            int wasCorrect = Scores[8];
                            btnTeam1.BackColor = Color.MidnightBlue;
                            btnTeam2.BackColor = Color.MidnightBlue;
                            btnTeam3.BackColor = Color.MidnightBlue;
                            btnTeam4.BackColor = Color.MidnightBlue;
                            btnTeam5.BackColor = Color.MidnightBlue;
                            btnTeam6.BackColor = Color.MidnightBlue;
                            btnTeam7.BackColor = Color.MidnightBlue;
                            btnTeam8.BackColor = Color.MidnightBlue;
                            resetTeamSelection();
                            if (wasCorrect > 0)
                            {
                                int maxValue = Scores.Max();
                                int maxIndex = Scores.ToList().IndexOf(maxValue);
                                if (maxIndex == 0)
                                {
                                    btnTeam1.BackColor = Color.YellowGreen;
                                    teamTurn = 1;
                                }
                                else if (maxIndex == 1)
                                {
                                    btnTeam2.BackColor = Color.YellowGreen;
                                    teamTurn = 2;
                                }
                                else if (maxIndex == 2)
                                {
                                    btnTeam3.BackColor = Color.YellowGreen;
                                    teamTurn = 3;
                                }
                                else if (maxIndex == 3)
                                {
                                    btnTeam4.BackColor = Color.YellowGreen;
                                    teamTurn = 4;
                                }
                                else if (maxIndex == 4)
                                {
                                    btnTeam5.BackColor = Color.YellowGreen;
                                    teamTurn = 5;
                                }
                                else if (maxIndex == 5)
                                {
                                    btnTeam6.BackColor = Color.YellowGreen;
                                    teamTurn = 6;
                                }
                                else if (maxIndex == 6)
                                {
                                    btnTeam7.BackColor = Color.YellowGreen;
                                    teamTurn = 7;
                                }
                                else if (maxIndex == 7)
                                {
                                    btnTeam8.BackColor = Color.YellowGreen;
                                    teamTurn = 8;
                                }
                            }
                            
                            lblScore1.Text = "$" + team1Amt;
                            lblScore2.Text = "$" + team2Amt;
                            lblScore3.Text = "$" + team3Amt;
                            lblScore4.Text = "$" + team4Amt;
                            lblScore5.Text = "$" + team5Amt;
                            lblScore6.Text = "$" + team6Amt;
                            lblScore7.Text = "$" + team7Amt;
                            lblScore8.Text = "$" + team8Amt;
                            btn.ForeColor = Color.Firebrick;
                            btn.Enabled = false;
                            btn.BackColor = Color.Firebrick;
                           
                        }
                }
           

        }




        /* ------------------------------------------------------- *
         * ---------------------BOARD BUTTONS--------------------- *
         * ------------------------------------------------------- */

        /*-------COLUMN A-------*/
        private void btnA200_Click(object sender, EventArgs e)
        {
            char column = 'a';
            string boxQuestion = "Question goes here";
            buttonClick(btnA200, 200, column, boxQuestion);
        }

        private void btnA400_Click(object sender, EventArgs e)
        {
            char column = 'a';
            string boxQuestion = "Question goes here";
            buttonClick(btnA400, 400, column, boxQuestion);
        }

        private void btnA600_Click(object sender, EventArgs e)
        {
            char column = 'a';
            string boxQuestion = "Question goes here";
            buttonClick(btnA600, 600, column, boxQuestion);
        }

        private void btnA800_Click(object sender, EventArgs e)
        {
            char column = 'a';
            string boxQuestion = "Question goes here";
            buttonClick(btnA800, 800, column, boxQuestion);
        }

        private void btnA1000_Click(object sender, EventArgs e)
        {
            char column = 'a';
            string boxQuestion = "Question goes here";
            buttonClick(btnA1000, 1000, column, boxQuestion);
        }
        /*-------COLUMN B-------*/

        private void btnB200_Click(object sender, EventArgs e)
        {
            char column = 'b';
            string boxQuestion = "Question goes here";
            buttonClick(btnB200, 200, column, boxQuestion);
        }

        private void btnB400_Click(object sender, EventArgs e)
        {
            char column = 'b';
            string boxQuestion = "Question goes here";
            buttonClick(btnB400, 400, column, boxQuestion);
        }

        private void btnB600_Click(object sender, EventArgs e)
        {
            char column = 'b';
            string boxQuestion = "Question goes here";
            buttonClick(btnB600, 600, column, boxQuestion);
        }

        private void btnB800_Click(object sender, EventArgs e)
        {
            char column = 'b';
            string boxQuestion = "Question goes here";
            buttonClick(btnB800, 800, column, boxQuestion);
        }

        private void btnB1000_Click(object sender, EventArgs e)
        {
            char column = 'b';
            string boxQuestion = "Question goes here";
            buttonClick(btnB1000, 1000, column, boxQuestion);
        }

        /*-------COLUMN C-------*/
        private void btnC200_Click(object sender, EventArgs e)
        {
            char column = 'c';
            string boxQuestion = "Question goes here";
            buttonClick(btnC200, 200, column, boxQuestion);
        }

        private void btnC400_Click(object sender, EventArgs e)
        {
            char column = 'c';
            string boxQuestion = "Question goes here";
            buttonClick(btnC400, 400, column, boxQuestion);
        }

        private void btnC600_Click(object sender, EventArgs e)
        {
            char column = 'c';
            string boxQuestion = "Question goes here";
            buttonClick(btnC600, 600, column, boxQuestion);
        }

        private void btnC800_Click(object sender, EventArgs e)
        {
            char column = 'c';
            string boxQuestion = "Question goes here";
            buttonClick(btnC800, 800, column, boxQuestion);
        }

        private void btnC1000_Click(object sender, EventArgs e)
        {
            char column = 'c';
            string boxQuestion = "Question goes here";
            buttonClick(btnC1000, 1000, column, boxQuestion);
        }

        /*-------COLUMN D-------*/
        private void btnD200_Click(object sender, EventArgs e)
        {
            char column = 'd';
            string boxQuestion = "Question goes here";
            buttonClick(btnD200, 200, column, boxQuestion);
        }

        private void btnD400_Click(object sender, EventArgs e)
        {
            char column = 'd';
            string boxQuestion = "Question goes here";
            buttonClick(btnD400, 400, column, boxQuestion);
        }

        private void btnD600_Click(object sender, EventArgs e)
        {
            char column = 'd';
            string boxQuestion = "Question goes here";
            buttonClick(btnD600, 600, column, boxQuestion);
        }

        private void btnD800_Click(object sender, EventArgs e)
        {
            char column = 'd';
            string boxQuestion = "Question goes here";
            buttonClick(btnD800, 800, column, boxQuestion);
        }

        private void btnD1000_Click(object sender, EventArgs e)
        {
            char column = 'd';
            string boxQuestion = "Question goes here";
            buttonClick(btnD1000, 1000, column, boxQuestion);
        }

        /*-------COLUMN E-------*/
        private void btnE200_Click(object sender, EventArgs e)
        {
            char column = 'e';
            string boxQuestion = "Question goes here";
            buttonClick(btnE200, 200, column, boxQuestion);
        }

        private void btnE400_Click(object sender, EventArgs e)
        {
            char column = 'e';
            string boxQuestion = "Question goes here";
            buttonClick(btnE400, 400, column, boxQuestion);
        }

        private void btnE600_Click(object sender, EventArgs e)
        {
            char column = 'e';
            string boxQuestion = "Question goes here";
            buttonClick(btnE600, 600, column, boxQuestion);
        }

        private void btnE800_Click(object sender, EventArgs e)
        {
            char column = 'e';
            string boxQuestion = "Question goes here";
            buttonClick(btnE800, 800, column, boxQuestion);
        }

        private void btnE1000_Click(object sender, EventArgs e)
        {
            char column = 'e';
            string boxQuestion = "Question goes here";
            buttonClick(btnE1000, 1000, column, boxQuestion);
        }

        /*-------COLUMN FS-------*/
        private void btnF200_Click(object sender, EventArgs e)
        {
            char column = 'f';
            string boxQuestion = "Question goes here";
            buttonClick(btnF200, 200, column, boxQuestion);
        }

        private void btnF400_Click(object sender, EventArgs e)
        {
            char column = 'f';
            string boxQuestion = "Question goes here";
            buttonClick(btnF400, 400, column, boxQuestion);
        }

        private void btnF600_Click(object sender, EventArgs e)
        {
            char column = 'f';
            string boxQuestion = "Question goes here";
            buttonClick(btnF600, 600, column, boxQuestion);
        }

        private void btnF800_Click(object sender, EventArgs e)
        {
            char column = 'f';
            string boxQuestion = "Question goes here";
            buttonClick(btnF800, 800, column, boxQuestion);
        }

        private void btnF1000_Click(object sender, EventArgs e)
        {
            char column = 'f';
            string boxQuestion = "Question goes here";
            buttonClick(btnF1000, 1000, column, boxQuestion);
        }

        /* ------------------------------------------------------- *
        * ----------------------MENU OPTIONS---------------------- *
        * ------------------------------------------------------- */
      
        public void resetTeamSelection()
        {
            btnTeam1.BackColor = Color.MidnightBlue;
            btnTeam2.BackColor = Color.MidnightBlue;
            btnTeam3.BackColor = Color.MidnightBlue;
            btnTeam4.BackColor = Color.MidnightBlue;
            btnTeam5.BackColor = Color.MidnightBlue;
            btnTeam6.BackColor = Color.MidnightBlue;
            btnTeam7.BackColor = Color.MidnightBlue;
            btnTeam8.BackColor = Color.MidnightBlue;
            if (teamNames[0] == "New Team")
            {
                btnTeam1.Text = "";
                btnTeam1.Enabled = false;
                btnTeam1.BackColor = Color.Black;
            }
            if (teamNames[1] == "New Team")
            {
                btnTeam2.Text = "";
                btnTeam2.Enabled = false;
                btnTeam2.BackColor = Color.Black;
            }
            if (teamNames[2] == "New Team")
            {
                btnTeam3.Text = "";
                btnTeam3.Enabled = false;
                btnTeam3.BackColor = Color.Black;
            }
            if (teamNames[3] == "New Team")
            {
                btnTeam4.Text = "";
                btnTeam4.Enabled = false;
                btnTeam4.BackColor = Color.Black;
            }
            if (teamNames[4] == "New Team")
            {
                btnTeam5.Text = "";
                btnTeam5.Enabled = false;
                btnTeam5.BackColor = Color.Black;
            }
            if (teamNames[5] == "New Team")
            {
                btnTeam6.Text = "";
                btnTeam6.Enabled = false;
                btnTeam6.BackColor = Color.Black;
            }
            if (teamNames[6] == "New Team")
            {
                btnTeam7.Text = "";
                btnTeam7.Enabled = false;
                btnTeam7.BackColor = Color.Black;
            }
            if (teamNames[7] == "New Team")
            {
                btnTeam8.Text = "";
                btnTeam8.Enabled = false;
                btnTeam8.BackColor = Color.Black;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnTeam1.Enabled == false || btnTeam2.Enabled == false || btnTeam3.Enabled == false || btnTeam4.Enabled == false
                 || btnTeam5.Enabled == false || btnTeam6.Enabled == false || btnTeam7.Enabled == false || btnTeam8.Enabled == false)
            {
                startGame = true;
                btnStart.Enabled = false;
                btnStart.BackColor = Color.Ivory;
                btnStart.Text = "Game in play!";
                //TEAM BUTTONS
                btnTeam1.Enabled = true;
                btnTeam1.BackColor = Color.MidnightBlue;
                btnTeam2.Enabled = true;
                btnTeam2.BackColor = Color.MidnightBlue;
                btnTeam3.Enabled = true;
                btnTeam3.BackColor = Color.MidnightBlue;
                btnTeam4.Enabled = true;
                btnTeam4.BackColor = Color.MidnightBlue;
                btnTeam5.Enabled = true;
                btnTeam5.BackColor = Color.MidnightBlue;
                btnTeam6.Enabled = true;
                btnTeam6.BackColor = Color.MidnightBlue;
                btnTeam7.Enabled = true;
                btnTeam7.BackColor = Color.MidnightBlue;
                btnTeam8.Enabled = true;
                btnTeam8.BackColor = Color.MidnightBlue;
                

                //SAVE TEAM NAMES
                teamNames[0] = btnTeam1.Text;
                teamNames[1] = btnTeam2.Text;
                teamNames[2] = btnTeam3.Text;
                teamNames[3] = btnTeam4.Text;
                teamNames[4] = btnTeam5.Text;
                teamNames[5] = btnTeam6.Text;
                teamNames[6] = btnTeam7.Text;
                teamNames[7] = btnTeam8.Text;
                //DISABLE NON-TEAM CHARS
                resetTeamSelection();

                //ENABLE BOARD BUTTONS
               
                //A
                btnA200.Enabled = true;
                btnA400.Enabled = true;
                btnA600.Enabled = true;
                btnA800.Enabled = true;
                btnA1000.Enabled = true;
                //B
                btnB200.Enabled = true;
                btnB400.Enabled = true;
                btnB600.Enabled = true;
                btnB800.Enabled = true;
                btnB1000.Enabled = true;
                //C
                btnC200.Enabled = true;
                btnC400.Enabled = true;
                btnC600.Enabled = true;
                btnC800.Enabled = true;
                btnC1000.Enabled = true;
                //D
                btnD200.Enabled = true;
                btnD400.Enabled = true;
                btnD600.Enabled = true;
                btnD800.Enabled = true;
                btnD1000.Enabled = true;
                //E
                btnE200.Enabled = true;
                btnE400.Enabled = true;
                btnE600.Enabled = true;
                btnE800.Enabled = true;
                btnE1000.Enabled = true;
                //F
                btnF200.Enabled = true;
                btnF400.Enabled = true;
                btnF600.Enabled = true;
                btnF800.Enabled = true;
                btnF1000.Enabled = true;
            }
            else MessageBox.Show("Please create a team");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            Application.Exit();
        }
        private void btnExit2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restart? You will lose Team Names and Scores", "Restart Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                sitos2Jeopardy frm = new sitos2Jeopardy();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }
        }



        /* ------------------------------------------------------- *
        * --------------------Add TEAM BUTTONS-------------------- *
        * -------------------------------------------------------- */

        private void btnTeam1_Click(object sender, EventArgs e)
        {
            using (teamNameTxt frm = new teamNameTxt())
            {
                if (startGame == false)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        lblTeam1.Visible = true;
                        lblScore1.Visible = true;
                        lblTeam1.Text = "Team " + frm.TxtValue + " Score:";
                        buttonClick(btnTeam1, 0);
                        btnTeam1.Text = frm.TxtValue;
                        amtTeams++;
                    }
                }
                else
                {
                    resetTeamSelection();
                    btnTeam1.BackColor = Color.YellowGreen;
                    teamTurn = 1;
                }
                
            }
        }

        private void btnTeam2_Click(object sender, EventArgs e)
        {
            using (teamNameTxt frm = new teamNameTxt())
            {
                if (startGame == false)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        lblTeam2.Visible = true;
                        lblScore2.Visible = true;
                        lblTeam2.Text = "Team " + frm.TxtValue + " Score:";
                        buttonClick(btnTeam2, 0);
                        btnTeam2.Text = frm.TxtValue;
                        amtTeams++;
                    }
                }
                else
                {   resetTeamSelection();
                    btnTeam2.BackColor = Color.YellowGreen;
                    teamTurn = 2;
                    
                }
            }
        }

        private void btnTeam3_Click(object sender, EventArgs e)
        {
            using (teamNameTxt frm = new teamNameTxt())
            {
                if (startGame == false)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        lblTeam3.Visible = true;
                        lblScore3.Visible = true;
                        lblTeam3.Text = "Team " + frm.TxtValue + " Score:";
                        buttonClick(btnTeam3, 0);
                        btnTeam3.Text = frm.TxtValue;
                        amtTeams++;
                    }
                }
                else
                {
                    resetTeamSelection();
                    btnTeam3.BackColor = Color.YellowGreen;
                    teamTurn = 3;
                }
            }
        }

        private void btnTeam4_Click(object sender, EventArgs e)
        {
            using (teamNameTxt frm = new teamNameTxt())
            {
                if (startGame == false)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        lblTeam4.Visible = true;
                        lblScore4.Visible = true;
                        lblTeam4.Text = "Team " + frm.TxtValue + " Score:";
                        buttonClick(btnTeam4, 0);
                        btnTeam4.Text = frm.TxtValue;
                        amtTeams++;
                    }
                }
                else
                {
                    resetTeamSelection();
                    btnTeam4.BackColor = Color.YellowGreen;
                    teamTurn = 4;
                }
            }
        }

        private void btnTeam5_Click(object sender, EventArgs e)
        {
            using (teamNameTxt frm = new teamNameTxt())
            {
                if (startGame == false)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        lblTeam5.Visible = true;
                        lblScore5.Visible = true;
                        lblTeam5.Text = "Team " + frm.TxtValue + " Score:";
                        buttonClick(btnTeam5, 0);
                        btnTeam5.Text = frm.TxtValue;
                        amtTeams++;
                    }
                }
                else
                {
                    resetTeamSelection();
                    btnTeam5.BackColor = Color.YellowGreen;
                    teamTurn = 5;
                }
            }
        }

        private void btnTeam6_Click(object sender, EventArgs e)
        {
            using (teamNameTxt frm = new teamNameTxt())
            {
                if (startGame == false)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        lblTeam6.Visible = true;
                        lblScore6.Visible = true;
                        lblTeam6.Text = "Team " + frm.TxtValue + " Score:";
                        buttonClick(btnTeam6, 0);
                        btnTeam6.Text = frm.TxtValue;
                        amtTeams++;
                    }
                }
                else
                {
                    resetTeamSelection();
                    btnTeam6.BackColor = Color.YellowGreen;
                    teamTurn = 6;
                }
            }
        }

        private void btnTeam7_Click(object sender, EventArgs e)
        {
            using (teamNameTxt frm = new teamNameTxt())
            {
                if (startGame == false)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        lblTeam7.Visible = true;
                        lblScore7.Visible = true;
                        lblTeam7.Text = "Team " + frm.TxtValue + " Score:";
                        buttonClick(btnTeam7, 0);
                        btnTeam7.Text = frm.TxtValue;
                        amtTeams++;
                    }
                }
                else
                {
                    resetTeamSelection();
                    btnTeam7.BackColor = Color.YellowGreen;
                    teamTurn = 7;
                }
            }
        }

        private void btnTeam8_Click(object sender, EventArgs e)
        {
            using (teamNameTxt frm = new teamNameTxt())
            {
                if (startGame == false)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        lblTeam8.Visible = true;
                        lblScore8.Visible = true;
                        lblTeam8.Text = "Team " + frm.TxtValue + " Score:";
                        buttonClick(btnTeam8, 0);
                        btnTeam8.Text = frm.TxtValue;
                        amtTeams++;
                    }
                }
                else
                {
                    resetTeamSelection();
                    btnTeam8.BackColor = Color.YellowGreen;
                    teamTurn = 8;
                }
            }
        }

       

      
      

    }
}
