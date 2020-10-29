namespace WindowsFormsApp1
{
    partial class studentPage
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
            this.sdbLogDataSet1 = new WindowsFormsApp1.SDBLogDataSet();
            this.coursesDG = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdbLogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDG)).BeginInit();
            this.SuspendLayout();
            // 
            // sdbLogDataSet1
            // 
            this.sdbLogDataSet1.DataSetName = "SDBLogDataSet";
            this.sdbLogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesDG
            // 
            this.coursesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDG.Location = new System.Drawing.Point(25, 74);
            this.coursesDG.Name = "coursesDG";
            this.coursesDG.Size = new System.Drawing.Size(346, 193);
            this.coursesDG.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(545, 149);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(113, 48);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.seeCourseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!";
            // 
            // studentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.coursesDG);
            this.Name = "studentPage";
            this.Text = "Student Page";
            ((System.ComponentModel.ISupportInitialize)(this.sdbLogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SDBLogDataSet sdbLogDataSet1;
        private System.Windows.Forms.DataGridView coursesDG;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
    }
}