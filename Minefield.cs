using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //Play sounds

namespace MinefieldV2
{
    //RULES
    //1. Move the sprite up, down, left & right via keyboard
    //2. Hit bomb. Die!
    //3. Different levels/difficulty
    //4. How many moves made
    //5. Settings/Scoreboard
    //6. Win game if moveCount within percentage of tile count
    //7. Timer

    //Provide a target location [YES/NO] [INSTEAD VISIT TILES TILL % REACHES 20]
    //Add a reset/start button [YES]
    //Add sounds? [YES]
    //Improve the way bombs are shown [YES]
    //Add levels – more bombs = harder [YES]
    //Add a timer – for more pressure! [YES]
    //Add levels – less time = harder [YES]
    //Add a ‘peek’ function – but it can only be used once/occasionally [YES]
    //Add high scores [YES]
    //At hard level sometimes randomly wipe the trail ! [YES]
    //Add colours to also show proximal bomb count [YES]
    //Make sure bombs are not surrounding the start and end point [YES]
    //
    //After a while a “chaser-bot” comes on and moves around the trail hunting you down(ok that’s pretty advanced! – but still do-able in theory!) [YES]

    public partial class Minefield : Form
    {
        //Global variables
        //Grid Panel Settings. Easy, Normal & Hard
        int gridWidth;
        int gridHeight;
        int gridMines;
        int gridStartx;
        int gridStarty;

        int timer = 300;

        //Distance to move sprite and how many times the sprite has moved and location
        int movement = 32;
        int moveCount;
        int currentPositionx;
        int currentPositiony;

        //Declare buttons and pictureboxes
        Button[,] grid;
        Button[,] tiles;
        PictureBox spriteMain;
        PictureBox spriteMain2;
        PictureBox enemybotSprite;

        //Aray or boolean for mines
        bool[,] mines;
        bool showMinesEnabled;

        //How many times user clicks on Show Mines
        int showMinesclick;

        int minesProximinity;
        int hideTrail;
        int timerSubtract;
        int enemybotTimer;

        //int tilesY;

        //Switch table counts
        int debugcount;
        int showMinescount;

        //Scoring system
        int levelsWon;
        int levelPoints;
        int totallevelPoints;
        string levelSelected;

        public Minefield()
        {
            InitializeComponent();
            newGame();
        }

