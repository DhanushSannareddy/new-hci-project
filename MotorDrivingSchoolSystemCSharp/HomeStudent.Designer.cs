namespace MotorDrivingSchoolSystemCSharp
{
    partial class HomeStudent
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UpdateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewAssignedTutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateStudentToolStripMenuItem,
            this.ViewAssignedTutorToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(747, 28);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // UpdateStudentToolStripMenuItem
            // 
            this.UpdateStudentToolStripMenuItem.Name = "UpdateStudentToolStripMenuItem";
            this.UpdateStudentToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.UpdateStudentToolStripMenuItem.Text = "Update Student";
            this.UpdateStudentToolStripMenuItem.Click += new System.EventHandler(this.UpdateStudentToolStripMenuItem_Click);
            // 
            // ViewAssignedTutorToolStripMenuItem
            // 
            this.ViewAssignedTutorToolStripMenuItem.Name = "ViewAssignedTutorToolStripMenuItem";
            this.ViewAssignedTutorToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.ViewAssignedTutorToolStripMenuItem.Text = "View Assigned Tutor";
            this.ViewAssignedTutorToolStripMenuItem.Click += new System.EventHandler(this.ViewAssignedTutorToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HomeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotorDrivingSchoolSystemCSharp.Properties.Resources.login_form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(747, 556);
            this.Controls.Add(this.MenuStrip1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeStudent";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem UpdateStudentToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewAssignedTutorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}