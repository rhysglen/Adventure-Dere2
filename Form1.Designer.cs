namespace Adventure_Dere
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.question2Label = new System.Windows.Forms.Label();
            this.question3Label = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.mLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.photoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleLabel.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(335, 76);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Adventure-Dere";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputLabel.Location = new System.Drawing.Point(12, 85);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(336, 145);
            this.outputLabel.TabIndex = 1;
            // 
            // questionLabel
            // 
            this.questionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.questionLabel.Location = new System.Drawing.Point(66, 263);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(352, 50);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // question2Label
            // 
            this.question2Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.question2Label.Location = new System.Drawing.Point(66, 348);
            this.question2Label.Name = "question2Label";
            this.question2Label.Size = new System.Drawing.Size(352, 50);
            this.question2Label.TabIndex = 3;
            this.question2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // question3Label
            // 
            this.question3Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.question3Label.Location = new System.Drawing.Point(66, 433);
            this.question3Label.Name = "question3Label";
            this.question3Label.Size = new System.Drawing.Size(352, 50);
            this.question3Label.TabIndex = 4;
            this.question3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.LightCoral;
            this.beginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.beginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginButton.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.Location = new System.Drawing.Point(128, 85);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(93, 43);
            this.beginButton.TabIndex = 5;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mLabel
            // 
            this.mLabel.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.mLabel.Location = new System.Drawing.Point(19, 251);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(41, 50);
            this.mLabel.TabIndex = 8;
            this.mLabel.Text = "M";
            this.mLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bLabel
            // 
            this.bLabel.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.bLabel.Location = new System.Drawing.Point(19, 345);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(41, 50);
            this.bLabel.TabIndex = 9;
            this.bLabel.Text = "B";
            this.bLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nLabel
            // 
            this.nLabel.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLabel.ForeColor = System.Drawing.Color.Gold;
            this.nLabel.Location = new System.Drawing.Point(19, 433);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(41, 50);
            this.nLabel.TabIndex = 10;
            this.nLabel.Text = "N";
            this.nLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // photoBox
            // 
            this.photoBox.Location = new System.Drawing.Point(378, -2);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(368, 502);
            this.photoBox.TabIndex = 7;
            this.photoBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(738, 495);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.photoBox);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.question3Label);
            this.Controls.Add(this.question2Label);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adventure-Dere";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label question2Label;
        private System.Windows.Forms.Label question3Label;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label nLabel;
    }
}