        public void newGame()
        {

            //Reset for new game. Grab saved settings
            int x = Properties.Settings.Default.GridWidth;
            int y = Properties.Settings.Default.GridHeight;
            int minecount = Properties.Settings.Default.GridMines;
            gridStartx = Properties.Settings.Default.GridStartX;
            gridStarty = Properties.Settings.Default.GridStartY;
            timer = Properties.Settings.Default.gameTimer;
            levelPoints = Properties.Settings.Default.levelPoints;

            levelSelected = Properties.Settings.Default.levelDifficulty;

            //Get start position for debug menu
            currentPositionx = gridStartx;
            currentPositiony = gridStarty;

            //levelsWonToolStripMenuItem.Text = "Levels Won: " + levelsWon + "";
            //spritePositionXToolStripMenuItem.Text = "Sprite Position X: " + currentPositionx + "";
            //spritePositionYToolStripMenuItem.Text = "Sprite Position Y: " + currentPositiony + "";

            //Reset values
            moveCount = 0;
            lblMoves.Text = "Moves: " + moveCount + "";
            showMinesclick = 5;
            showMinesEnabled = true;
            debugcount = 0;
            showMinescount = 0;
            progressBar1.Value = 0;
            minesProximinity = 0;
            levelPointsToolStripMenuItem.Text = "Level Points: " + levelPoints + "";
            totalPointsToolStripMenuItem.Text = "Total Points: " + totallevelPoints + "";
            levelSelectedToolStripMenuItem.Text = "Level Selected: " + levelSelected + "";
            enemyBotTimerToolStripMenuItem.Text = "Enemy Bot Timer: " + enemybotTimer + "";
            showMinesLimitedRemainingToolStripMenuItem.Text = "Show Mines (" + showMinesclick + " clicks remaining)";
            debugToolStripMenuItem.Visible = false;
            enemyBotTick.Enabled = false;
            hidetrailTick.Enabled = false;
            timerSubtract = 10;

            //Timer is disabled until sprite moves
            timer1.Enabled = false;

            //tilesY = 0;

            //declare grid, mines & tiles and pass x & y coords
            grid = new Button[x, y];
            mines = new bool[x, y];
            tiles = new Button[x, y];

            //Clear the mines and grid and the main panel
            Array.Clear(mines, 0, mines.Length);
            Array.Clear(grid, 0, grid.Length);
            mainPanel.Controls.Clear();

            //Randomly pick tiles to be a mine method is called here
            placeMines();

            //Reset, size and position elements depending on difficulty level selected
            //Width = (256 * x);
            Height = (128 + 258 * y);
            //this.Size = new Size(416, 500);
            mainPanel.Width = (33 * x);
            mainPanel.Height = (35 * y);

            tableLayoutProgressBar.Width = (31 * x + 12);
            tableLayoutProgressBar.Location = new Point(x + 12, 33 + 33 * y);
            progressBar1.Width = (31 * x + 12);
            tableLayoutLabels.Width = (33 * x);
            tableLayoutLabels.Location = new Point(x, 35 + 35 + 33 * y);

            lblMines.Text = "Mines: " + Properties.Settings.Default.GridMines + "";
            lblTimer.Text = "Timer: " + Properties.Settings.Default.gameTimer + "";
            lblMineProx.Text = "Mine Prox: " + minesProximinity + "";

            //If player reaches level 4, trails will randomly hide by changing to same color as tile
            //Each level is passed from 4, timer loses 10 to make level harder with less time
            if (levelsWon >= 4)
            {
                if (hidetrailTick.Interval == 10)
                {
                    hidetrailTick.Interval = 10;
                }
                else
                {
                    timer = timer - timerSubtract;
                    hidetrailTick.Interval = hidetrailTick.Interval - timerSubtract;
                    hideTrailsIntervalToolStripMenuItem.Text = "Hide Trails Interval: " + hidetrailTick.Interval + "";
                }
                lblTimer.Text = "Timer: " + timer + "";
                hidetrailTick.Enabled = true;
                totallevelPoints = totallevelPoints + 2;

                //If player reaches level 7, enemy bot is spawned
                //Each level is passed from 7, timer loses 10 to make level harder as enemyBot moves faster
                if (levelsWon >= 7)
                {
                    if (enemyBotTick.Interval == 10)
                    {
                        enemyBotTick.Interval = 10;
                    }
                    else
                    {
                        enemyBotTick.Interval = enemyBotTick.Interval - timerSubtract;
                        enemybotTimer = enemybotTimer - timerSubtract;
                    }
                    enemyBotTimerToolStripMenuItem.Text = "Enemy Bot Timer: " + enemybotTimer + "";
                    enemyBotTick.Enabled = true;
                    totallevelPoints = totallevelPoints + 4;
                }
            }

            //Create our sprite and place at starting position
            PictureBox sprite = new PictureBox();
            sprite.Image = imageList.Images[Properties.Settings.Default.tank_forward];
            spriteMain = sprite;
            sprite.Location = new Point(gridStartx, gridStarty);
            sprite.Height = 32;
            sprite.Width = 32;
            sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            mainPanel.Controls.Add(sprite);

            PictureBox sprite2 = new PictureBox();
            sprite2.Image = imageList.Images[Properties.Settings.Default.tank_forward];
            spriteMain2 = sprite2;
            sprite2.Location = new Point(gridStartx - 16, gridStarty - 16);
            sprite2.Height = 54;
            sprite2.Width = 54;
            sprite2.SizeMode = PictureBoxSizeMode.StretchImage;
            mainPanel.Controls.Add(sprite);

            PictureBox enemyBot = new PictureBox();
            enemyBot.Image = imageList.Images[Properties.Settings.Default.enemytank_backwards];
            enemybotSprite = enemyBot;
            enemyBot.Visible = false;
            enemyBot.Location = new Point(gridStartx, 4);
            enemyBot.Height = 32;
            enemyBot.Width = 32;
            enemyBot.SizeMode = PictureBoxSizeMode.StretchImage;
            mainPanel.Controls.Add(enemyBot);

            //Instead of following tutorial to create pictureboxes with labels, I did it this way
            //as it requires less code to achieve the same thing and gives tiles a "label" with just
            //one line of code: tile.Tag = "Tile"

            //Populate panel with tiles/mines. Cant create more when it reaches x and y limits
            //i & j are how many tiles/mines are created till limit is reached
            //each time i or j goes up by one digit, a new "Button" is created
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Button tile = new Button();
                    tile.Enabled = false;
                    tile.Visible = true;
                    tile.Location = new Point(4 + 32 * i, 4 + 32 * j);
                    tile.Height = 32;
                    tile.Width = 32;
                    tile.ForeColor = Properties.Settings.Default.GridColor;
                    tile.BackColor = Properties.Settings.Default.TileColor;
                    tile.FlatStyle = FlatStyle.Flat;
                    tile.TabStop = false;
                    tile.Show();
                    int a = i, b = j;
                    //a & b are tiles
                    grid[a, b] = tile;
                    //i & j are mines

                    //Add tiles to panel
                    tiles[a, b] = tile;
                    mainPanel.Controls.Add(tile);
                    sprite.BackColor = Color.White;
                    tile.Tag = "Tile";

                    //Hide mines
                    if (mines[i, j] == true)
                    {
                        grid[i, j].Visible = true;
                        Button mineImg = new Button();
                        mineImg.Visible = false;
                        mineImg.Enabled = false;
                        mineImg.Location = new Point(4 + 32 * i, 4 + 32 * j);
                        mineImg.Width = 32;
                        mineImg.Height = 32;
                        mineImg.Tag = "Bomb";
                        mineImg.Hide();
                        mainPanel.Controls.Add(mineImg);
                    }
                }
            }
        }

        public void placeMines()
        {
            //Fetch grid size settings
            int x = Properties.Settings.Default.GridWidth;
            int y = Properties.Settings.Default.GridHeight;
            int minecount = Properties.Settings.Default.GridMines;
            //Randomly pick tiles to be a mine on the grid

            int pos;

            //Tile numbers to be excluded from randomly picked becoming a mine so player doesn't die on start of level
            var excludedNumbers = new List<int> { 66, 67, 68, 261, 262, 263, 586, 587, 588 };

            Random rand = new Random();
            do
            {
                //Do a temprory loop to randomly via rand (Random();) to pick a tile to be a mine
                //till the minecount has been reached then the loop is done
                //bool tempDone = false;
                do
                {
                    pos = rand.Next(0, mines.Length - excludedNumbers.Count);
                    //int pos = rand.Next(58, 68);
                    //Mine cannot be placed at gridstart x & y where sprite spawns
                    //if (mines[pos % x, pos / x] == false)
                    if (!excludedNumbers.Contains(pos))
                    {
                        mines[pos % x, pos / x] = true;
                        //tempDone = true;
                    }
                    else
                    {
                        continue;
                    }
                    //} while (tempDone == false);
                } while (excludedNumbers.Contains(pos));
                minecount--;
            } while (minecount > 0);
            //End of placing mines randomly
        }

        private void showMines(int x, int y)
        {
            //Show all the mines on the grid
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mines[i, j] == true)
                    {
                        tiles[i, j].Visible = false;
                        PictureBox mineImg = new PictureBox();
                        mineImg.Image = imageList.Images[Properties.Settings.Default.Bomb];
                        mineImg.Location = new Point(4 + 32 * i, 4 + 32 * j);
                        mineImg.Width = 32;
                        mineImg.Height = 32;
                        mainPanel.Controls.Add(mineImg);
                    }
                    else if (i + j == gridMines)
                    {
                        //Do Nothing
                    }
                }
            }
        }

        private void hideMines(int x, int y)
        {
            //Hide all the mines on the grid
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mines[i, j] == true)
                    {
                        tiles[i, j].Visible = true;
                    }
                    else if (i + j == gridMines)
                    {
                        //Do Nothing
                    }
                }
            }
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare and save settings for Easy
            gridWidth = 9;
            gridHeight = 8;
            gridMines = 10;
            gridStartx = 132;
            gridStarty = 228;
            timer = 300;
            levelPoints = 2;
            levelSelected = "Easy";

            Properties.Settings.Default.GridWidth = gridWidth;
            Properties.Settings.Default.GridHeight = gridHeight;
            Properties.Settings.Default.GridMines = gridMines;
            Properties.Settings.Default.GridStartX = gridStartx;
            Properties.Settings.Default.GridStartY = gridStarty;
            Properties.Settings.Default.gameTimer = timer;
            Properties.Settings.Default.levelPoints = levelPoints;
            Properties.Settings.Default.levelDifficulty = levelSelected;

            Properties.Settings.Default.Save();
            newGame();
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare and save settings for Default
            gridWidth = 17;
            gridHeight = 16;
            gridMines = 40;
            gridStartx = 260;
            gridStarty = 484;
            timer = 500;
            levelPoints = 4;
            levelSelected = "Default";

            Properties.Settings.Default.GridWidth = gridWidth;
            Properties.Settings.Default.GridHeight = gridHeight;
            Properties.Settings.Default.GridMines = gridMines;
            Properties.Settings.Default.GridStartX = gridStartx;
            Properties.Settings.Default.GridStartY = gridStarty;
            Properties.Settings.Default.gameTimer = timer;
            Properties.Settings.Default.levelPoints = levelPoints;
            Properties.Settings.Default.levelDifficulty = levelSelected;

            Properties.Settings.Default.Save();
            newGame();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare and save settings for Hard
            gridWidth = 25;
            gridHeight = 24;
            gridMines = 100;
            gridStartx = 388;
            gridStarty = 740;
            timer = 700;
            levelPoints = 6;
            levelSelected = "Hard";

            Properties.Settings.Default.GridWidth = gridWidth;
            Properties.Settings.Default.GridHeight = gridHeight;
            Properties.Settings.Default.GridMines = gridMines;
            Properties.Settings.Default.GridStartX = gridStartx;
            Properties.Settings.Default.GridStartY = gridStarty;
            Properties.Settings.Default.gameTimer = timer;
            Properties.Settings.Default.levelPoints = levelPoints;
            Properties.Settings.Default.levelDifficulty = levelSelected;

            Properties.Settings.Default.Save();
            newGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void changeTileColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show color dialog and save user selection
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.TileColor = colorDialog1.Color;
                Properties.Settings.Default.Save();

                newGame();
            }
        }

        private void changeGridColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show color dialog and save user selection
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.GridColor = colorDialog1.Color;
                Properties.Settings.Default.Save();

                newGame();
            }
        }

        private void resetAppearenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reset colors to default
            //Properties.Settings.Default.Reset();
            Properties.Settings.Default.TileColor = Color.DarkGray;
            Properties.Settings.Default.GridColor = Color.Black;
            Properties.Settings.Default.Save();

            newGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showMinesLimitedRemainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Properties.Settings.Default.GridWidth;
            int y = Properties.Settings.Default.GridHeight;

            if (showMinesclick == 0)
            {
                debugToolStripMenuItem.Enabled = false;
            }
            else
            {
                //A switch table to toggle mine color by clicking on debug. debugcount will increase by one for each click till it resets to 0 to
                //start again
                {
                    Start:
                    showMinescount++;
                    switch (showMinescount)
                    {
                        case 1:
                            showMinesclick -= 1;
                            //Debug. Any button with the tag "Bomb" will become visible
                            foreach (Control m in mainPanel.Controls)
                            {
                                if ((string)m.Tag == "Bomb")
                                {
                                    showMines(x, y);
                                    showMinesLimitedRemainingToolStripMenuItem.Text = "Hide Mines (" + showMinesclick + " clicks remaining)";
                                    showMinesEnabled = true;
                                    break;
                                }
                            }
                            break;
                        case 2:
                            //Debug. Any button with the tag "Bomb" will become invisible
                            foreach (Control m in mainPanel.Controls)
                            {
                                if ((string)m.Tag == "Bomb")
                                {
                                    hideMines(x, y);
                                    showMinesLimitedRemainingToolStripMenuItem.Text = "Show Mines (" + showMinesclick + " clicks remaining)";
                                    showMinesEnabled = false;

                                }
                            }
                            break;
                        default:
                            showMinescount = 0;
                            goto Start;
                    }
                }
            }
        }

        public void ShowScore()
        {
            //If score is at least greater than last place score. New score process will be added. Else player loses and starts again
            if (totallevelPoints >= Properties.Settings.Default.lastplaceScore)
            {
                //this.Hide();
                FinalScore testDialog = new FinalScore();
                testDialog.Show();
                testDialog.lblMessage.Text = "Your final score is " + totallevelPoints + ". Input your name to be added to the scoreboard. Click Continue or click Cancel to quit.";
                Properties.Settings.Default.tempFinalScore = totallevelPoints;
                Properties.Settings.Default.tempLevelDifficulty = levelSelected;
                Properties.Settings.Default.tempLevelsWon = levelsWon;
                Properties.Settings.Default.Save();
                levelsWon = 0;
                totallevelPoints = 0;
                timerSubtract = 0;
                //newGame();


            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("You have lost the level! Click yes to continue or no to quit.", "Minefield", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    newGame();
                    levelsWon = 0;
                    totallevelPoints = 0;
                    timerSubtract = 0;
                    enemyBotTick.Enabled = false;
                    hidetrailTick.Enabled = false;
                    levelPointsToolStripMenuItem.Text = "Level Points: " + levelPoints + "";
                    levelsWonToolStripMenuItem.Text = "Levels Won: " + levelsWon + "";
                    totalPointsToolStripMenuItem.Text = "Total Points: " + totallevelPoints + "";
                    levelSelectedToolStripMenuItem.Text = "Level Selected: " + levelSelected + "";
                    enemyBotTimerToolStripMenuItem.Text = "Enemy Bot Timer: " + enemybotTimer + "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void Minefield_KeyDown(object sender, KeyEventArgs e)
        {
            {
                int x = Properties.Settings.Default.GridWidth;
                int y = Properties.Settings.Default.GridHeight;

                Howmanymoves();

                //Instead of arrow buttons on form. We can move the sprite using the w,a,s,d buttons on keyboard
                //Go up
                if (e.KeyCode == Keys.W)
                {
                    timer1.Enabled = true;
                    minesProximinity = 0;
                    lblMineProx.Text = "Mine Prox: " + minesProximinity + "";
                    lblMineProx.ForeColor = Color.Black;

                    //Sprite can move as long as within mainPanel dimensions
                    if (spriteMain.Top <= mainPanel.Top - 32)
                    {
                        spriteMain.Top -= 0;
                        spriteMain2.Top -= 0;
                    }
                    else
                    {
                        if (showMinesEnabled == true)
                        {
                            showMinesEnabled = false;
                            hideMines(x, y);
                            showMinescount = 0;
                            showMinesLimitedRemainingToolStripMenuItem.Text = "Show Mines (" + showMinesclick + " clicks remaining)";
                        }

                        spriteMain.Image = spriteMain.Image = imageList.Images[Properties.Settings.Default.tank_forward];
                        spriteMain.Top -= movement;
                        spriteMain2.Top -= movement;

                        currentPositiony += movement;
                        spritePositionY0ToolStripMenuItem.Text = "Sprite Position Y: " + currentPositiony + "";

                        Howmanymoves();
                    }
                }
                //Go down
                if (e.KeyCode == Keys.S)
                {
                    timer1.Enabled = true;
                    minesProximinity = 0;
                    lblMineProx.Text = "Mine Prox: " + minesProximinity + "";
                    lblMineProx.ForeColor = Color.Black;

                    //Quick fix to stop sprite exceeding bottom panel in different levels
                    if (levelSelected == "Easy")
                    {
                        if (spriteMain.Bottom >= mainPanel.Height - 32)
                        {
                            spriteMain.Top += 0;
                            spriteMain2.Top += 0;
                        }
                        else
                        {
                            if (showMinesEnabled == true)
                            {
                                showMinesEnabled = false;
                                hideMines(x, y);
                                showMinescount = 0;
                                showMinesLimitedRemainingToolStripMenuItem.Text = "Show Mines (" + showMinesclick + " clicks remaining)";
                            }

                            spriteMain.Image = spriteMain.Image = imageList.Images[Properties.Settings.Default.tank_backwards];
                            spriteMain.Top += movement;
                            spriteMain2.Top += movement;

                            currentPositiony -= movement;
                            spritePositionY0ToolStripMenuItem.Text = "Sprite Position Y: " + currentPositiony + "";

                            Howmanymoves();
                        }
                    }                    
                    if (levelSelected == "Default")
                    {
                        if (spriteMain.Bottom >= mainPanel.Height - 64)
                        {
                            spriteMain.Top += 0;
                            spriteMain2.Top += 0;
                        }
                        else
                        {
                            if (showMinesEnabled == true)
                            {
                                showMinesEnabled = false;
                                hideMines(x, y);
                                showMinescount = 0;
                                showMinesLimitedRemainingToolStripMenuItem.Text = "Show Mines (" + showMinesclick + " clicks remaining)";
                            }

                            spriteMain.Image = spriteMain.Image = imageList.Images[Properties.Settings.Default.tank_backwards];
                            spriteMain.Top += movement;
                            spriteMain2.Top += movement;

                            currentPositiony -= movement;
                            spritePositionY0ToolStripMenuItem.Text = "Sprite Position Y: " + currentPositiony + "";

                            Howmanymoves();
                        }
                    }
                    if (levelSelected == "Hard")
                    {
                        if (spriteMain.Bottom >= mainPanel.Height - 96)
                        {
                            spriteMain.Top += 0;
                            spriteMain2.Top += 0;
                        }
                        else
                        {
                            if (showMinesEnabled == true)
                            {
                                showMinesEnabled = false;
                                hideMines(x, y);
                                showMinescount = 0;
                                showMinesLimitedRemainingToolStripMenuItem.Text = "Show Mines (" + showMinesclick + " clicks remaining)";
                            }

                            spriteMain.Image = spriteMain.Image = imageList.Images[Properties.Settings.Default.tank_backwards];
                            spriteMain.Top += movement;
                            spriteMain2.Top += movement;

                            currentPositiony -= movement;
                            spritePositionY0ToolStripMenuItem.Text = "Sprite Position Y: " + currentPositiony + "";

                            Howmanymoves();
                        }
                    }
                }
                //Go left
                if (e.KeyCode == Keys.A)
                {
                    timer1.Enabled = true;
                    minesProximinity = 0;
                    lblMineProx.Text = "Mine Prox: " + minesProximinity + "";
                    lblMineProx.ForeColor = Color.Black;

                    if (spriteMain.Left <= mainPanel.Left)
                    {
                        spriteMain.Left -= 0;
                        spriteMain2.Left -= 0;
                    }
                    else
                    {
                        if (showMinesEnabled == true)
                        {
                            showMinesEnabled = false;
                            hideMines(x, y);
                            showMinescount = 0;
                            showMinesLimitedRemainingToolStripMenuItem.Text = "Show Mines (" + showMinesclick + " clicks remaining)";
                        }

                        spriteMain.Image = spriteMain.Image = imageList.Images[Properties.Settings.Default.tank_left];
                        spriteMain.Left -= movement;
                        spriteMain2.Left -= movement;

                        currentPositionx -= movement;
                        spritePositionX0ToolStripMenuItem.Text = "Sprite Position X: " + currentPositionx + "";

                        Howmanymoves();
                    }
                }
                //Go right
                if (e.KeyCode == Keys.D)
                {
                    timer1.Enabled = true;
                    minesProximinity = 0;
                    lblMineProx.Text = "Mine Prox: " + minesProximinity + "";
                    lblMineProx.ForeColor = Color.Black;

                    if (spriteMain.Right >= mainPanel.Width - 32 )
                    {
                        spriteMain.Left += 0;
                        spriteMain2.Left += 0;
                    }
                    else
                    {
                        if (showMinesEnabled == true)
                        {
                            showMinesEnabled = false;
                            hideMines(x, y);
                            showMinescount = 0;
                            showMinesLimitedRemainingToolStripMenuItem.Text = "Show Mines (" + showMinesclick + " clicks remaining)";
                        }

                        spriteMain.Image = spriteMain.Image = imageList.Images[Properties.Settings.Default.tank_right];
                        spriteMain.Left += movement;
                        spriteMain2.Left += movement;

                        currentPositionx += movement;
                        spritePositionX0ToolStripMenuItem.Text = "Sprite Position X: " + currentPositionx + "";

                        Howmanymoves();
                    }
                }
                //Enable debug Cheat dropdown
                if (e.KeyCode == Keys.H)
                {
                    {
                        Start:
                        debugcount++;
                        switch (debugcount)
                        {
                            case 1:
                                //Show cheat debug dropdown menu
                                debugToolStripMenuItem.Visible = true;
                                break;
                            case 2:
                                //Hide cheat debug dropdown menu
                                debugToolStripMenuItem.Visible = false;
                                break;
                            default:
                                debugcount = 0;
                                goto Start;
                        }
                    }
                }
                //Check if sprite hits the enemyBot
                if (enemyBotTick.Enabled == true && spriteMain.Bounds.IntersectsWith(enemybotSprite.Bounds) || enemyBotTick.Enabled == true && enemybotSprite.Bounds.IntersectsWith(spriteMain.Bounds))
                {
                    timer1.Enabled = false;
                    enemyBotTick.Enabled = false;
                    SoundPlayer audio = new SoundPlayer(MinefieldV2.Properties.Resources.Explosion_3);
                    audio.Play();
                    showMines(x, y);
                    ShowScore();
                }
                //Do a check to see if the sprite has hit a mine for each control in mainPanel that has the tag Bomb
                foreach (Control m in mainPanel.Controls)
                {
                    if ((string)m.Tag == "Bomb")
                    {
                        if (spriteMain.Bounds.IntersectsWith(m.Bounds))
                        {
                            timer1.Enabled = false;
                            SoundPlayer audio = new SoundPlayer(MinefieldV2.Properties.Resources.Explosion_3);
                            audio.Play();
                            showMines(x, y);
                            ShowScore();
                        }
                        //Change label color depending on how many mines are in proximity of tank
                        if (spriteMain2.Bounds.IntersectsWith(m.Bounds))
                        {
                            minesProximinity++;
                            lblMineProx.Text = "Mine Prox: " + minesProximinity + "";

                            if (minesProximinity == 1)
                            {
                                lblMineProx.ForeColor = Color.DarkGreen;
                            }
                            if (minesProximinity == 2)
                            {
                                lblMineProx.ForeColor = Color.DarkOrange;
                            }
                            if (minesProximinity == 3)
                            {
                                lblMineProx.ForeColor = Color.DarkMagenta;
                            }
                            if (minesProximinity >= 4)
                            {
                                lblMineProx.ForeColor = Color.DarkRed;
                            }
                        }
                    }
                }
            }
        }

        private void Howmanymoves()
        {
            //To stop player from going back and forth on the same two tiles
            //Each tile that the player visits will have its tag changed and thus
            //moveCount wont increase if the player goes back to a tile already visited

            //if move count reaches 20% (0.2) player wins

            int x = Properties.Settings.Default.GridWidth;
            int y = Properties.Settings.Default.GridHeight;

            int maxTiles = x * y;

            progressBar1.Maximum = 20;

            double percentage = ((double)moveCount / maxTiles) * 100;

            tilesVisitedToolStripMenuItem.Text = "Tiles Visited: " + moveCount + "/" + maxTiles + " (" + percentage + "%)";

            foreach (Control m in mainPanel.Controls)
            {
                if ((string)m.Tag == "Tile")
                {
                    if (spriteMain.Bounds.IntersectsWith(m.Bounds) && (string)m.Tag == "Tile")
                    {
                        moveCount += 1;
                        lblMoves.Text = "Moves: " + moveCount + "";
                        progressBar1.Value = (int)percentage;
                        tilesVisitedToolStripMenuItem.Text = "Tiles Visited: " + moveCount + "/" + maxTiles + " (" + percentage + "%)";

                        m.Tag = "VistedTile";

                        //"Hide" trail by changing color to grid/tile colors when randomiser is equals from 0 to 2
                        //Show trail if randomiser is equals from 7 to 9 by changing color
                        if (hidetrailTick.Enabled == true)
                        {
                            if (hideTrail == 0 || hideTrail == 1 || hideTrail == 2)
                            {
                                m.ForeColor = Properties.Settings.Default.GridColor;
                                m.BackColor = Properties.Settings.Default.TileColor;
                            }
                            else if (hideTrail == 9 || hideTrail == 8 || hideTrail == 7)
                            {
                                m.ForeColor = Color.NavajoWhite;
                                m.BackColor = Color.NavajoWhite;
                            }
                        }
                        else
                        {
                            m.ForeColor = Color.NavajoWhite;
                            m.BackColor = Color.NavajoWhite;
                        }


                        if (progressBar1.Value == progressBar1.Maximum)
                        {
                            percentage = 0;
                            winLevel();
                        }
                        else
                        {
                            //Do nothing
                        }

                        //Move count wont increase if sprite returns to a visited tile. Stops cheating in same spot.
                        if (spriteMain.Bounds.IntersectsWith(m.Bounds) && (string)m.Tag == "VistedTile")
                        {
                            moveCount += 0;
                        }
                    }
                }
            }
        }

        private void winLevel()
        {
            //Pause game and let user know they won level
            timer1.Enabled = false;
            levelsWon++;
            totallevelPoints = totallevelPoints + levelPoints;

            totalPointsToolStripMenuItem.Text = "Total Points: " + totallevelPoints + "";

            levelsWonToolStripMenuItem.Text = "Levels Won: " + levelsWon + "";

            DialogResult dialogResult = MessageBox.Show("You have passed the level! Click yes to continue or no to quit.", "Minefield", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                newGame();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private void showMinesUnlimitedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Properties.Settings.Default.GridWidth;
            int y = Properties.Settings.Default.GridHeight;

            showMines(x, y);
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reset to default scoreboard
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset to default settings?", "Minefield", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.lastplaceName = "Loser";
                Properties.Settings.Default.lastplaceScore = 2;
                Properties.Settings.Default.lastplaceDifficulty = "Easy";
                Properties.Settings.Default.lastplaceLevels = 1;

                Properties.Settings.Default.ninthplaceName = "Joanna";
                Properties.Settings.Default.ninthplaceScore = 20;
                Properties.Settings.Default.ninthplaceDifficulty = "Easy";
                Properties.Settings.Default.ninthplaceLevels = 10;

                Properties.Settings.Default.eigthplaceName = "Kieran";
                Properties.Settings.Default.eithplaceScore = 28;
                Properties.Settings.Default.eithplaceDifficulty = "Default";
                Properties.Settings.Default.eigthplaceLevels = 7;

                Properties.Settings.Default.seventhplaceName = "Mo";
                Properties.Settings.Default.seventhplaceScore = 32;
                Properties.Settings.Default.seventhplaceDifficulty = "Default";
                Properties.Settings.Default.seventhplaceLevels = 8;

                Properties.Settings.Default.sixthplaceName = "Liam";
                Properties.Settings.Default.sixthplaceScore = 36;
                Properties.Settings.Default.sixthplaceDifficulty = "Default";
                Properties.Settings.Default.sixthplaceLevels = 9;

                Properties.Settings.Default.fithplaceName = "Sam";
                Properties.Settings.Default.fithplaceScore = 40;
                Properties.Settings.Default.fithplaceDifficulty = "Default";
                Properties.Settings.Default.fithplaceLevels = 10;

                Properties.Settings.Default.fourthplaceName = "Sam";
                Properties.Settings.Default.fourthplaceScore = 42;
                Properties.Settings.Default.fourthplaceDifficulty = "Hard";
                Properties.Settings.Default.fourthplaceLevels = 7;

                Properties.Settings.Default.thirdplaceName = "Steve";
                Properties.Settings.Default.thirdplaceScore = 48;
                Properties.Settings.Default.thirdplaceDifficulty = "Hard";
                Properties.Settings.Default.thirdplaceLevels = 8;

                Properties.Settings.Default.secondplaceName = "Nick";
                Properties.Settings.Default.secondplaceScore = 54;
                Properties.Settings.Default.secondplaceDifficulty = "Hard";
                Properties.Settings.Default.secondplaceLevels = 9;

                Properties.Settings.Default.firstplaceName = "Mike";
                Properties.Settings.Default.firstplaceScore = 60;
                Properties.Settings.Default.firstplaceDifficulty = "Hard";
                Properties.Settings.Default.firstplaceLevels = 10;

                Properties.Settings.Default.Save();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do Nothing
            }
        }

        private void pauseTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void hidetrailTick_Tick(object sender, EventArgs e)
        {
            //For every tick, pick random number between 0 to 10 and give to variable hideTrail value
            Random randhideTrail = new Random();

            hideTrail = randhideTrail.Next(0, 10);
        }

        private void enemyBotTick_Tick(object sender, EventArgs e)
        {
            int x = Properties.Settings.Default.GridWidth;
            int y = Properties.Settings.Default.GridHeight;

            enemybotSprite.Visible = true;
            enemybotTimer++;
            enemyBotTimerToolStripMenuItem.Text = "Enemy Bot Timer: " + enemybotTimer + "";

            Random enemyBotRand = new Random();

            int enemybotmovement = enemyBotRand.Next(0, 5);

            if (enemybotmovement == 1)
            {
                //enemyBot can move as long as within mainPanel dimensions
                if (enemybotSprite.Top <= mainPanel.Top)
                {
                    enemybotSprite.Top += movement;
                }
                else
                {
                    enemybotSprite.Image = enemybotSprite.Image = imageList.Images[Properties.Settings.Default.enemytank_forward];
                    enemybotSprite.Top -= movement;
                }
            }
            if (enemybotmovement == 2)
            {
                //enemyBot can move as long as within mainPanel dimensions
                if (enemybotSprite.Left <= mainPanel.Left)
                {
                    enemybotSprite.Left -= 0;
                }
                else
                {
                    enemybotSprite.Image = enemybotSprite.Image = imageList.Images[Properties.Settings.Default.enemytank_left];
                    enemybotSprite.Left -= movement;
                }
            }
            if (enemybotmovement == 3)
            {
                //enemyBot can move as long as within mainPanel dimensions
                if (enemybotSprite.Right >= mainPanel.Right - 64)
                {
                    enemybotSprite.Left -= 0;
                }
                else
                {
                    enemybotSprite.Image = enemybotSprite.Image = imageList.Images[Properties.Settings.Default.enemytank_right];
                    enemybotSprite.Left += movement;
                }
            }
            if (enemybotmovement == 4)
            {
                //Quick fix to stop sprite exceeding bottom panel in different levels
                if (levelSelected == "Easy")
                {
                    if (spriteMain.Bottom >= mainPanel.Height - 32)
                    {
                        enemybotSprite.Top -= 0;
                    }
                    else
                    {
                        enemybotSprite.Image = enemybotSprite.Image = imageList.Images[Properties.Settings.Default.enemytank_backwards];
                        enemybotSprite.Top += movement;
                    }
                }
                if (levelSelected == "Default")
                {
                    if (spriteMain.Bottom >= mainPanel.Height - 64)
                    {
                        enemybotSprite.Top -= 0;
                    }
                    else
                    {
                        enemybotSprite.Image = enemybotSprite.Image = imageList.Images[Properties.Settings.Default.enemytank_backwards];
                        enemybotSprite.Top += movement;
                    }
                }
                if (levelSelected == "Hard")
                {
                    if (spriteMain.Bottom >= mainPanel.Height - 96)
                    {
                        enemybotSprite.Top -= 0;
                    }
                    else
                    {
                        enemybotSprite.Image = enemybotSprite.Image = imageList.Images[Properties.Settings.Default.enemytank_backwards];
                        enemybotSprite.Top += movement;
                    }
                }
                //Check if enemybot hits the sprite
                if (enemyBotTick.Enabled == true && enemybotSprite.Bounds.IntersectsWith(spriteMain.Bounds))
                {
                    timer1.Enabled = false;
                    enemyBotTick.Enabled = false;
                    SoundPlayer audio = new SoundPlayer(MinefieldV2.Properties.Resources.Explosion_3);
                    audio.Play();
                    showMines(x, y);
                    ShowScore();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //If timer runs out, player loses
            int x = Properties.Settings.Default.GridWidth;
            int y = Properties.Settings.Default.GridHeight;

            timer--;
            lblTimer.Text = "Timer: " + timer + "";

            if (timer == 0)
            {
                timer1.Enabled = false;
                showMines(x, y);

                DialogResult dialogResult = MessageBox.Show("You have lost the level! Click yes to continue or no to quit.", "Minefield", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    newGame();
                    levelsWon = 0;
                    totallevelPoints = 0;
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
    }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutInfo = new About();
            aboutInfo.Show();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions();
            instructions.Show();
        }

        private void scoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.Show();
        }
    }
}
