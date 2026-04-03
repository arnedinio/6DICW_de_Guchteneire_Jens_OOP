namespace Presentation
{
    partial class CocktailInfoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.kostprijsTextBox = new System.Windows.Forms.TextBox();
            this.ingredientenListBox = new System.Windows.Forms.ListBox();
            this.toonButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inhoudTextBox = new System.Windows.Forms.TextBox();
            this.alcoholpercentageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pittigerButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "kostprijs";
            // 
            // naamTextBox
            // 
            this.naamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naamTextBox.Location = new System.Drawing.Point(29, 9);
            this.naamTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(286, 39);
            this.naamTextBox.TabIndex = 1;
            // 
            // kostprijsTextBox
            // 
            this.kostprijsTextBox.Location = new System.Drawing.Point(207, 76);
            this.kostprijsTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kostprijsTextBox.Name = "kostprijsTextBox";
            this.kostprijsTextBox.Size = new System.Drawing.Size(108, 29);
            this.kostprijsTextBox.TabIndex = 2;
            // 
            // ingredientenListBox
            // 
            this.ingredientenListBox.FormattingEnabled = true;
            this.ingredientenListBox.ItemHeight = 24;
            this.ingredientenListBox.Location = new System.Drawing.Point(387, 7);
            this.ingredientenListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ingredientenListBox.Name = "ingredientenListBox";
            this.ingredientenListBox.Size = new System.Drawing.Size(283, 148);
            this.ingredientenListBox.TabIndex = 5;
            // 
            // toonButton
            // 
            this.toonButton.Location = new System.Drawing.Point(387, 172);
            this.toonButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toonButton.Name = "toonButton";
            this.toonButton.Size = new System.Drawing.Size(286, 44);
            this.toonButton.TabIndex = 0;
            this.toonButton.Text = "Toon ingredient";
            this.toonButton.UseVisualStyleBackColor = true;
            this.toonButton.Click += new System.EventHandler(this.toonButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "inhoud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "alcoholpercentage";
            // 
            // inhoudTextBox
            // 
            this.inhoudTextBox.Location = new System.Drawing.Point(207, 124);
            this.inhoudTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inhoudTextBox.Name = "inhoudTextBox";
            this.inhoudTextBox.Size = new System.Drawing.Size(72, 29);
            this.inhoudTextBox.TabIndex = 3;
            // 
            // alcoholpercentageTextBox
            // 
            this.alcoholpercentageTextBox.Location = new System.Drawing.Point(207, 172);
            this.alcoholpercentageTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.alcoholpercentageTextBox.Name = "alcoholpercentageTextBox";
            this.alcoholpercentageTextBox.Size = new System.Drawing.Size(72, 29);
            this.alcoholpercentageTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "ml";
            // 
            // pittigerButton
            // 
            this.pittigerButton.Location = new System.Drawing.Point(22, 251);
            this.pittigerButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pittigerButton.Name = "pittigerButton";
            this.pittigerButton.Size = new System.Drawing.Size(987, 44);
            this.pittigerButton.TabIndex = 6;
            this.pittigerButton.Text = "Maak cocktail pittiger";
            this.pittigerButton.UseVisualStyleBackColor = true;
            this.pittigerButton.Click += new System.EventHandler(this.pittigerButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(726, 9);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 148);
            this.listBox1.TabIndex = 7;
            //this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Toon ingredient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CocktailInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pittigerButton);
            this.Controls.Add(this.alcoholpercentageTextBox);
            this.Controls.Add(this.inhoudTextBox);
            this.Controls.Add(this.toonButton);
            this.Controls.Add(this.ingredientenListBox);
            this.Controls.Add(this.kostprijsTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CocktailInfoForm";
            this.Text = "CocktailInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox kostprijsTextBox;
        private System.Windows.Forms.ListBox ingredientenListBox;
        private System.Windows.Forms.Button toonButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inhoudTextBox;
        private System.Windows.Forms.TextBox alcoholpercentageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pittigerButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}