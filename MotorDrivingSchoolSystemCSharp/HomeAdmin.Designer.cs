namespace MotorDrivingSchoolSystemCSharp
{
    partial class HomeAdmin
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
            this.AddTutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AssignTutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewTutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTutorToolStripMenuItem,
            this.AddStudentToolStripMenuItem,
            this.AssignTutorToolStripMenuItem,
            this.ViewStudentToolStripMenuItem,
            this.ViewTutorToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(824, 28);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // AddTutorToolStripMenuItem
            // 
            this.AddTutorToolStripMenuItem.Name = "AddTutorToolStripMenuItem";
            this.AddTutorToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.AddTutorToolStripMenuItem.Text = "Add Tutor";
            this.AddTutorToolStripMenuItem.Click += new System.EventHandler(this.AddTutorToolStripMenuItem_Click);
            // 
            // AddStudentToolStripMenuItem
            // 
            this.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem";
            this.AddStudentToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.AddStudentToolStripMenuItem.Text = "Add Student";
            this.AddStudentToolStripMenuItem.Click += new System.EventHandler(this.AddStudentToolStripMenuItem_Click);
            // 
            // AssignTutorToolStripMenuItem
            // 
            this.AssignTutorToolStripMenuItem.Name = "AssignTutorToolStripMenuItem";
            this.AssignTutorToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.AssignTutorToolStripMenuItem.Text = "Assign Tutor";
            this.AssignTutorToolStripMenuItem.Click += new System.EventHandler(this.AssignTutorToolStripMenuItem_Click);
            // 
            // ViewStudentToolStripMenuItem
            // 
            this.ViewStudentToolStripMenuItem.Name = "ViewStudentToolStripMenuItem";
            this.ViewStudentToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.ViewStudentToolStripMenuItem.Text = "View Student";
            this.ViewStudentToolStripMenuItem.Click += new System.EventHandler(this.ViewStudentToolStripMenuItem_Click);
            // 
            // ViewTutorToolStripMenuItem
            // 
            this.ViewTutorToolStripMenuItem.Name = "ViewTutorToolStripMenuItem";
            this.ViewTutorToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.ViewTutorToolStripMenuItem.Text = "View Tutor";
            this.ViewTutorToolStripMenuItem.Click += new System.EventHandler(this.ViewTutorToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::MotorDrivingSchoolSystemCSharp.Properties.Resources.pngtree_clean_city_driving_school_background_design_picture_image_915449;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 564);
            this.Controls.Add(this.MenuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem AddTutorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AddStudentToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AssignTutorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewStudentToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewTutorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}