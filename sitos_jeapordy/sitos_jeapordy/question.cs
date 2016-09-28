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
    public partial class question : Form
    {
        public question(int value, char column, string boxQuestion, int teamTurn, int amtTeams, string[] teamNames)
        {
            teamNamesAry = teamNames;
            currentTeamTurn = teamTurn;
            amt = value;
            totalTeams = amtTeams;
            InitializeComponent();
            this.btnCorrect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHalf.DialogResult = System.Windows.Forms.DialogResult.OK;
            if (counter == totalTeams)
                this.btnWrong.DialogResult = System.Windows.Forms.DialogResult.OK;
            if      (column == 'a')
                lblColumn.Text = "Column A Category Info";
            else if (column == 'b')
                lblColumn.Text = "Column B Category Info";
            else if (column == 'c')
                lblColumn.Text = "Column C Category Info";
            else if (column == 'd')
                lblColumn.Text = "Column D Category Info";
            else if (column == 'e')
                lblColumn.Text = "Column E Category Info";
            else if (column == 'f')
                lblColumn.Text = "Column F Category Info";

            lblQuestion.Text = boxQuestion;
            lblAmt.Text = "For $" + value;

            if      (teamTurn == 1)
            {
                btnTeam1.BackColor = Color.YellowGreen;
                btnTeam1.Enabled = false;
            }
            else if (teamTurn == 2)
            {
                btnTeam2.BackColor = Color.YellowGreen;
                btnTeam2.Enabled = false;
            }
            else if (teamTurn == 3)
            {
                btnTeam3.BackColor = Color.YellowGreen;
                btnTeam3.Enabled = false;
            }
            else if (teamTurn == 4)
            {
                btnTeam4.BackColor = Color.YellowGreen;
                btnTeam4.Enabled = false;
            }
            else if (teamTurn == 5)
            {
                btnTeam5.BackColor = Color.YellowGreen;
                btnTeam5.Enabled = false;
            }
            else if (teamTurn == 6)
            {
                btnTeam6.BackColor = Color.YellowGreen;
                btnTeam6.Enabled = false;
            }
            else if (teamTurn == 7)
            {
                btnTeam7.BackColor = Color.YellowGreen;
                btnTeam7.Enabled = false;
            }
            else if (teamTurn == 8)
            {
                btnTeam8.BackColor = Color.YellowGreen;
                btnTeam8.Enabled = false;
            }

            if (teamNamesAry[0] == "New Team")
            {
                btnTeam1.Text = "";
                btnTeam1.Enabled = false;
                btnTeam1.BackColor = Color.Black;
            }
            else btnTeam1.Text = teamNamesAry[0];
            if (teamNamesAry[1] == "New Team")
            {
                btnTeam2.Text = "";
                btnTeam2.Enabled = false;
                btnTeam2.BackColor = Color.Black;
            }
             else btnTeam2.Text = teamNamesAry[1];
             if (teamNamesAry[2] == "New Team")
            {
                btnTeam3.Text = "";
                btnTeam3.Enabled = false;
                btnTeam3.BackColor = Color.Black;
            }
             else btnTeam3.Text = teamNamesAry[2];
             if (teamNamesAry[3] == "New Team")
             {
                 btnTeam4.Text = "";
                 btnTeam4.Enabled = false;
                 btnTeam4.BackColor = Color.Black;
             }
             else btnTeam4.Text = teamNamesAry[3];
             if (teamNamesAry[4] == "New Team")
             {
                 btnTeam5.Text = "";
                 btnTeam5.Enabled = false;
                 btnTeam5.BackColor = Color.Black;
             }
             else btnTeam5.Text = teamNamesAry[4];
             if (teamNamesAry[5] == "New Team")
            {
                btnTeam6.Text = "";
                btnTeam6.Enabled = false;
                btnTeam6.BackColor = Color.Black;
            }
             else btnTeam6.Text = teamNamesAry[5];
             if (teamNamesAry[6] == "New Team")
            {
                btnTeam7.Text = "";
                btnTeam7.Enabled = false;
                btnTeam7.BackColor = Color.Black;
            }
             else btnTeam7.Text = teamNamesAry[6];
             if (teamNamesAry[7] == "New Team")
            {
                btnTeam8.Text = "";
                btnTeam8.Enabled = false;
                btnTeam8.BackColor = Color.Black;
            }
             else btnTeam8.Text = teamNamesAry[7];
        }
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
           if (teamNamesAry[0] == "New Team")
            {
                btnTeam1.Text = "";
                btnTeam1.Enabled = false;
                btnTeam1.BackColor = Color.Black;
            }
            else btnTeam1.Text = teamNamesAry[0];
            if (teamNamesAry[1] == "New Team")
            {
                btnTeam2.Text = "";
                btnTeam2.Enabled = false;
                btnTeam2.BackColor = Color.Black;
            }
             else btnTeam2.Text = teamNamesAry[1];
             if (teamNamesAry[2] == "New Team")
            {
                btnTeam3.Text = "";
                btnTeam3.Enabled = false;
                btnTeam3.BackColor = Color.Black;
            }
             else btnTeam3.Text = teamNamesAry[2];
             if (teamNamesAry[3] == "New Team")
             {
                 btnTeam4.Text = "";
                 btnTeam4.Enabled = false;
                 btnTeam4.BackColor = Color.Black;
             }
             else btnTeam4.Text = teamNamesAry[3];
             if (teamNamesAry[4] == "New Team")
             {
                 btnTeam5.Text = "";
                 btnTeam5.Enabled = false;
                 btnTeam5.BackColor = Color.Black;
             }
             else btnTeam5.Text = teamNamesAry[4];
             if (teamNamesAry[5] == "New Team")
            {
                btnTeam6.Text = "";
                btnTeam6.Enabled = false;
                btnTeam6.BackColor = Color.Black;
            }
             else btnTeam6.Text = teamNamesAry[5];
             if (teamNamesAry[6] == "New Team")
            {
                btnTeam7.Text = "";
                btnTeam7.Enabled = false;
                btnTeam7.BackColor = Color.Black;
            }
             else btnTeam7.Text = teamNamesAry[6];
             if (teamNamesAry[7] == "New Team")
            {
                btnTeam8.Text = "";
                btnTeam8.Enabled = false;
                btnTeam8.BackColor = Color.Black;
            }
             else btnTeam8.Text = teamNamesAry[7];
        }
        int currentTeamTurn;
        int team1Amt = 0;
        int team2Amt = 0;
        int team3Amt = 0;
        int team4Amt = 0;
        int team5Amt = 0;
        int team6Amt = 0;
        int team7Amt = 0;
        int team8Amt = 0;
        int totalTeams;
        int amt;
        int counter = 1;
        string[] teamNamesAry;
          public int[] UpdateScores
        {
            set
            {
                int[] Scores = new int[8];
                Scores[0] = team1Amt;
                Scores[1] = team2Amt;
                Scores[2] = team3Amt;
                Scores[3] = team4Amt;
                Scores[4] = team5Amt;
                Scores[5] = team6Amt;
                Scores[6] = team7Amt;
                Scores[7] = team8Amt;
            }

            get
            {
                int[] Scores = new int[9];
                Scores[0] = team1Amt;
                Scores[1] = team2Amt;
                Scores[2] = team3Amt;
                Scores[3] = team4Amt;
                Scores[4] = team5Amt;
                Scores[5] = team6Amt;
                Scores[6] = team7Amt;
                Scores[7] = team8Amt;
                Scores[8] = wasCorrect;
                return Scores;
            }
        }
          int wasCorrect = 0;
        public void disableButton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.Firebrick;
        }
        public void buttonClick(Button btn)
        {
            //resetTeamSelection();
            if (btnTeam1.BackColor == Color.YellowGreen)
                btnTeam1.Enabled = true;
            if (btnTeam2.BackColor == Color.YellowGreen)
                btnTeam2.Enabled = true;
            if (btnTeam3.BackColor == Color.YellowGreen)
                btnTeam3.Enabled = true;
            if (btnTeam4.BackColor == Color.YellowGreen)
                btnTeam4.Enabled = true;
            if (btnTeam5.BackColor == Color.YellowGreen)
                btnTeam5.Enabled = true;
            if (btnTeam6.BackColor == Color.YellowGreen)
                btnTeam6.Enabled = true;
            if (btnTeam7.BackColor == Color.YellowGreen)
                btnTeam7.Enabled = true;
            if (btnTeam8.BackColor == Color.YellowGreen)
                btnTeam8.Enabled = true;
            if (btnTeam1.Enabled == true || btnTeam1.BackColor == Color.YellowGreen)
            btnTeam1.BackColor = Color.MidnightBlue;            
            if (btnTeam2.Enabled == true || btnTeam2.BackColor == Color.YellowGreen)
            btnTeam2.BackColor = Color.MidnightBlue;
            if (btnTeam3.Enabled == true || btnTeam3.BackColor == Color.YellowGreen)
            btnTeam3.BackColor = Color.MidnightBlue;
            if (btnTeam4.Enabled == true || btnTeam4.BackColor == Color.YellowGreen)
            btnTeam4.BackColor = Color.MidnightBlue;
            if (btnTeam5.Enabled == true || btnTeam5.BackColor == Color.YellowGreen)
            btnTeam5.BackColor = Color.MidnightBlue;
            if (btnTeam6.Enabled == true || btnTeam6.BackColor == Color.YellowGreen)
            btnTeam6.BackColor = Color.MidnightBlue;
            if (btnTeam7.Enabled == true || btnTeam7.BackColor == Color.YellowGreen)
            btnTeam7.BackColor = Color.MidnightBlue;
            if (btnTeam8.Enabled == true || btnTeam8.BackColor == Color.YellowGreen)
            btnTeam8.BackColor = Color.MidnightBlue;
            btn.BackColor = Color.YellowGreen;
            
        }
        private void lblTeams_Click(object sender, EventArgs e)
        {

        }

        private void btnTeam8_Click(object sender, EventArgs e)
        {
            currentTeamTurn = 8;
            buttonClick(btnTeam8);
        }

        private void btnTeam7_Click(object sender, EventArgs e)
        {
            currentTeamTurn = 7;
            buttonClick(btnTeam7);
        }

        private void btnTeam6_Click(object sender, EventArgs e)
        {
            currentTeamTurn = 6;
            buttonClick(btnTeam6);
        }

        private void btnTeam5_Click(object sender, EventArgs e)
        {
            currentTeamTurn = 5;
            buttonClick(btnTeam5);
        }

        private void btnTeam4_Click(object sender, EventArgs e)
        {
            currentTeamTurn = 4;
            buttonClick(btnTeam4);
        }

        private void btnTeam3_Click(object sender, EventArgs e)
        {
            currentTeamTurn = 3;
            buttonClick(btnTeam3);
        }

        private void btnTeam2_Click(object sender, EventArgs e)
        {
            currentTeamTurn = 2;
            buttonClick(btnTeam2);
        }

        private void btnTeam1_Click(object sender, EventArgs e)
        {
            currentTeamTurn = 1;
            buttonClick(btnTeam1);
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {
            if      (currentTeamTurn == 1)
            {
                team1Amt -= amt;
                disableButton(btnTeam1);
                counter++;
            }
            else if (currentTeamTurn == 2)
            {
                team2Amt -= amt;
                disableButton(btnTeam2);
                counter++;
            }
            else if (currentTeamTurn == 3)
            {
                team3Amt -= amt;
                disableButton(btnTeam3);
                counter++;
            }
            else if (currentTeamTurn == 4)
            {
                team4Amt -= amt;
                disableButton(btnTeam4);
                counter++;
            }
            else if (currentTeamTurn == 5)
            {
                team5Amt -= amt;
                disableButton(btnTeam5);
                counter++;
            }
            else if (currentTeamTurn == 6)
            {
                team6Amt -= amt;
                disableButton(btnTeam6);
                counter++;
            }
            else if (currentTeamTurn == 7)
            {
                team7Amt -= amt;
                disableButton(btnTeam7);
                counter++;
            }
            else if (currentTeamTurn == 8)
            {
                team8Amt -= amt;
                disableButton(btnTeam8); 
                counter++;
            }
            if (counter == totalTeams)
                this.btnWrong.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            if (currentTeamTurn == 1)
                team1Amt += amt;
            else if (currentTeamTurn == 2)
                team2Amt += amt;
            else if (currentTeamTurn == 3)
                team3Amt += amt;
            else if (currentTeamTurn == 4)
                team4Amt += amt;
            else if (currentTeamTurn == 5)
                team5Amt += amt;
            else if (currentTeamTurn == 6)
                team6Amt += amt;
            else if (currentTeamTurn == 7)
                team7Amt += amt;
            else if (currentTeamTurn == 8)
                team8Amt += amt;
            wasCorrect = 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHalf_Click(object sender, EventArgs e)
        {
            if (currentTeamTurn == 1)
                team1Amt += amt / 2;
            else if (currentTeamTurn == 2)
                team2Amt += amt / 2;
            else if (currentTeamTurn == 3)
                team3Amt += amt / 2;
            else if (currentTeamTurn == 4)
                team4Amt += amt / 2;
            else if (currentTeamTurn == 5)
                team5Amt += amt / 2;
            else if (currentTeamTurn == 6)
                team6Amt += amt / 2;
            else if (currentTeamTurn == 7)
                team7Amt += amt / 2;
            else if (currentTeamTurn == 8)
                team8Amt += amt / 2;
        }

        
    }
}
