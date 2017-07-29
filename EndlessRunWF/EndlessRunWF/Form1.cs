using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndlessRunWF
{
    public partial class Form1 : Form
    {  
        private int _points = 0;    
        private int _speedX;
        private int _speedY;
        private bool isStanding = true;
        private bool isGravity = true;
        private int _floorSpeed = 0;
        private int _lastRandom = 0;
        public Form1()
        {
            InitializeComponent();
             
            _speedX = 0;
            _speedY = 0;

            Cursor.Hide();
            this.TopMost = true;                   
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)         
                this.Close();
            
            if(e.KeyCode == Keys.Right)           
                _speedX = 20;
           
            if (e.KeyCode == Keys.Left)          
                _speedX = -20;
            
            if (e.KeyCode == Keys.Up && isStanding == true)                     
                    _speedY = -15;
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // right/left movement
            player.Left += _speedX;

            if (_speedX > 0)
                player.Load("images/skins/right1.png");
            else if (_speedX < 0)
                 player.Load("images/skins/left1.png");
           

            if (player.Left <= background.Left)
                player.Left = background.Left + 1;

            if (player.Right >= background.Right)
                player.Left = background.Right - player.Width - 1;
            

            //gravity and jump
            player.Top += _speedY;

            if (isGravity == true && _speedY < 8)
                _speedY++;

            PictureBox[] floorArray = new PictureBox[] { floor1, floor2, floor3, floor4, floor5, floor6, floor7};

            bool isColliding = false;

            foreach (PictureBox floor in floorArray)
            {
                isColliding = checkCollision(floor);

                if (isColliding == true)
                    break;
            }

            if (isColliding == false)
            {
                isGravity = true;
                isStanding = false;
            }

            if (isGravity == false)
            {
                _speedY = 0;
            }


            // gameOver
            if(player.Top <= background.Top || player.Bottom >= background.Bottom)
            {
                pointsTimer.Enabled = false;
                floorTimer.Enabled = false;
                gameoverLabel.Visible = true;
                label1.Left = gameoverLabel.Left + gameoverLabel.Width/3;
                label1.Top = gameoverLabel.Bottom + 10;
                label2.Top = label1.Top;
                label2.Left = label1.Right + 25;
                timer1.Enabled = false;
            }     

        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            _speedX = 0;
            player.Load("images/skins/front.png");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _points ++;
            label2.Text = _points.ToString();
        }

        private bool checkCollision(PictureBox floor)
        {
            if (player.Bottom >= floor.Top && player.Bottom <= floor.Bottom && player.Right >= floor.Left && player.Left <= floor.Right)
            {
                isGravity = false;
                isStanding = true;
                player.Top = floor.Top - player.Height;
                return true;
            }

            return false;
        }
        private void randomizeFloorPosition(PictureBox floor)
        {
            if (floor.Bottom < 0)
            {
                floor.Top = background.Bottom + 10;
                int part;

                do
                {
                   part = new Random().Next(0, 5);
                } while (part == _lastRandom);

                _lastRandom = part;

                switch(part)
                {
                    case 0:
                        floor.Left = background.Left + 1;
                        break;
                    case 1:
                        floor.Left = background.Width / 4;
                        break;
                    case 2:
                        floor.Left = background.Width / 2;
                        break;
                    case 3:
                        floor.Left = background.Width / 4 * 3;
                        break;
                    case 4:
                        floor.Left = background.Width - floor.Width;
                        break;
                    default:
                        floor.Left = background.Width / 2 - floor.Width / 2;
                        break;
                }
            }
        }

        private void floorTimer_Tick_1(object sender, EventArgs e)
        {
            if (_floorSpeed != -25)
            {
                if (_points > 10)
                    _floorSpeed = -10;
                else if (_points > 250)
                    _floorSpeed = -15;
                else if (_points > 500)
                    _floorSpeed = -20;
                else if (_points > 1000)
                    _floorSpeed = -25;
            }

            floor1.Top += _floorSpeed;
            floor2.Top += _floorSpeed;
            floor3.Top += _floorSpeed;
            floor4.Top += _floorSpeed;
            floor5.Top += _floorSpeed;
            floor6.Top += _floorSpeed;
            floor7.Top += _floorSpeed;
                           
            randomizeFloorPosition(floor1);
            randomizeFloorPosition(floor2);
            randomizeFloorPosition(floor3);
            randomizeFloorPosition(floor4);
            randomizeFloorPosition(floor5);
            randomizeFloorPosition(floor6);
            randomizeFloorPosition(floor7);
                        
        }
    }
}
