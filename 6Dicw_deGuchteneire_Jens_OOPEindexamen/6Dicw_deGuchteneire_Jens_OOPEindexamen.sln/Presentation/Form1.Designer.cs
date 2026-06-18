namespace Presentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            vlootButton = new Button();
            personagesButton = new Button();
            planetenButton = new Button();
            vlootDataGridView = new DataGridView();
            planetenDataGridView = new DataGridView();
            personagesDataGridView = new DataGridView();
            herlaadButton = new Button();
            detectorButton = new Button();
            label = new Label();
            exterminateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)vlootDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planetenDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personagesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // vlootButton
            // 
            vlootButton.Location = new Point(12, 240);
            vlootButton.Name = "vlootButton";
            vlootButton.Size = new Size(245, 67);
            vlootButton.TabIndex = 0;
            vlootButton.Text = "Laad Vloot";
            vlootButton.UseVisualStyleBackColor = true;
            vlootButton.Click += vlootButton_Click;
            // 
            // personagesButton
            // 
            personagesButton.Location = new Point(12, 167);
            personagesButton.Name = "personagesButton";
            personagesButton.Size = new Size(245, 67);
            personagesButton.TabIndex = 1;
            personagesButton.Text = "Laad Personages";
            personagesButton.UseVisualStyleBackColor = true;
            personagesButton.Click += personagesButton_Click;
            // 
            // planetenButton
            // 
            planetenButton.Location = new Point(12, 313);
            planetenButton.Name = "planetenButton";
            planetenButton.Size = new Size(245, 67);
            planetenButton.TabIndex = 2;
            planetenButton.Text = "Laad Planeten";
            planetenButton.UseVisualStyleBackColor = true;
            planetenButton.Click += planetenButton_Click;
            // 
            // vlootDataGridView
            // 
            vlootDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vlootDataGridView.Location = new Point(12, 641);
            vlootDataGridView.Name = "vlootDataGridView";
            vlootDataGridView.RowHeadersWidth = 72;
            vlootDataGridView.Size = new Size(696, 234);
            vlootDataGridView.TabIndex = 3;
            // 
            // planetenDataGridView
            // 
            planetenDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planetenDataGridView.Location = new Point(12, 401);
            planetenDataGridView.Name = "planetenDataGridView";
            planetenDataGridView.RowHeadersWidth = 72;
            planetenDataGridView.Size = new Size(696, 234);
            planetenDataGridView.TabIndex = 4;
            // 
            // personagesDataGridView
            // 
            personagesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personagesDataGridView.Location = new Point(1049, 294);
            personagesDataGridView.Name = "personagesDataGridView";
            personagesDataGridView.RowHeadersWidth = 72;
            personagesDataGridView.Size = new Size(546, 581);
            personagesDataGridView.TabIndex = 5;
            // 
            // herlaadButton
            // 
            herlaadButton.Location = new Point(12, 94);
            herlaadButton.Name = "herlaadButton";
            herlaadButton.Size = new Size(245, 67);
            herlaadButton.TabIndex = 6;
            herlaadButton.Text = "Herlaad Data";
            herlaadButton.UseVisualStyleBackColor = true;
            herlaadButton.Click += herlaadButton_Click;
            // 
            // detectorButton
            // 
            detectorButton.Location = new Point(12, 21);
            detectorButton.Name = "detectorButton";
            detectorButton.Size = new Size(245, 67);
            detectorButton.TabIndex = 7;
            detectorButton.Text = "Detect Cylon";
            detectorButton.UseVisualStyleBackColor = true;
            detectorButton.Click += detectorButton_Click;
            // 
            // label
            // 
            label.BackColor = Color.Transparent;
            label.Font = new Font("Niagara Engraved", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.Snow;
            label.Location = new Point(389, 36);
            label.Name = "label";
            label.Size = new Size(712, 138);
            label.TabIndex = 9;
            label.Text = "Cylon Detector Test";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exterminateButton
            // 
            exterminateButton.Location = new Point(607, 221);
            exterminateButton.Name = "exterminateButton";
            exterminateButton.Size = new Size(245, 67);
            exterminateButton.TabIndex = 10;
            exterminateButton.Text = "Exterminate Cylon";
            exterminateButton.UseVisualStyleBackColor = true;
            exterminateButton.Click += exterminateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1607, 887);
            Controls.Add(exterminateButton);
            Controls.Add(label);
            Controls.Add(detectorButton);
            Controls.Add(herlaadButton);
            Controls.Add(personagesDataGridView);
            Controls.Add(planetenDataGridView);
            Controls.Add(vlootDataGridView);
            Controls.Add(planetenButton);
            Controls.Add(personagesButton);
            Controls.Add(vlootButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)vlootDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)planetenDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)personagesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button vlootButton;
        private Button personagesButton;
        private Button planetenButton;
        private DataGridView vlootDataGridView;
        private DataGridView planetenDataGridView;
        private DataGridView personagesDataGridView;
        private Button herlaadButton;
        private Button detectorButton;
        private Label label;
        private Button exterminateButton;
    }
}
