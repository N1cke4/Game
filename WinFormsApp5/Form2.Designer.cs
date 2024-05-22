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
            labelOre = new Label();
            labelWorker = new Label();
            buttonBuy = new Button();
            buttonSell = new Button();
            textBoxSellOre = new TextBox();
            SuspendLayout();
            // 
            // labelOre
            // 
            labelOre.AutoSize = true;
            labelOre.Font = new Font("SimSun", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOre.Location = new Point(50, 3);
            labelOre.Name = "labelOre";
            labelOre.Size = new Size(77, 37);
            labelOre.TabIndex = 0;
            labelOre.Text = "Ore";
            // 
            // labelWorker
            // 
            labelWorker.AutoSize = true;
            labelWorker.Font = new Font("SimSun", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWorker.Location = new Point(88, 170);
            labelWorker.Name = "labelWorker";
            labelWorker.Size = new Size(157, 37);
            labelWorker.TabIndex = 0;
            labelWorker.Text = "Worker:";
            // 
            // buttonBuy
            // 
            buttonBuy.Font = new Font("SimSun", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuy.Location = new Point(12, 210);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(281, 44);
            buttonBuy.TabIndex = 1;
            buttonBuy.Text = "BUY 300$";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // buttonSell
            // 
            buttonSell.Font = new Font("SimSun", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSell.Location = new Point(83, 87);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(142, 44);
            buttonSell.TabIndex = 1;
            buttonSell.Text = "SELLS";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += buttonSell_Click;
            // 
            // textBoxSellOre
            // 
            textBoxSellOre.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSellOre.Location = new Point(50, 43);
            textBoxSellOre.Name = "textBoxSellOre";
            textBoxSellOre.Size = new Size(210, 38);
            textBoxSellOre.TabIndex = 2;
            // 
            // FormMine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 259);
            Controls.Add(textBoxSellOre);
            Controls.Add(buttonSell);
            Controls.Add(buttonBuy);
            Controls.Add(labelWorker);
            Controls.Add(labelOre);
            Name = "FormMine";
            Text = "Form2";
            Load += FormMine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOre;
        private Label labelWorker;
        private Button buttonBuy;
        private Button buttonSell;
        private TextBox textBoxSellOre;
    }
}