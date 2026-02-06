namespace Aftelklok
{
    partial class AftelklokForm
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
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.opnieuwOpStarttijd = new System.Windows.Forms.Button();
            this.aftelklokTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.Color.Black;
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.ForeColor = System.Drawing.Color.Lime;
            this.displayTextBox.Location = new System.Drawing.Point(36, 50);
            this.displayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(169, 60);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // opnieuwOpStarttijd
            // 
            this.opnieuwOpStarttijd.Location = new System.Drawing.Point(36, 15);
            this.opnieuwOpStarttijd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opnieuwOpStarttijd.Name = "opnieuwOpStarttijd";
            this.opnieuwOpStarttijd.Size = new System.Drawing.Size(171, 28);
            this.opnieuwOpStarttijd.TabIndex = 1;
            this.opnieuwOpStarttijd.Text = "Op starttijd";
            this.opnieuwOpStarttijd.UseVisualStyleBackColor = true;
            this.opnieuwOpStarttijd.Click += new System.EventHandler(this.opnieuwOpStarttijd_Click);
            // 
            // aftelklokTimer
            // 
            this.aftelklokTimer.Enabled = true;
            this.aftelklokTimer.Interval = 1000;
            this.aftelklokTimer.Tick += new System.EventHandler(this.aftelklokTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AftelklokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 197);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.opnieuwOpStarttijd);
            this.Controls.Add(this.displayTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AftelklokForm";
            this.Text = "Aftelklok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button opnieuwOpStarttijd;
        private System.Windows.Forms.Timer aftelklokTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

