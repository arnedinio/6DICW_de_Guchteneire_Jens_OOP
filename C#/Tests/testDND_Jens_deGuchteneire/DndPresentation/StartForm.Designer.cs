namespace DndPresentation
{
    partial class StartForm
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
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.karakterComboBox = new System.Windows.Forms.ComboBox();
            this.sterkteTextBox = new System.Windows.Forms.TextBox();
            this.voegToeButton = new System.Windows.Forms.Button();
            this.toonHierButton = new System.Windows.Forms.Button();
            this.toonFormButton = new System.Windows.Forms.Button();
            this.toonHierLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(67, 41);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(142, 29);
            this.naamTextBox.TabIndex = 0;
            // 
            // karakterComboBox
            // 
            this.karakterComboBox.FormattingEnabled = true;
            this.karakterComboBox.Location = new System.Drawing.Point(197, 179);
            this.karakterComboBox.Name = "karakterComboBox";
            this.karakterComboBox.Size = new System.Drawing.Size(180, 32);
            this.karakterComboBox.TabIndex = 2;
            // 
            // sterkteTextBox
            // 
            this.sterkteTextBox.Location = new System.Drawing.Point(67, 118);
            this.sterkteTextBox.Name = "sterkteTextBox";
            this.sterkteTextBox.Size = new System.Drawing.Size(142, 29);
            this.sterkteTextBox.TabIndex = 4;
            // 
            // voegToeButton
            // 
            this.voegToeButton.Location = new System.Drawing.Point(301, 75);
            this.voegToeButton.Name = "voegToeButton";
            this.voegToeButton.Size = new System.Drawing.Size(150, 39);
            this.voegToeButton.TabIndex = 5;
            this.voegToeButton.Text = "...voeg toe";
            this.voegToeButton.UseVisualStyleBackColor = true;
            this.voegToeButton.Click += new System.EventHandler(this.voegToeButton_Click);
            // 
            // toonHierButton
            // 
            this.toonHierButton.Location = new System.Drawing.Point(207, 295);
            this.toonHierButton.Name = "toonHierButton";
            this.toonHierButton.Size = new System.Drawing.Size(152, 38);
            this.toonHierButton.TabIndex = 6;
            this.toonHierButton.Text = "toon hier";
            this.toonHierButton.UseVisualStyleBackColor = true;
            this.toonHierButton.Click += new System.EventHandler(this.toonHierButton_Click);
            // 
            // toonFormButton
            // 
            this.toonFormButton.Location = new System.Drawing.Point(207, 235);
            this.toonFormButton.Name = "toonFormButton";
            this.toonFormButton.Size = new System.Drawing.Size(152, 38);
            this.toonFormButton.TabIndex = 7;
            this.toonFormButton.Text = "toon form";
            this.toonFormButton.UseVisualStyleBackColor = true;
            this.toonFormButton.Click += new System.EventHandler(this.toonFormButton_Click);
            // 
            // toonHierLabel
            // 
            this.toonHierLabel.AutoSize = true;
            this.toonHierLabel.Location = new System.Drawing.Point(464, 290);
            this.toonHierLabel.Name = "toonHierLabel";
            this.toonHierLabel.Size = new System.Drawing.Size(0, 25);
            this.toonHierLabel.TabIndex = 8;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 355);
            this.Controls.Add(this.toonHierLabel);
            this.Controls.Add(this.toonFormButton);
            this.Controls.Add(this.toonHierButton);
            this.Controls.Add(this.voegToeButton);
            this.Controls.Add(this.sterkteTextBox);
            this.Controls.Add(this.karakterComboBox);
            this.Controls.Add(this.naamTextBox);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.ComboBox karakterComboBox;
        private System.Windows.Forms.TextBox sterkteTextBox;
        private System.Windows.Forms.Button voegToeButton;
        private System.Windows.Forms.Button toonHierButton;
        private System.Windows.Forms.Button toonFormButton;
        private System.Windows.Forms.Label toonHierLabel;
    }
}

