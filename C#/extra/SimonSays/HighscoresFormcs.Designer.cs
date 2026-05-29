namespace SimonSays
{
    partial class HighscoresFormcs
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
            dataGridView1 = new DataGridView();
            cheaterButton = new Button();
            nameChangeButton = new Button();
            textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(368, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(420, 393);
            dataGridView1.TabIndex = 0;
            // 
            // cheaterButton
            // 
            cheaterButton.Location = new Point(12, 23);
            cheaterButton.Name = "cheaterButton";
            cheaterButton.Size = new Size(164, 40);
            cheaterButton.TabIndex = 1;
            cheaterButton.Text = "Cheater deleter";
            cheaterButton.UseVisualStyleBackColor = true;
            // 
            // nameChangeButton
            // 
            nameChangeButton.Location = new Point(182, 23);
            nameChangeButton.Name = "nameChangeButton";
            nameChangeButton.Size = new Size(164, 40);
            nameChangeButton.TabIndex = 2;
            nameChangeButton.Text = "Name changer";
            nameChangeButton.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 101);
            textBox.Name = "textBox";
            textBox.Size = new Size(334, 35);
            textBox.TabIndex = 3;
            // 
            // HighscoresFormcs
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox);
            Controls.Add(nameChangeButton);
            Controls.Add(cheaterButton);
            Controls.Add(dataGridView1);
            Name = "HighscoresFormcs";
            Text = "HighscoresFormcs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button cheaterButton;
        private Button nameChangeButton;
        private TextBox textBox;
    }
}