namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxIronMine = new PictureBox();
            labelBalance = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxGoalMine = new PictureBox();
            pictureBoxStoneMine = new PictureBox();
            pictureBoxGoldMine = new PictureBox();
            label1 = new Label();
            labelOreIron = new Label();
            labelOreGold = new Label();
            labelOreCoal = new Label();
            labelOreStone = new Label();
            labelOreIronCout = new Label();
            labelOreGoldCout = new Label();
            labelOreCoalCout = new Label();
            labelOreStoneCout = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIronMine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoalMine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStoneMine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoldMine).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIronMine
            // 
            pictureBoxIronMine.Image = Resource1.Irom_Mine;
            pictureBoxIronMine.Location = new Point(637, 83);
            pictureBoxIronMine.Name = "pictureBoxIronMine";
            pictureBoxIronMine.Size = new Size(168, 101);
            pictureBoxIronMine.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIronMine.TabIndex = 0;
            pictureBoxIronMine.TabStop = false;
            pictureBoxIronMine.Click += pictureBoxIronMine_Click;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBalance.Location = new Point(15, 17);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(102, 21);
            labelBalance.TabIndex = 1;
            labelBalance.Text = "Balance:100$";
            labelBalance.Click += labelBalance_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBoxGoalMine
            // 
            pictureBoxGoalMine.Image = Resource1.GoalMine;
            pictureBoxGoalMine.Location = new Point(527, 276);
            pictureBoxGoalMine.Name = "pictureBoxGoalMine";
            pictureBoxGoalMine.Size = new Size(168, 101);
            pictureBoxGoalMine.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGoalMine.TabIndex = 0;
            pictureBoxGoalMine.TabStop = false;
            pictureBoxGoalMine.Click += pictureBoxGoalMine_Click;
            // 
            // pictureBoxStoneMine
            // 
            pictureBoxStoneMine.Image = (Image)resources.GetObject("pictureBoxStoneMine.Image");
            pictureBoxStoneMine.Location = new Point(261, 17);
            pictureBoxStoneMine.Name = "pictureBoxStoneMine";
            pictureBoxStoneMine.Size = new Size(168, 101);
            pictureBoxStoneMine.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxStoneMine.TabIndex = 0;
            pictureBoxStoneMine.TabStop = false;
            pictureBoxStoneMine.Click += pictureBoxStoneMine_Click;
            // 
            // pictureBoxGoldMine
            // 
            pictureBoxGoldMine.Image = (Image)resources.GetObject("pictureBoxGoldMine.Image");
            pictureBoxGoldMine.Location = new Point(-4, 345);
            pictureBoxGoldMine.Name = "pictureBoxGoldMine";
            pictureBoxGoldMine.Size = new Size(168, 101);
            pictureBoxGoldMine.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGoldMine.TabIndex = 0;
            pictureBoxGoldMine.TabStop = false;
            pictureBoxGoldMine.Click += pictureBoxGoldMine_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(637, 428);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 1;
            label1.Text = "Version ALPHA 0.0.3";
            // 
            // labelOreIron
            // 
            labelOreIron.AutoSize = true;
            labelOreIron.Font = new Font("Segoe UI", 9F);
            labelOreIron.Location = new Point(12, 102);
            labelOreIron.Name = "labelOreIron";
            labelOreIron.Size = new Size(61, 15);
            labelOreIron.TabIndex = 1;
            labelOreIron.Text = "Iron Mine:";
            labelOreIron.Click += labelBalance_Click;
            // 
            // labelOreGold
            // 
            labelOreGold.AutoSize = true;
            labelOreGold.Font = new Font("Segoe UI", 9F);
            labelOreGold.Location = new Point(12, 117);
            labelOreGold.Name = "labelOreGold";
            labelOreGold.Size = new Size(65, 15);
            labelOreGold.TabIndex = 1;
            labelOreGold.Text = "Gold Mine:";
            labelOreGold.Click += labelBalance_Click;
            // 
            // labelOreCoal
            // 
            labelOreCoal.AutoSize = true;
            labelOreCoal.Font = new Font("Segoe UI", 9F);
            labelOreCoal.Location = new Point(12, 132);
            labelOreCoal.Name = "labelOreCoal";
            labelOreCoal.Size = new Size(64, 15);
            labelOreCoal.TabIndex = 1;
            labelOreCoal.Text = "Coal Mine:";
            labelOreCoal.Click += labelBalance_Click;
            // 
            // labelOreStone
            // 
            labelOreStone.AutoSize = true;
            labelOreStone.Font = new Font("Segoe UI", 9F);
            labelOreStone.Location = new Point(12, 147);
            labelOreStone.Name = "labelOreStone";
            labelOreStone.Size = new Size(70, 15);
            labelOreStone.TabIndex = 1;
            labelOreStone.Text = "Stone Mine:";
            labelOreStone.Click += labelBalance_Click;
            // 
            // labelOreIronCout
            // 
            labelOreIronCout.AutoSize = true;
            labelOreIronCout.Font = new Font("Segoe UI", 9F);
            labelOreIronCout.Location = new Point(79, 102);
            labelOreIronCout.Name = "labelOreIronCout";
            labelOreIronCout.Size = new Size(13, 15);
            labelOreIronCout.TabIndex = 1;
            labelOreIronCout.Text = "1";
            labelOreIronCout.Visible = false;
            labelOreIronCout.Click += labelBalance_Click;
            // 
            // labelOreGoldCout
            // 
            labelOreGoldCout.AutoSize = true;
            labelOreGoldCout.Font = new Font("Segoe UI", 9F);
            labelOreGoldCout.Location = new Point(79, 117);
            labelOreGoldCout.Name = "labelOreGoldCout";
            labelOreGoldCout.Size = new Size(13, 15);
            labelOreGoldCout.TabIndex = 1;
            labelOreGoldCout.Text = "1";
            labelOreGoldCout.Visible = false;
            labelOreGoldCout.Click += labelBalance_Click;
            // 
            // labelOreCoalCout
            // 
            labelOreCoalCout.AutoSize = true;
            labelOreCoalCout.Font = new Font("Segoe UI", 9F);
            labelOreCoalCout.Location = new Point(79, 132);
            labelOreCoalCout.Name = "labelOreCoalCout";
            labelOreCoalCout.Size = new Size(13, 15);
            labelOreCoalCout.TabIndex = 1;
            labelOreCoalCout.Text = "1";
            labelOreCoalCout.Visible = false;
            labelOreCoalCout.Click += labelBalance_Click;
            // 
            // labelOreStoneCout
            // 
            labelOreStoneCout.AutoSize = true;
            labelOreStoneCout.Font = new Font("Segoe UI", 9F);
            labelOreStoneCout.Location = new Point(79, 147);
            labelOreStoneCout.Name = "labelOreStoneCout";
            labelOreStoneCout.Size = new Size(13, 15);
            labelOreStoneCout.TabIndex = 1;
            labelOreStoneCout.Text = "1";
            labelOreStoneCout.Visible = false;
            labelOreStoneCout.Click += labelBalance_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 458);
            Controls.Add(label1);
            Controls.Add(labelOreStoneCout);
            Controls.Add(labelOreStone);
            Controls.Add(labelOreCoalCout);
            Controls.Add(labelOreGoldCout);
            Controls.Add(labelOreCoal);
            Controls.Add(labelOreIronCout);
            Controls.Add(labelOreGold);
            Controls.Add(labelOreIron);
            Controls.Add(labelBalance);
            Controls.Add(pictureBoxGoalMine);
            Controls.Add(pictureBoxGoldMine);
            Controls.Add(pictureBoxStoneMine);
            Controls.Add(pictureBoxIronMine);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mine Farm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIronMine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoalMine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStoneMine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoldMine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxIronMine;
        private Label labelBalance;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBoxGoalMine;
        private PictureBox pictureBoxStoneMine;
        private PictureBox pictureBoxGoldMine;
        private Label label1;
        private Label labeloRE;
        private Label labelOreGoldCout;
        private Label labelOreCoalCout;
        private Label labelOreStoneCout;
        private Label labelOreIron;
        private Label labelOreGold;
        private Label labelOreCoal;
        private Label labelOreStone;
        private Label labelOreIronCout;
    }
}
