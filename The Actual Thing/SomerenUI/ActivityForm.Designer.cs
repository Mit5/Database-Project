namespace SomerenUI
{
    partial class ActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            this.pnlActivities = new System.Windows.Forms.Panel();
            this.buttonDeleteActivities = new System.Windows.Forms.Button();
            this.buttonEditActivities = new System.Windows.Forms.Button();
            this.buttonAddActivities = new System.Windows.Forms.Button();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.Activity_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Activity_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Activity_StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Activity_EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlActivities
            // 
            this.pnlActivities.Controls.Add(this.buttonDeleteActivities);
            this.pnlActivities.Controls.Add(this.buttonEditActivities);
            this.pnlActivities.Controls.Add(this.buttonAddActivities);
            this.pnlActivities.Controls.Add(this.listViewActivities);
            this.pnlActivities.Controls.Add(this.pictureBox3);
            this.pnlActivities.Controls.Add(this.label1);
            this.pnlActivities.Location = new System.Drawing.Point(12, 12);
            this.pnlActivities.Name = "pnlActivities";
            this.pnlActivities.Size = new System.Drawing.Size(981, 466);
            this.pnlActivities.TabIndex = 10;
            // 
            // buttonDeleteActivities
            // 
            this.buttonDeleteActivities.Location = new System.Drawing.Point(164, 369);
            this.buttonDeleteActivities.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteActivities.Name = "buttonDeleteActivities";
            this.buttonDeleteActivities.Size = new System.Drawing.Size(70, 25);
            this.buttonDeleteActivities.TabIndex = 8;
            this.buttonDeleteActivities.Text = "Delete";
            this.buttonDeleteActivities.UseVisualStyleBackColor = true;
            this.buttonDeleteActivities.Click += new System.EventHandler(this.buttonDeleteActivities_Click);
            // 
            // buttonEditActivities
            // 
            this.buttonEditActivities.Location = new System.Drawing.Point(90, 369);
            this.buttonEditActivities.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditActivities.Name = "buttonEditActivities";
            this.buttonEditActivities.Size = new System.Drawing.Size(70, 25);
            this.buttonEditActivities.TabIndex = 7;
            this.buttonEditActivities.Text = "Edit";
            this.buttonEditActivities.UseVisualStyleBackColor = true;
            this.buttonEditActivities.Click += new System.EventHandler(this.buttonEditActivities_Click);
            // 
            // buttonAddActivities
            // 
            this.buttonAddActivities.Location = new System.Drawing.Point(16, 369);
            this.buttonAddActivities.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddActivities.Name = "buttonAddActivities";
            this.buttonAddActivities.Size = new System.Drawing.Size(70, 25);
            this.buttonAddActivities.TabIndex = 6;
            this.buttonAddActivities.Text = "Add";
            this.buttonAddActivities.UseVisualStyleBackColor = true;
            this.buttonAddActivities.Click += new System.EventHandler(this.buttonAddActivities_Click);
            // 
            // listViewActivities
            // 
            this.listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Activity_ID,
            this.Activity_Description,
            this.Activity_StartDate,
            this.Activity_EndDate});
            this.listViewActivities.FullRowSelect = true;
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(16, 42);
            this.listViewActivities.MultiSelect = false;
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(779, 307);
            this.listViewActivities.TabIndex = 5;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // Activity_ID
            // 
            this.Activity_ID.Text = "ID";
            this.Activity_ID.Width = 0;
            // 
            // Activity_Description
            // 
            this.Activity_Description.Text = "Description";
            this.Activity_Description.Width = 300;
            // 
            // Activity_StartDate
            // 
            this.Activity_StartDate.Text = "Start Time";
            this.Activity_StartDate.Width = 150;
            // 
            // Activity_EndDate
            // 
            this.Activity_EndDate.Text = "End Time";
            this.Activity_EndDate.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activites";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(829, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 123);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 497);
            this.Controls.Add(this.pnlActivities);
            this.Name = "ActivityForm";
            this.Text = "ActivityForm";
            this.pnlActivities.ResumeLayout(false);
            this.pnlActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Button buttonDeleteActivities;
        private System.Windows.Forms.Button buttonEditActivities;
        private System.Windows.Forms.Button buttonAddActivities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ColumnHeader Activity_ID;
        private System.Windows.Forms.ColumnHeader Activity_Description;
        private System.Windows.Forms.ColumnHeader Activity_StartDate;
        private System.Windows.Forms.ColumnHeader Activity_EndDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}