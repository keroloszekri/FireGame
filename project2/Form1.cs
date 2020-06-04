using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Media;

namespace project2
{
    public partial class Form1 : Form
    {
        Form2 f;
        PictureBox[] p=new PictureBox[10];
        public bool Form2IsOpen = false;
        bool moveright = false;
        bool moveleft = false;
        bool fire = false;
        bool move = false;
        bool ts2 = false;
        int score = 0;
        Random r = new Random();
        int level = 1;
        int i = 0;
        int j = 0;
        int k = 1;
       
        public Form1()
        {
            InitializeComponent();
            try {
                toolStripStatusLabel1.Text = "TIME NOW : " + DateTime.Now + "\n ENG: KEROLOS ZEKRY.";
                danger1.Hide();
                danger1.Left = r.Next(-1, 231);
                danger2.Hide();
                danger2.Top = -300;
                danger2.Left = r.Next(-1, 231);
                danger3.Hide();
                danger3.Top = -500;
                danger3.Left = r.Next(-1, 231);
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                f = new Form2(this);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
         }

        private void gameOver()
        {
            try {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                MessageBox.Show("GAME OVER !!! ");
                Application.Exit();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
         }

        private void enemyHit(PictureBox x)
        {
            try {
                if (x.Bounds.IntersectsWith(danger1.Bounds))
                {
                    score += 1;
                    danger1.Top = -250;
                    x.Hide();
                }

                if (x.Bounds.IntersectsWith(danger2.Bounds))
                {
                    score += 1;
                    danger2.Top = -250;
                    x.Hide();

                }
                if (x.Bounds.IntersectsWith(danger3.Bounds))
                {
                    score += 1;
                    danger3.Top = -250;
                    x.Hide();

                }

                textBox1.Text = score.ToString();
                if (score == 3)
                {
                    level = 2;

                }
               
            }
            catch (Exception ex) { return; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                Application.Exit();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode.GetHashCode() == f.charMoveRight.GetHashCode())
                    moveright = true;
                if (e.KeyCode.GetHashCode() == f.charMoveleft.GetHashCode())
                    moveleft = true;
                if (e.KeyCode.GetHashCode() == f.charfire.GetHashCode())
                {
                    
                    p[i] = new PictureBox();
                    p[i].Location = new Point(player.Left + 10, 236);
                    p[i].Image = Properties.Resources.aa;
                    p[i].Size = new System.Drawing.Size(21, 31);
                    p[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.background.Controls.Add(p[i]);
                    fire = true;
                    move = true;
                    i = (i + 1) % 10;
                    if (i > 1)
                        ts2 = true;
                    if (j >= 10)
                        j = 0;
                    if (k > 10)
                        k = 1;
                }
            }
            catch (Exception ex) { return; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode.GetHashCode() == f.charMoveRight.GetHashCode())
                    moveright = false;
                if (e.KeyCode.GetHashCode() == f.charMoveleft.GetHashCode())
                    moveleft = false;
            }
            catch (Exception ex) { return; }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
                if (moveright == true && player.Left < 216)
                {
                    player.Left += 3;
                }

                if (moveleft == true && player.Left > 0)
                {
                    player.Left -= 3;
                }


                if (move == true)
                {
                    p[j].Top -= 10;

                    if (p[j].Top < -30)
                        j += 2;
                    enemyHit(p[j]);
                }
                
            }catch(Exception ex)
            {
                return;
            }

        }

        private void background_Paint(object sender, PaintEventArgs e)
        {    
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try {
                if (ts2)
                {
                    if (moveright == true && player.Left < 216)
                    {
                        player.Left += 3;
                    }

                    if (moveleft == true && player.Left > 0)
                    {
                        player.Left -= 3;
                    }
                    if (move == true)
                    {
                        p[k].Top -= 10;

                        if (p[k].Top < -30)
                            k += 2;
                        enemyHit(p[k]);
                    }

                   
                }

            }catch(Exception ex) { return; }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try {
                if (true)
                {
                    if (level == 1)
                    {
                        danger1.Show();
                        danger1.Top += 1;
                        danger2.Show();
                        danger2.Top += 1;
                        danger3.Show();
                        danger3.Top += 1;
                    }
                    if (level == 2)
                    {
                        danger1.Show();
                        danger1.Top += 1;

                        if (danger1.Left == 0) { danger1.Left = 217; }
                        danger1.Left -= 1;

                        danger2.Show();
                        danger2.Top += 1;

                        if (danger2.Left == 0) { danger2.Left = 217; }
                        danger2.Left -= 1;

                        danger3.Show();
                        danger3.Top += 1;

                        if (danger1.Left == 0) { danger1.Left = 217; }
                        danger3.Left -= 1;

                    }
                    if (player.Bounds.IntersectsWith(danger1.Bounds) | player.Bounds.IntersectsWith(danger2.Bounds) | player.Bounds.IntersectsWith(danger3.Bounds))
                    {
                        if ((progressBar1.Value < progressBar1.Maximum))
                        {
                            progressBar1.Value += 1;
                        }
                        else
                        {
                            gameOver();
                        }
                    }
                    if (danger1.Top == 326)
                    {

                        danger1.Top = 0;
                        danger1.Left = r.Next(-1, 231);
                    }
                    if (danger2.Top == 326)
                    {

                        danger2.Top = 0;
                        danger2.Left = r.Next(-1, 231);
                    }
                    if (danger3.Top == 326)
                    {

                        danger3.Top = 0;
                        danger3.Left = r.Next(-1, 231);
                    }
                }
            }
            catch (Exception ex) { return; }
        }

        private void danger_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void levelTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                level = 2;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void danger3_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try {
                Application.Exit();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                score = 0;
                textBox1.Text = score.ToString();
                progressBar1.Value = progressBar1.Minimum ;
                level = 1;
                danger1.Top = -150;
                danger2.Top = -250;
                danger3.Top = -300;
            }
            catch(Exception ex) {MessageBox.Show( ex.Message.ToString()); }
            }

        private void pAUSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void rESUMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void settingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try {
                if (Form2IsOpen == false)
                {
                    f = new Form2(this);
                    f.Show();
                    Form2IsOpen = true;
                }
                else
                {
                    MessageBox.Show("NOT ALLOWED TO OPEN THIS FORM NOW .");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            try {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void levelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            try {
                if (Form2IsOpen == false)
                {
                    f = new Form2(this);
                    f.Show();
                    Form2IsOpen = true;
                }
                else
                {
                    MessageBox.Show("NOT ALLOWED TO OPEN THIS FORM NOW .");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            try {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            try {
                Application.Exit();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            try {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void sAVETXTINYOURCOMPUTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1-you should select your direction first \n by using Setting in menue strip or the setting button. \n 2-if you shoot the ten enemy you well automaticly move to \n next level . \n 3-you can Control game operations (Stop, pause, resume and start new game). \n 4-Change play setting( e.g. play with keyboard arrows). \n 5-The game has two levels. In the first level, rocks fall is vertically (Top down) , \n In the second level, rocks fall is diagonally . \n 6-this program develope by eng:kerolos zekry .");
        }

        
    }
}
