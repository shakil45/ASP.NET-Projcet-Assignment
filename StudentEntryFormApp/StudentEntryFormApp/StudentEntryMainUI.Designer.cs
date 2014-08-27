namespace StudentEntryFormApp
{
    partial class studentEntryMainWindow
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
            this.departmentEntryButton = new System.Windows.Forms.Button();
            this.studententryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departmentEntryButton
            // 
            this.departmentEntryButton.Location = new System.Drawing.Point(62, 66);
            this.departmentEntryButton.Name = "departmentEntryButton";
            this.departmentEntryButton.Size = new System.Drawing.Size(181, 55);
            this.departmentEntryButton.TabIndex = 0;
            this.departmentEntryButton.Text = "Department Entry";
            this.departmentEntryButton.UseVisualStyleBackColor = true;
            this.departmentEntryButton.Click += new System.EventHandler(this.departmentEntryButton_Click);
            // 
            // studententryButton
            // 
            this.studententryButton.Location = new System.Drawing.Point(62, 150);
            this.studententryButton.Name = "studententryButton";
            this.studententryButton.Size = new System.Drawing.Size(181, 52);
            this.studententryButton.TabIndex = 1;
            this.studententryButton.Text = "Student Entry";
            this.studententryButton.UseVisualStyleBackColor = true;
            // 
            // studentEntryMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 261);
            this.Controls.Add(this.studententryButton);
            this.Controls.Add(this.departmentEntryButton);
            this.Name = "studentEntryMainWindow";
            this.Text = "StudentEntryMainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button departmentEntryButton;
        private System.Windows.Forms.Button studententryButton;
    }
}