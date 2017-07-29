namespace EndlessRunWF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.background = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.floor6 = new System.Windows.Forms.PictureBox();
            this.floor8 = new System.Windows.Forms.PictureBox();
            this.floor7 = new System.Windows.Forms.PictureBox();
            this.floor5 = new System.Windows.Forms.PictureBox();
            this.floor4 = new System.Windows.Forms.PictureBox();
            this.floor3 = new System.Windows.Forms.PictureBox();
            this.floor2 = new System.Windows.Forms.PictureBox();
            this.floor1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pointsTimer = new System.Windows.Forms.Timer(this.components);
            this.floorTimer = new System.Windows.Forms.Timer(this.components);
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floor6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.BackgroundImage")));
            this.background.Controls.Add(this.label2);
            this.background.Controls.Add(this.label1);
            this.background.Controls.Add(this.gameoverLabel);
            this.background.Controls.Add(this.floor6);
            this.background.Controls.Add(this.floor8);
            this.background.Controls.Add(this.floor7);
            this.background.Controls.Add(this.floor5);
            this.background.Controls.Add(this.floor4);
            this.background.Controls.Add(this.floor3);
            this.background.Controls.Add(this.floor2);
            this.background.Controls.Add(this.floor1);
            this.background.Controls.Add(this.player);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1262, 673);
            this.background.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "xxxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameoverLabel.ForeColor = System.Drawing.Color.Red;
            this.gameoverLabel.Location = new System.Drawing.Point(421, 255);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(482, 95);
            this.gameoverLabel.TabIndex = 5;
            this.gameoverLabel.Text = "Game Over";
            this.gameoverLabel.Visible = false;
            // 
            // floor6
            // 
            this.floor6.BackColor = System.Drawing.Color.Transparent;
            this.floor6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.floor6.Image = ((System.Drawing.Image)(resources.GetObject("floor6.Image")));
            this.floor6.Location = new System.Drawing.Point(826, 66);
            this.floor6.Name = "floor6";
            this.floor6.Size = new System.Drawing.Size(188, 35);
            this.floor6.TabIndex = 13;
            this.floor6.TabStop = false;
            // 
            // floor8
            // 
            this.floor8.BackColor = System.Drawing.Color.Transparent;
            this.floor8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.floor8.Image = ((System.Drawing.Image)(resources.GetObject("floor8.Image")));
            this.floor8.Location = new System.Drawing.Point(621, 626);
            this.floor8.Name = "floor8";
            this.floor8.Size = new System.Drawing.Size(188, 35);
            this.floor8.TabIndex = 12;
            this.floor8.TabStop = false;
            // 
            // floor7
            // 
            this.floor7.BackColor = System.Drawing.Color.Transparent;
            this.floor7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.floor7.Image = ((System.Drawing.Image)(resources.GetObject("floor7.Image")));
            this.floor7.Location = new System.Drawing.Point(75, 315);
            this.floor7.Name = "floor7";
            this.floor7.Size = new System.Drawing.Size(188, 35);
            this.floor7.TabIndex = 11;
            this.floor7.TabStop = false;
            // 
            // floor5
            // 
            this.floor5.BackColor = System.Drawing.Color.Transparent;
            this.floor5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.floor5.Image = ((System.Drawing.Image)(resources.GetObject("floor5.Image")));
            this.floor5.Location = new System.Drawing.Point(228, 0);
            this.floor5.Name = "floor5";
            this.floor5.Size = new System.Drawing.Size(188, 35);
            this.floor5.TabIndex = 8;
            this.floor5.TabStop = false;
            // 
            // floor4
            // 
            this.floor4.BackColor = System.Drawing.Color.Transparent;
            this.floor4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.floor4.Image = ((System.Drawing.Image)(resources.GetObject("floor4.Image")));
            this.floor4.Location = new System.Drawing.Point(493, 166);
            this.floor4.Name = "floor4";
            this.floor4.Size = new System.Drawing.Size(188, 35);
            this.floor4.TabIndex = 7;
            this.floor4.TabStop = false;
            // 
            // floor3
            // 
            this.floor3.BackColor = System.Drawing.Color.Transparent;
            this.floor3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.floor3.Image = ((System.Drawing.Image)(resources.GetObject("floor3.Image")));
            this.floor3.Location = new System.Drawing.Point(774, 462);
            this.floor3.Name = "floor3";
            this.floor3.Size = new System.Drawing.Size(188, 35);
            this.floor3.TabIndex = 6;
            this.floor3.TabStop = false;
            // 
            // floor2
            // 
            this.floor2.BackColor = System.Drawing.Color.Transparent;
            this.floor2.Image = ((System.Drawing.Image)(resources.GetObject("floor2.Image")));
            this.floor2.Location = new System.Drawing.Point(1071, 242);
            this.floor2.Name = "floor2";
            this.floor2.Size = new System.Drawing.Size(188, 35);
            this.floor2.TabIndex = 4;
            this.floor2.TabStop = false;
            // 
            // floor1
            // 
            this.floor1.BackColor = System.Drawing.Color.Transparent;
            this.floor1.Image = ((System.Drawing.Image)(resources.GetObject("floor1.Image")));
            this.floor1.Location = new System.Drawing.Point(137, 531);
            this.floor1.Name = "floor1";
            this.floor1.Size = new System.Drawing.Size(188, 35);
            this.floor1.TabIndex = 3;
            this.floor1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.ImageLocation = "";
            this.player.Location = new System.Drawing.Point(1099, 42);
            this.player.Margin = new System.Windows.Forms.Padding(0);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(27, 43);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 17;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pointsTimer
            // 
            this.pointsTimer.Enabled = true;
            this.pointsTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // floorTimer
            // 
            this.floorTimer.Enabled = true;
            this.floorTimer.Interval = 33;
            this.floorTimer.Tick += new System.EventHandler(this.floorTimer_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "EndlessRun";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floor6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox floor1;
        private System.Windows.Forms.PictureBox floor2;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.PictureBox floor3;
        private System.Windows.Forms.Timer pointsTimer;
        private System.Windows.Forms.PictureBox floor4;
        private System.Windows.Forms.PictureBox floor6;
        private System.Windows.Forms.PictureBox floor8;
        private System.Windows.Forms.PictureBox floor7;
        private System.Windows.Forms.PictureBox floor5;
        private System.Windows.Forms.Timer floorTimer;
    }
}

