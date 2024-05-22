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
            pictureBoxIronMine = new PictureBox();
            labelBalance = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxGoalMine = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIronMine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoalMine).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIronMine
            // 
            pictureBoxIronMine.Image = Resource1.Irom_Mine;
            pictureBoxIronMine.Location = new Point(49, 58);
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
            labelBalance.Location = new Point(15, 17);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(75, 15);
            labelBalance.TabIndex = 1;
            labelBalance.Text = "Balance:100$";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBoxGoalMine
            // 
            pictureBoxGoalMine.Image = Resource1.GoalMine;
            pictureBoxGoalMine.Location = new Point(577, 156);
            pictureBoxGoalMine.Name = "pictureBoxGoalMine";
            pictureBoxGoalMine.Size = new Size(168, 101);
            pictureBoxGoalMine.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGoalMine.TabIndex = 0;
            pictureBoxGoalMine.TabStop = false;
            pictureBoxGoalMine.Click += pictureBoxGoalMine_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBalance);
            Controls.Add(pictureBoxGoalMine);
            Controls.Add(pictureBoxIronMine);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIronMine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoalMine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxIronMine;
        private Label labelBalance;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBoxGoalMine;
    }
}
