
namespace SomerenUI
{
    partial class LecturersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturersForm));
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.Lecturer_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lecturer_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lecturer_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Teacher_Supervisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Controls.Add(this.listViewTeachers);
            this.pnlTeachers.Controls.Add(this.pictureBox3);
            this.pnlTeachers.Controls.Add(this.label1);
            this.pnlTeachers.Location = new System.Drawing.Point(9, 5);
            this.pnlTeachers.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(1251, 574);
            this.pnlTeachers.TabIndex = 8;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lecturer_ID,
            this.Lecturer_Name,
            this.Lecturer_LastName,
            this.Teacher_Supervisor});
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(21, 52);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(4);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(1020, 377);
            this.listViewTeachers.TabIndex = 5;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
            // 
            // Lecturer_ID
            // 
            this.Lecturer_ID.Text = "ID";
            // 
            // Lecturer_Name
            // 
            this.Lecturer_Name.Text = "Name";
            this.Lecturer_Name.Width = 150;
            // 
            // Lecturer_LastName
            // 
            this.Lecturer_LastName.Text = "Last Name";
            this.Lecturer_LastName.Width = 150;
            // 
            // Teacher_Supervisor
            // 
            this.Teacher_Supervisor.Text = "Supervisor";
            this.Teacher_Supervisor.Width = 150;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(1058, 21);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 151);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lecturers";
            // 
            // LecturersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 585);
            this.Controls.Add(this.pnlTeachers);
            this.Name = "LecturersForm";
            this.Text = "LecturersForm";
            this.pnlTeachers.ResumeLayout(false);
            this.pnlTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader Lecturer_ID;
        private System.Windows.Forms.ColumnHeader Lecturer_Name;
        private System.Windows.Forms.ColumnHeader Lecturer_LastName;
        private System.Windows.Forms.ColumnHeader Teacher_Supervisor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}