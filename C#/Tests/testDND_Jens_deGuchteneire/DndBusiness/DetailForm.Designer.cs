namespace DndBusiness
{
    partial class DetailForm
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
            this.naamInputLabel = new System.Windows.Forms.Label();
            this.sterkteInputLabel = new System.Windows.Forms.Label();
            this.sterkteLabel = new System.Windows.Forms.Label();
            this.naamLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naamInputLabel
            // 
            this.naamInputLabel.AutoSize = true;
            this.naamInputLabel.Location = new System.Drawing.Point(188, 47);
            this.naamInputLabel.Name = "naamInputLabel";
            this.naamInputLabel.Size = new System.Drawing.Size(55, 25);
            this.naamInputLabel.TabIndex = 0;
            this.naamInputLabel.Text = "temp";
            // 
            // sterkteInputLabel
            // 
            this.sterkteInputLabel.AutoSize = true;
            this.sterkteInputLabel.Location = new System.Drawing.Point(188, 125);
            this.sterkteInputLabel.Name = "sterkteInputLabel";
            this.sterkteInputLabel.Size = new System.Drawing.Size(55, 25);
            this.sterkteInputLabel.TabIndex = 1;
            this.sterkteInputLabel.Text = "temp";
            // 
            // sterkteLabel
            // 
            this.sterkteLabel.AutoSize = true;
            this.sterkteLabel.Location = new System.Drawing.Point(30, 125);
            this.sterkteLabel.Name = "sterkteLabel";
            this.sterkteLabel.Size = new System.Drawing.Size(55, 25);
            this.sterkteLabel.TabIndex = 2;
            this.sterkteLabel.Text = "temp";
            // 
            // naamLabel
            // 
            this.naamLabel.AutoSize = true;
            this.naamLabel.Location = new System.Drawing.Point(30, 47);
            this.naamLabel.Name = "naamLabel";
            this.naamLabel.Size = new System.Drawing.Size(55, 25);
            this.naamLabel.TabIndex = 3;
            this.naamLabel.Text = "temp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 245);
            this.Controls.Add(this.naamLabel);
            this.Controls.Add(this.sterkteLabel);
            this.Controls.Add(this.sterkteInputLabel);
            this.Controls.Add(this.naamInputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naamInputLabel;
        private System.Windows.Forms.Label sterkteInputLabel;
        private System.Windows.Forms.Label sterkteLabel;
        private System.Windows.Forms.Label naamLabel;
    }
}

