using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinefieldV2
{
    public partial class FinalScore : Form
    {
        int totallevelsWon;
        string levelDifficulty;
        int totallevelPointsScore;
        string playername;

        Minefield minefield = new Minefield();

        public FinalScore()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            playername = txtboxName.Text;

            totallevelsWon = Properties.Settings.Default.tempLevelsWon;
            levelDifficulty = Properties.Settings.Default.tempLevelDifficulty;
            totallevelPointsScore = Properties.Settings.Default.tempFinalScore;

            minefield.Hide();

            if (totallevelPointsScore >= Properties.Settings.Default.lastplaceScore && totallevelPointsScore < Properties.Settings.Default.ninthplaceScore)
            {
                Properties.Settings.Default.lastplaceName = playername;
                Properties.Settings.Default.lastplaceScore = totallevelPointsScore;
                Properties.Settings.Default.lastplaceDifficulty = levelDifficulty;
                Properties.Settings.Default.lastplaceLevels = totallevelsWon;

                Properties.Settings.Default.Save();
                showScoreboard();
            }
            else if (totallevelPointsScore >= Properties.Settings.Default.ninthplaceScore && totallevelPointsScore < Properties.Settings.Default.eithplaceScore)
            {
                Properties.Settings.Default.ninthplaceName = playername;
                Properties.Settings.Default.ninthplaceScore = totallevelPointsScore;
                Properties.Settings.Default.ninthplaceDifficulty = levelDifficulty;
                Properties.Settings.Default.ninthplaceLevels = totallevelsWon;

                Properties.Settings.Default.Save();
                showScoreboard();
            }
            else if (totallevelPointsScore >= Properties.Settings.Default.eithplaceScore && totallevelPointsScore < Properties.Settings.Default.seventhplaceScore)
            {
                Properties.Settings.Default.eigthplaceName = playername;
                Properties.Settings.Default.eithplaceScore = totallevelPointsScore;
                Properties.Settings.Default.eithplaceDifficulty = levelDifficulty;
                Properties.Settings.Default.eigthplaceLevels = totallevelsWon;

                Properties.Settings.Default.Save();
                showScoreboard();
            }
            else if (totallevelPointsScore >= Properties.Settings.Default.seventhplaceScore && totallevelPointsScore < Properties.Settings.Default.sixthplaceScore)
            {
                Properties.Settings.Default.seventhplaceName = playername;
                Properties.Settings.Default.seventhplaceScore = totallevelPointsScore;
                Properties.Settings.Default.seventhplaceDifficulty = levelDifficulty;
                Properties.Settings.Default.seventhplaceLevels = totallevelsWon;

                Properties.Settings.Default.Save();
                showScoreboard();
            }
            else if (totallevelPointsScore >= Properties.Settings.Default.sixthplaceScore && totallevelPointsScore < Properties.Settings.Default.fithplaceScore)
            {
                Properties.Settings.Default.sixthplaceName = playername;
                Properties.Settings.Default.sixthplaceScore = totallevelPointsScore;
                Properties.Settings.Default.sixthplaceDifficulty = levelDifficulty;
                Properties.Settings.Default.sixthplaceLevels = totallevelsWon;

                Properties.Settings.Default.Save();
                showScoreboard();
            }
            else if (totallevelPointsScore >= Properties.Settings.Default.fithplaceScore && totallevelPointsScore < Properties.Settings.Default.fourthplaceScore)
            {
                Properties.Settings.Default.fithplaceName = playername;
                Properties.Settings.Default.fithplaceScore = totallevelPointsScore;
                Properties.Settings.Default.fithplaceDifficulty = levelDifficulty;
                Properties.Settings.Default.fithplaceLevels = totallevelsWon;

                Properties.Settings.Default.Save();
                showScoreboard();
            }
            else if (totallevelPointsScore >= Properties.Settings.Default.fourthplaceScore && totallevelPointsScore < Properties.Settings.Default.thirdplaceScore)
            {
                Properties.Settings.Default.fourthplaceName = playername;
                Properties.Settings.Default.fourthplaceScore = totallevelPointsScore;
                Properties.Settings.Default.fourthplaceDifficulty = levelDifficulty;
                Properties.Settings.Default.fourthplaceLevels = totallevelsWon;

                Properties.Settings.Default.Save();
                showScoreboard();
            }
            else if (totallevelPointsScore >= Properties.Settings.Default.thirdplaceScore && totallevelPointsScore < Properties.Settings.Default.secondplaceScore)
            {
                Properties.Settings.Default.thirdplaceName = playername;
                Properties.Settings.Default.thirdplaceScore = totallevelPointsScore;
                Properties.Settings.Default.thirdplaceDifficulty = levelDifficulty;
                Properties.Settings.Default.thirdplaceLevels = totallevelsWon;

                Properties.Settings.Default.Save();
                showScoreboard();
            }
            else if (totallevelPointsScore >= Properties.Settings.Default.secondplaceScore && totallevelPointsScore < Properties.Settings.Default.firstplaceScore)
            {
                Properties.Settings.Default.secondplaceName = playername;
                Properties.Settings.Default.secondplaceScore = totallevelPointsScore;
                Properties.Settings.Default.secondplaceDifficulty = levelDifficulty;
                Properties.Settings.Default.secondplaceLevels = totallevelsWon;

                Properties.Settings.Default.Save();
                showScoreboard();
            }
            else
            {
                Properties.Settings.Default.firstplaceName = playername;
                Properties.Settings.Default.firstplaceScore = totallevelPointsScore;
                Properties.Settings.Default.firstplaceDifficulty = levelDifficulty;
                Properties.Settings.Default.firstplaceLevels = totallevelsWon;

                Properties.Settings.Default.Save();
                showScoreboard();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showScoreboard()
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.btnGoBack.Visible = false;
            scoreboard.btnStartAgain.Visible = true;
            this.Hide();
            minefield.Hide();
            scoreboard.Show();
        }
    }
}
