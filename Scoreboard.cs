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
    public partial class Scoreboard : Form
    {
        Minefield minefield = new Minefield();

        public Scoreboard()
        {
            InitializeComponent();
            getScores();
        }

        private void getScores()
        {
            //First place
            lblfirstname.Text = Properties.Settings.Default.firstplaceName;
            lblfirstlevels.Text = "" + Properties.Settings.Default.firstplaceLevels + "";
            lblfirstscore.Text = "" + Properties.Settings.Default.firstplaceScore + "";
            lblfirstdifficulty.Text = Properties.Settings.Default.firstplaceDifficulty;

            //Second place
            lblsecondname.Text = Properties.Settings.Default.secondplaceName;
            lblsecondlevels.Text = "" + Properties.Settings.Default.secondplaceLevels + "";
            lblsecondscore.Text = "" + Properties.Settings.Default.secondplaceScore + "";
            lblseconddifficulty.Text = Properties.Settings.Default.secondplaceDifficulty;

            //Third place
            lblthirdname.Text = Properties.Settings.Default.thirdplaceName;
            lblthirdlevels.Text = "" + Properties.Settings.Default.thirdplaceLevels + "";
            lblthirdscore.Text = "" + Properties.Settings.Default.thirdplaceScore + "";
            lblthirddifficulty.Text = Properties.Settings.Default.thirdplaceDifficulty;

            //Fourth place
            lblfourthname.Text = Properties.Settings.Default.fourthplaceName;
            lblfourthlevels.Text = "" + Properties.Settings.Default.fourthplaceLevels + "";
            lblfourthscore.Text = "" + Properties.Settings.Default.fourthplaceScore + "";
            lblfourthdifficulty.Text = Properties.Settings.Default.fourthplaceDifficulty;

            //Fith place
            lblfithname.Text = Properties.Settings.Default.fithplaceName;
            lblfithlevels.Text = "" + Properties.Settings.Default.fithplaceLevels + "";
            lblfithscore.Text = "" + Properties.Settings.Default.fithplaceScore + "";
            lblfithdifficulty.Text = Properties.Settings.Default.fithplaceDifficulty;

            //Sixth place
            lblsixthname.Text = Properties.Settings.Default.sixthplaceName;
            lblsixthlevels.Text = "" + Properties.Settings.Default.sixthplaceLevels + "";
            lblsixthscore.Text = "" + Properties.Settings.Default.sixthplaceScore + "";
            lblsixthdifficulty.Text = Properties.Settings.Default.sixthplaceDifficulty;

            //Seventh place
            lblseventhname.Text = Properties.Settings.Default.seventhplaceName;
            lblseventhlevels.Text = "" + Properties.Settings.Default.seventhplaceLevels + "";
            lblseventhscore.Text = "" + Properties.Settings.Default.seventhplaceScore + "";
            lblseventhdifficulty.Text = Properties.Settings.Default.seventhplaceDifficulty;

            //Eigth place
            lbleighthname.Text = Properties.Settings.Default.eigthplaceName;
            lbleigthlevels.Text = "" + Properties.Settings.Default.eigthplaceLevels + "";
            lbleigthscore.Text = "" + Properties.Settings.Default.eithplaceScore + "";
            lbleigthdifficulty.Text = Properties.Settings.Default.eithplaceDifficulty;

            //Ninth place
            lblninthname.Text = Properties.Settings.Default.ninthplaceName;
            lblninthlevels.Text = "" + Properties.Settings.Default.ninthplaceLevels + "";
            lblninthscore.Text = "" + Properties.Settings.Default.ninthplaceScore + "";
            lblninthdifficulty.Text = Properties.Settings.Default.ninthplaceDifficulty;

            //Last place
            lblLastname.Text = Properties.Settings.Default.lastplaceName;
            lbllastlevels.Text = "" + Properties.Settings.Default.lastplaceLevels + "";
            lbllastscore.Text = "" + Properties.Settings.Default.lastplaceScore + "";
            lbllastdifficulty.Text = Properties.Settings.Default.lastplaceDifficulty;
        }

        private void btnStartAgain_Click(object sender, EventArgs e)
        {
            btnStartAgain.Visible = false;
            btnGoBack.Visible = true;
            //minefield.restart();
            //this.Close();
            Application.Restart();
            //minefield.Close();
            //minefield.Show();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //minefield.Show();
        }
    }
}
