namespace WinFormsApp5
{
    partial class FormMine
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
            labelOre1 = new Label();
            labelWorker = new Label();
            buttonBuy = new Button();
            buttonSell = new Button();
            textBoxSellOre = new TextBox();
            labelOre = new Label();
            labelWorker1 = new Label();
            label1 = new Label();
            labelBalance = new Label();
            SuspendLayout();
            // 
            // labelOre1
            // 
            labelOre1.AutoSize = true;
            labelOre1.Font = new Font("SimSun", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOre1.Location = new Point(15, 41);
            labelOre1.Name = "labelOre1";
            labelOre1.Size = new Size(77, 37);
            labelOre1.TabIndex = 0;
            labelOre1.Text = "Ore";
            // 
            // labelWorker
            // 
            labelWorker.AutoSize = true;
            labelWorker.Font = new Font("SimSun", 21.75F, FontStyle.Bold);
            labelWorker.Location = new Point(366, 264);
            labelWorker.Name = "labelWorker";
            labelWorker.Size = new Size(45, 29);
            labelWorker.TabIndex = 0;
            labelWorker.Text = "15";
            // 
            // buttonBuy
            // 
            buttonBuy.Font = new Font("SimSun", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuy.Location = new Point(12, 248);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(159, 54);
            buttonBuy.TabIndex = 1;
            buttonBuy.Text = "300$";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // buttonSell
            // 
            buttonSell.Font = new Font("SimSun", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSell.Location = new Point(228, 81);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(142, 38);
            buttonSell.TabIndex = 1;
            buttonSell.Text = "SELLS";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += buttonSell_Click;
            // 
            // textBoxSellOre
            // 
            textBoxSellOre.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSellOre.Location = new Point(12, 81);
            textBoxSellOre.Name = "textBoxSellOre";
            textBoxSellOre.Size = new Size(210, 38);
            textBoxSellOre.TabIndex = 2;
            // 
            // labelOre
            // 
            labelOre.AutoSize = true;
            labelOre.Font = new Font("SimSun", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOre.Location = new Point(15, 4);
            labelOre.Name = "labelOre";
            labelOre.Size = new Size(77, 37);
            labelOre.TabIndex = 0;
            labelOre.Text = "Ore";
            // 
            // labelWorker1
            // 
            labelWorker1.AutoSize = true;
            labelWorker1.Font = new Font("SimSun", 21.75F, FontStyle.Bold);
            labelWorker1.Location = new Point(256, 264);
            labelWorker1.Name = "labelWorker1";
            labelWorker1.Size = new Size(125, 29);
            labelWorker1.TabIndex = 0;
            labelWorker1.Text = "Worker:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 21.75F, FontStyle.Bold);
            label1.Location = new Point(12, 216);
            label1.Name = "label1";
            label1.Size = new Size(77, 29);
            label1.TabIndex = 0;
            label1.Text = "buy:";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBalance.Location = new Point(235, 4);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(122, 25);
            labelBalance.TabIndex = 3;
            labelBalance.Text = "Balance:100$";
            // 
            // FormMine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 304);
            Controls.Add(labelBalance);
            Controls.Add(label1);
            Controls.Add(labelWorker);
            Controls.Add(textBoxSellOre);
            Controls.Add(buttonSell);
            Controls.Add(buttonBuy);
            Controls.Add(labelWorker1);
            Controls.Add(labelOre);
            Controls.Add(labelOre1);
            Name = "FormMine";
            Text = "Mine";
            Load += FormMine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOre1;
        private Label labelWorker;
        private Button buttonBuy;
        private Button buttonSell;
        private TextBox textBoxSellOre;
        private Label labelOre;
        private Label labelWorker1;
        private Label label1;
        private Label labelBalance;
    }
}