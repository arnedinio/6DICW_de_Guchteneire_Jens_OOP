namespace SimonSays
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
            colorDialog1 = new ColorDialog();
            groenPictureBox = new PictureBox();
            blauwPictureBox = new PictureBox();
            geelPictureBox = new PictureBox();
            roodPictureBox = new PictureBox();
            button1 = new Button();
            highScoreLabel = new Label();
            thirdScoreLabel = new Label();
            secondScoreLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)groenPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blauwPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roodPictureBox).BeginInit();
            SuspendLayout();
            // 
            // groenPictureBox
            // 
            groenPictureBox.BackColor = Color.Green;
            groenPictureBox.Location = new Point(470, 263);
            groenPictureBox.Name = "groenPictureBox";
            groenPictureBox.Size = new Size(257, 131);
            groenPictureBox.TabIndex = 0;
            groenPictureBox.TabStop = false;
            groenPictureBox.Click += groenPictureBox_Click;
            // 
            // blauwPictureBox
            // 
            blauwPictureBox.BackColor = Color.Blue;
            blauwPictureBox.Location = new Point(470, 23);
            blauwPictureBox.Name = "blauwPictureBox";
            blauwPictureBox.Size = new Size(257, 129);
            blauwPictureBox.TabIndex = 1;
            blauwPictureBox.TabStop = false;
            blauwPictureBox.Click += blauwPictureBox_Click;
            // 
            // geelPictureBox
            // 
            geelPictureBox.BackColor = Color.Yellow;
            geelPictureBox.Location = new Point(24, 263);
            geelPictureBox.Name = "geelPictureBox";
            geelPictureBox.Size = new Size(257, 131);
            geelPictureBox.TabIndex = 3;
            geelPictureBox.TabStop = false;
            geelPictureBox.Click += geelPictureBox_Click;
            // 
            // roodPictureBox
            // 
            roodPictureBox.BackColor = Color.Red;
            roodPictureBox.Location = new Point(24, 23);
            roodPictureBox.Name = "roodPictureBox";
            roodPictureBox.Size = new Size(257, 131);
            roodPictureBox.TabIndex = 4;
            roodPictureBox.TabStop = false;
            roodPictureBox.Click += roodPictureBox_Click;
            // 
            // button1
            // 
            button1.Location = new Point(329, 190);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // highScoreLabel
            // 
            highScoreLabel.AutoSize = true;
            highScoreLabel.Location = new Point(326, 23);
            highScoreLabel.Margin = new Padding(2, 0, 2, 0);
            highScoreLabel.Name = "highScoreLabel";
            highScoreLabel.Size = new Size(102, 20);
            highScoreLabel.TabIndex = 6;
            highScoreLabel.Text = "Top score hier";
            highScoreLabel.Click += highScoreLabel_Click;
            // 
            // thirdScoreLabel
            // 
            thirdScoreLabel.AutoSize = true;
            thirdScoreLabel.Location = new Point(326, 92);
            thirdScoreLabel.Margin = new Padding(2, 0, 2, 0);
            thirdScoreLabel.Name = "thirdScoreLabel";
            thirdScoreLabel.Size = new Size(102, 20);
            thirdScoreLabel.TabIndex = 7;
            thirdScoreLabel.Text = "Top score hier";
            // 
            // secondScoreLabel
            // 
            secondScoreLabel.AutoSize = true;
            secondScoreLabel.Location = new Point(326, 58);
            secondScoreLabel.Margin = new Padding(2, 0, 2, 0);
            secondScoreLabel.Name = "secondScoreLabel";
            secondScoreLabel.Size = new Size(102, 20);
            secondScoreLabel.TabIndex = 8;
            secondScoreLabel.Text = "Top score hier";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(secondScoreLabel);
            Controls.Add(thirdScoreLabel);
            Controls.Add(highScoreLabel);
            Controls.Add(button1);
            Controls.Add(roodPictureBox);
            Controls.Add(geelPictureBox);
            Controls.Add(blauwPictureBox);
            Controls.Add(groenPictureBox);
            Name = "Form1";
            Text = "Nummer 1 speler komt hier";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)groenPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)blauwPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)geelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)roodPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private PictureBox groenPictureBox;
        private PictureBox blauwPictureBox;
        private PictureBox geelPictureBox;
        private PictureBox roodPictureBox;
        private Button button1;
        private Label highScoreLabel;
        private Label thirdScoreLabel;
        private Label secondScoreLabel;
    }
}
