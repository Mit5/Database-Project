namespace SomerenUI
{
    partial class ParticipantsForm
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
            this.Activities_lstView = new System.Windows.Forms.ListView();
            this.Participants_lstView = new System.Windows.Forms.ListView();
            this.NotParticipants_lstView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Remove_btton = new System.Windows.Forms.Button();
            this.Add_btton = new System.Windows.Forms.Button();
            this.ActivityID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Discription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParticipantsId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParticipantsFirst_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParticipantsLast_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NonParticipantsFirst_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NonParticipantsLast_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Activities_lstView
            // 
            this.Activities_lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActivityID,
            this.Discription,
            this.Start_Date,
            this.End_Date});
            this.Activities_lstView.HideSelection = false;
            this.Activities_lstView.Location = new System.Drawing.Point(100, 44);
            this.Activities_lstView.Name = "Activities_lstView";
            this.Activities_lstView.Size = new System.Drawing.Size(566, 159);
            this.Activities_lstView.TabIndex = 0;
            this.Activities_lstView.UseCompatibleStateImageBehavior = false;
            this.Activities_lstView.View = System.Windows.Forms.View.Details;
            this.Activities_lstView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Participants_lstView
            // 
            this.Participants_lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParticipantsId,
            this.ParticipantsFirst_Name,
            this.ParticipantsLast_Name});
            this.Participants_lstView.HideSelection = false;
            this.Participants_lstView.Location = new System.Drawing.Point(12, 231);
            this.Participants_lstView.Name = "Participants_lstView";
            this.Participants_lstView.Size = new System.Drawing.Size(309, 156);
            this.Participants_lstView.TabIndex = 1;
            this.Participants_lstView.UseCompatibleStateImageBehavior = false;
            this.Participants_lstView.View = System.Windows.Forms.View.Details;
            this.Participants_lstView.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // NotParticipants_lstView
            // 
            this.NotParticipants_lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Student_Id,
            this.NonParticipantsFirst_Name,
            this.NonParticipantsLast_Name});
            this.NotParticipants_lstView.HideSelection = false;
            this.NotParticipants_lstView.Location = new System.Drawing.Point(409, 231);
            this.NotParticipants_lstView.Name = "NotParticipants_lstView";
            this.NotParticipants_lstView.Size = new System.Drawing.Size(332, 156);
            this.NotParticipants_lstView.TabIndex = 2;
            this.NotParticipants_lstView.UseCompatibleStateImageBehavior = false;
            this.NotParticipants_lstView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Participants";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Non-Participants";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Remove_btton
            // 
            this.Remove_btton.Location = new System.Drawing.Point(100, 394);
            this.Remove_btton.Name = "Remove_btton";
            this.Remove_btton.Size = new System.Drawing.Size(83, 33);
            this.Remove_btton.TabIndex = 6;
            this.Remove_btton.Text = "Remove";
            this.Remove_btton.UseVisualStyleBackColor = true;
            // 
            // Add_btton
            // 
            this.Add_btton.Location = new System.Drawing.Point(481, 393);
            this.Add_btton.Name = "Add_btton";
            this.Add_btton.Size = new System.Drawing.Size(84, 34);
            this.Add_btton.TabIndex = 7;
            this.Add_btton.Text = "Add";
            this.Add_btton.UseVisualStyleBackColor = true;
            // 
            // ActivityID
            // 
            this.ActivityID.Text = "ID";
            // 
            // Discription
            // 
            this.Discription.Text = "Discription";
            this.Discription.Width = 124;
            // 
            // Start_Date
            // 
            this.Start_Date.Text = "Start Date";
            this.Start_Date.Width = 150;
            // 
            // End_Date
            // 
            this.End_Date.Text = "End Date";
            this.End_Date.Width = 166;
            // 
            // ParticipantsId
            // 
            this.ParticipantsId.Text = "Id";
            // 
            // ParticipantsFirst_Name
            // 
            this.ParticipantsFirst_Name.Text = "First Name";
            this.ParticipantsFirst_Name.Width = 90;
            // 
            // ParticipantsLast_Name
            // 
            this.ParticipantsLast_Name.Text = "Last Name";
            this.ParticipantsLast_Name.Width = 140;
            // 
            // Student_Id
            // 
            this.Student_Id.Text = "Id";
            this.Student_Id.Width = 129;
            // 
            // NonParticipantsFirst_Name
            // 
            this.NonParticipantsFirst_Name.Text = "First Name";
            this.NonParticipantsFirst_Name.Width = 100;
            // 
            // NonParticipantsLast_Name
            // 
            this.NonParticipantsLast_Name.Text = "Last Name";
            this.NonParticipantsLast_Name.Width = 90;
            // 
            // ParticipantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_btton);
            this.Controls.Add(this.Remove_btton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotParticipants_lstView);
            this.Controls.Add(this.Participants_lstView);
            this.Controls.Add(this.Activities_lstView);
            this.Name = "ParticipantsForm";
            this.Text = "ParticipantsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Activities_lstView;
        private System.Windows.Forms.ListView Participants_lstView;
        private System.Windows.Forms.ListView NotParticipants_lstView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Remove_btton;
        private System.Windows.Forms.Button Add_btton;
        private System.Windows.Forms.ColumnHeader ActivityID;
        private System.Windows.Forms.ColumnHeader Discription;
        private System.Windows.Forms.ColumnHeader Start_Date;
        private System.Windows.Forms.ColumnHeader End_Date;
        private System.Windows.Forms.ColumnHeader ParticipantsId;
        private System.Windows.Forms.ColumnHeader ParticipantsFirst_Name;
        private System.Windows.Forms.ColumnHeader ParticipantsLast_Name;
        private System.Windows.Forms.ColumnHeader Student_Id;
        private System.Windows.Forms.ColumnHeader NonParticipantsFirst_Name;
        private System.Windows.Forms.ColumnHeader NonParticipantsLast_Name;
    }
}