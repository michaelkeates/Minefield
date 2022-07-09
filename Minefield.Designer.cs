
namespace MinefieldV2
{
    partial class Minefield
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minefield));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.appearenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGridColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTileColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAppearenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showMinesLimitedRemainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMinesUnlimitedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesVisitedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsWonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spritePositionX0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spritePositionY0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemyBotTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblMineProx = new System.Windows.Forms.Label();
            this.lblMines = new System.Windows.Forms.Label();
            this.tableLayoutProgressBar = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hidetrailTick = new System.Windows.Forms.Timer(this.components);
            this.enemyBotTick = new System.Windows.Forms.Timer(this.components);
            this.hideTrailsIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutLabels.SuspendLayout();
            this.tableLayoutProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(17, 38);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(364, 333);
            this.mainPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.appearenceToolStripMenuItem,
            this.difficultyToolStripMenuItem,
            this.scoreboardToolStripMenuItem,
            this.resetSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // appearenceToolStripMenuItem
            // 
            this.appearenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeGridColourToolStripMenuItem,
            this.changeTileColourToolStripMenuItem,
            this.resetAppearenceToolStripMenuItem});
            this.appearenceToolStripMenuItem.Name = "appearenceToolStripMenuItem";
            this.appearenceToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.appearenceToolStripMenuItem.Text = "Appearence";
            // 
            // changeGridColourToolStripMenuItem
            // 
            this.changeGridColourToolStripMenuItem.Name = "changeGridColourToolStripMenuItem";
            this.changeGridColourToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.changeGridColourToolStripMenuItem.Text = "Change Grid Colour";
            this.changeGridColourToolStripMenuItem.Click += new System.EventHandler(this.changeGridColourToolStripMenuItem_Click);
            // 
            // changeTileColourToolStripMenuItem
            // 
            this.changeTileColourToolStripMenuItem.Name = "changeTileColourToolStripMenuItem";
            this.changeTileColourToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.changeTileColourToolStripMenuItem.Text = "Change Tile Colour";
            this.changeTileColourToolStripMenuItem.Click += new System.EventHandler(this.changeTileColourToolStripMenuItem_Click);
            // 
            // resetAppearenceToolStripMenuItem
            // 
            this.resetAppearenceToolStripMenuItem.Name = "resetAppearenceToolStripMenuItem";
            this.resetAppearenceToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.resetAppearenceToolStripMenuItem.Text = "Reset Appearence";
            this.resetAppearenceToolStripMenuItem.Click += new System.EventHandler(this.resetAppearenceToolStripMenuItem_Click);
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.defaultToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // scoreboardToolStripMenuItem
            // 
            this.scoreboardToolStripMenuItem.Name = "scoreboardToolStripMenuItem";
            this.scoreboardToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.scoreboardToolStripMenuItem.Text = "Scoreboard";
            this.scoreboardToolStripMenuItem.Click += new System.EventHandler(this.scoreboardToolStripMenuItem_Click);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.resetSettingsToolStripMenuItem.Text = "Reset Settings";
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator3,
            this.instructionsToolStripMenuItem,
            this.toolStripSeparator4,
            this.showMinesLimitedRemainingToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(246, 6);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(246, 6);
            // 
            // showMinesLimitedRemainingToolStripMenuItem
            // 
            this.showMinesLimitedRemainingToolStripMenuItem.Name = "showMinesLimitedRemainingToolStripMenuItem";
            this.showMinesLimitedRemainingToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.showMinesLimitedRemainingToolStripMenuItem.Text = "Show Mines (5 Clicks Remaining)";
            this.showMinesLimitedRemainingToolStripMenuItem.Click += new System.EventHandler(this.showMinesLimitedRemainingToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMinesUnlimitedToolStripMenuItem,
            this.tilesVisitedToolStripMenuItem,
            this.levelsWonToolStripMenuItem,
            this.levelPointsToolStripMenuItem,
            this.totalPointsToolStripMenuItem,
            this.levelSelectedToolStripMenuItem,
            this.spritePositionX0ToolStripMenuItem,
            this.spritePositionY0ToolStripMenuItem,
            this.pauseTimerToolStripMenuItem,
            this.enemyBotTimerToolStripMenuItem,
            this.hideTrailsIntervalToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // showMinesUnlimitedToolStripMenuItem
            // 
            this.showMinesUnlimitedToolStripMenuItem.Name = "showMinesUnlimitedToolStripMenuItem";
            this.showMinesUnlimitedToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.showMinesUnlimitedToolStripMenuItem.Text = "Show Mines (Unlimited)";
            this.showMinesUnlimitedToolStripMenuItem.Click += new System.EventHandler(this.showMinesUnlimitedToolStripMenuItem_Click);
            // 
            // tilesVisitedToolStripMenuItem
            // 
            this.tilesVisitedToolStripMenuItem.Name = "tilesVisitedToolStripMenuItem";
            this.tilesVisitedToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.tilesVisitedToolStripMenuItem.Text = "Tiles Visited";
            // 
            // levelsWonToolStripMenuItem
            // 
            this.levelsWonToolStripMenuItem.Name = "levelsWonToolStripMenuItem";
            this.levelsWonToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.levelsWonToolStripMenuItem.Text = "Levels Won: 0";
            // 
            // levelPointsToolStripMenuItem
            // 
            this.levelPointsToolStripMenuItem.Name = "levelPointsToolStripMenuItem";
            this.levelPointsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.levelPointsToolStripMenuItem.Text = "Level Points: 0";
            // 
            // totalPointsToolStripMenuItem
            // 
            this.totalPointsToolStripMenuItem.Name = "totalPointsToolStripMenuItem";
            this.totalPointsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.totalPointsToolStripMenuItem.Text = "Total Points: 0";
            // 
            // levelSelectedToolStripMenuItem
            // 
            this.levelSelectedToolStripMenuItem.Name = "levelSelectedToolStripMenuItem";
            this.levelSelectedToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.levelSelectedToolStripMenuItem.Text = "Level Selected: Default";
            // 
            // spritePositionX0ToolStripMenuItem
            // 
            this.spritePositionX0ToolStripMenuItem.Name = "spritePositionX0ToolStripMenuItem";
            this.spritePositionX0ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.spritePositionX0ToolStripMenuItem.Text = "Sprite Position X: 0";
            // 
            // spritePositionY0ToolStripMenuItem
            // 
            this.spritePositionY0ToolStripMenuItem.Name = "spritePositionY0ToolStripMenuItem";
            this.spritePositionY0ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.spritePositionY0ToolStripMenuItem.Text = "Sprite Position Y: 0";
            // 
            // pauseTimerToolStripMenuItem
            // 
            this.pauseTimerToolStripMenuItem.Name = "pauseTimerToolStripMenuItem";
            this.pauseTimerToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.pauseTimerToolStripMenuItem.Text = "Pause Timer";
            this.pauseTimerToolStripMenuItem.Click += new System.EventHandler(this.pauseTimerToolStripMenuItem_Click);
            // 
            // enemyBotTimerToolStripMenuItem
            // 
            this.enemyBotTimerToolStripMenuItem.Name = "enemyBotTimerToolStripMenuItem";
            this.enemyBotTimerToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.enemyBotTimerToolStripMenuItem.Text = "Enemy Bot Timer";
            // 
            // tableLayoutLabels
            // 
            this.tableLayoutLabels.AutoSize = true;
            this.tableLayoutLabels.ColumnCount = 4;
            this.tableLayoutLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutLabels.Controls.Add(this.lblMoves, 3, 0);
            this.tableLayoutLabels.Controls.Add(this.lblTimer, 2, 0);
            this.tableLayoutLabels.Controls.Add(this.lblMineProx, 1, 0);
            this.tableLayoutLabels.Controls.Add(this.lblMines, 0, 0);
            this.tableLayoutLabels.Location = new System.Drawing.Point(17, 432);
            this.tableLayoutLabels.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutLabels.Name = "tableLayoutLabels";
            this.tableLayoutLabels.RowCount = 1;
            this.tableLayoutLabels.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutLabels.Size = new System.Drawing.Size(364, 23);
            this.tableLayoutLabels.TabIndex = 2;
            // 
            // lblMoves
            // 
            this.lblMoves.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.Location = new System.Drawing.Point(293, 5);
            this.lblMoves.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(51, 13);
            this.lblMoves.TabIndex = 7;
            this.lblMoves.Text = "Moves: 0";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(205, 5);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(45, 13);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "Timer: 0";
            // 
            // lblMineProx
            // 
            this.lblMineProx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMineProx.AutoSize = true;
            this.lblMineProx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMineProx.Location = new System.Drawing.Point(103, 5);
            this.lblMineProx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMineProx.Name = "lblMineProx";
            this.lblMineProx.Size = new System.Drawing.Size(66, 13);
            this.lblMineProx.TabIndex = 5;
            this.lblMineProx.Text = "Mine Prox: 0";
            // 
            // lblMines
            // 
            this.lblMines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMines.AutoSize = true;
            this.lblMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMines.Location = new System.Drawing.Point(22, 5);
            this.lblMines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMines.Name = "lblMines";
            this.lblMines.Size = new System.Drawing.Size(47, 13);
            this.lblMines.TabIndex = 4;
            this.lblMines.Text = "Mines: 0";
            this.lblMines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutProgressBar
            // 
            this.tableLayoutProgressBar.ColumnCount = 1;
            this.tableLayoutProgressBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutProgressBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutProgressBar.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutProgressBar.Location = new System.Drawing.Point(17, 387);
            this.tableLayoutProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutProgressBar.Name = "tableLayoutProgressBar";
            this.tableLayoutProgressBar.RowCount = 1;
            this.tableLayoutProgressBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutProgressBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutProgressBar.Size = new System.Drawing.Size(364, 32);
            this.tableLayoutProgressBar.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.progressBar1.Location = new System.Drawing.Point(2, 2);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(360, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "bomb.png");
            this.imageList.Images.SetKeyName(1, "tank_forward.png");
            this.imageList.Images.SetKeyName(2, "tank_backwards.png");
            this.imageList.Images.SetKeyName(3, "tank_left.png");
            this.imageList.Images.SetKeyName(4, "tank_right.png");
            this.imageList.Images.SetKeyName(5, "akey.png");
            this.imageList.Images.SetKeyName(6, "dkey.png");
            this.imageList.Images.SetKeyName(7, "skey.png");
            this.imageList.Images.SetKeyName(8, "wkey.png");
            this.imageList.Images.SetKeyName(9, "enemytank_forward.png");
            this.imageList.Images.SetKeyName(10, "enemytank_backwards.png");
            this.imageList.Images.SetKeyName(11, "enemytank_left.png");
            this.imageList.Images.SetKeyName(12, "enemytank_right.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hidetrailTick
            // 
            this.hidetrailTick.Interval = 400;
            this.hidetrailTick.Tick += new System.EventHandler(this.hidetrailTick_Tick);
            // 
            // enemyBotTick
            // 
            this.enemyBotTick.Interval = 500;
            this.enemyBotTick.Tick += new System.EventHandler(this.enemyBotTick_Tick);
            // 
            // hideTrailsIntervalToolStripMenuItem
            // 
            this.hideTrailsIntervalToolStripMenuItem.Name = "hideTrailsIntervalToolStripMenuItem";
            this.hideTrailsIntervalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.hideTrailsIntervalToolStripMenuItem.Text = "Hide Trails Interval: ";
            // 
            // Minefield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 461);
            this.Controls.Add(this.tableLayoutProgressBar);
            this.Controls.Add(this.tableLayoutLabels);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Minefield";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minefield";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Minefield_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutLabels.ResumeLayout(false);
            this.tableLayoutLabels.PerformLayout();
            this.tableLayoutProgressBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem appearenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGridColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTileColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAppearenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem showMinesLimitedRemainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMinesUnlimitedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilesVisitedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelsWonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spritePositionX0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spritePositionY0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseTimerToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLabels;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblMines;
        private System.Windows.Forms.Label lblMineProx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutProgressBar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer hidetrailTick;
        private System.Windows.Forms.ToolStripMenuItem enemyBotTimerToolStripMenuItem;
        private System.Windows.Forms.Timer enemyBotTick;
        private System.Windows.Forms.ToolStripMenuItem hideTrailsIntervalToolStripMenuItem;
    }
}

