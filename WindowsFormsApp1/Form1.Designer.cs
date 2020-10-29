namespace WindowsFormsApp1
{
    partial class UniversityAppPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniversityAppPanel));
            this.studentButtonLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentBtn = new WindowsFormsApp1.RoundButton();
            this.ProfBtn = new WindowsFormsApp1.RoundButton();
            this.SuspendLayout();
            // 
            // studentButtonLabel
            // 
            this.studentButtonLabel.AutoSize = true;
            this.studentButtonLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentButtonLabel.Location = new System.Drawing.Point(198, 206);
            this.studentButtonLabel.Name = "studentButtonLabel";
            this.studentButtonLabel.Size = new System.Drawing.Size(52, 17);
            this.studentButtonLabel.TabIndex = 3;
            this.studentButtonLabel.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teacher";
            // 
            // StudentBtn
            // 
            this.StudentBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StudentBtn.BackgroundImage")));
            this.StudentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StudentBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.StudentBtn.Location = new System.Drawing.Point(189, 143);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.Size = new System.Drawing.Size(69, 60);
            this.StudentBtn.TabIndex = 5;
            this.StudentBtn.UseVisualStyleBackColor = true;
            this.StudentBtn.Click += new System.EventHandler(this.StudentBtn_Click);
            // 
            // ProfBtn
            // 
            this.ProfBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfBtn.BackgroundImage")));
            this.ProfBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfBtn.Location = new System.Drawing.Point(545, 143);
            this.ProfBtn.Name = "ProfBtn";
            this.ProfBtn.Size = new System.Drawing.Size(66, 60);
            this.ProfBtn.TabIndex = 6;
            this.ProfBtn.UseVisualStyleBackColor = true;
            this.ProfBtn.Click += new System.EventHandler(this.ProfBtn_Click);
            // 
            // UniversityAppPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProfBtn);
            this.Controls.Add(this.StudentBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentButtonLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "UniversityAppPanel";
            this.Text = "UniversityApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Label studentButtonLabel;
        private System.Windows.Forms.Label label2;
        private RoundButton StudentBtn;
        private RoundButton ProfBtn;
    }
}

