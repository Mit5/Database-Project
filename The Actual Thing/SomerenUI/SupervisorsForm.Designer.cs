
namespace SomerenUI
{
    partial class SupervisorsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_btton = new System.Windows.Forms.Button();
            this.Remove_btton = new System.Windows.Forms.Button();
            this.Activities_lstview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotSupervisors_lstView = new System.Windows.Forms.ListView();
            this.Supervisors_lstView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Last = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Activities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Supervisors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Non-Supervisors";
            // 
            // Add_btton
            // 
            this.Add_btton.Location = new System.Drawing.Point(676, 498);
            this.Add_btton.Name = "Add_btton";
            this.Add_btton.Size = new System.Drawing.Size(137, 37);
            this.Add_btton.TabIndex = 12;
            this.Add_btton.Text = "Add";
            this.Add_btton.UseVisualStyleBackColor = true;
            this.Add_btton.Click += new System.EventHandler(this.Add_btton_Click);
            // 
            // Remove_btton
            // 
            this.Remove_btton.Location = new System.Drawing.Point(175, 498);
            this.Remove_btton.Name = "Remove_btton";
            this.Remove_btton.Size = new System.Drawing.Size(123, 37);
            this.Remove_btton.TabIndex = 11;
            this.Remove_btton.Text = "Remove";
            this.Remove_btton.UseVisualStyleBackColor = true;
            this.Remove_btton.Click += new System.EventHandler(this.Remove_btton_Click);
            // 
            // Activities_lstview
            // 
            this.Activities_lstview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Activities_lstview.HideSelection = false;
            this.Activities_lstview.Location = new System.Drawing.Point(187, 46);
            this.Activities_lstview.MultiSelect = false;
            this.Activities_lstview.Name = "Activities_lstview";
            this.Activities_lstview.Size = new System.Drawing.Size(596, 170);
            this.Activities_lstview.TabIndex = 10;
            this.Activities_lstview.UseCompatibleStateImageBehavior = false;
            this.Activities_lstview.View = System.Windows.Forms.View.Details;
            this.Activities_lstview.SelectedIndexChanged += new System.EventHandler(this.Activities_lstview_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Start";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "End";
            this.columnHeader4.Width = 150;
            // 
            // NotSupervisors_lstView
            // 
            this.NotSupervisors_lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.NotSupervisors_lstView.HideSelection = false;
            this.NotSupervisors_lstView.Location = new System.Drawing.Point(516, 280);
            this.NotSupervisors_lstView.MultiSelect = false;
            this.NotSupervisors_lstView.Name = "NotSupervisors_lstView";
            this.NotSupervisors_lstView.Size = new System.Drawing.Size(449, 183);
            this.NotSupervisors_lstView.TabIndex = 9;
            this.NotSupervisors_lstView.UseCompatibleStateImageBehavior = false;
            this.NotSupervisors_lstView.View = System.Windows.Forms.View.Details;
            this.NotSupervisors_lstView.SelectedIndexChanged += new System.EventHandler(this.NotSupervisors_lstView_SelectedIndexChanged);
            // 
            // Supervisors_lstView
            // 
            this.Supervisors_lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader,
            this.Last});
            this.Supervisors_lstView.HideSelection = false;
            this.Supervisors_lstView.Location = new System.Drawing.Point(49, 280);
            this.Supervisors_lstView.MultiSelect = false;
            this.Supervisors_lstView.Name = "Supervisors_lstView";
            this.Supervisors_lstView.Size = new System.Drawing.Size(427, 183);
            this.Supervisors_lstView.TabIndex = 8;
            this.Supervisors_lstView.UseCompatibleStateImageBehavior = false;
            this.Supervisors_lstView.View = System.Windows.Forms.View.Details;
            this.Supervisors_lstView.SelectedIndexChanged += new System.EventHandler(this.Supervisors_lstView_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 70;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Name";
            this.columnHeader.Width = 100;
            // 
            // Last
            // 
            this.Last.Text = "Last Name";
            this.Last.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Last Name";
            this.columnHeader7.Width = 100;
            // 
            // SupervisorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_btton);
            this.Controls.Add(this.Remove_btton);
            this.Controls.Add(this.Activities_lstview);
            this.Controls.Add(this.NotSupervisors_lstView);
            this.Controls.Add(this.Supervisors_lstView);
            this.Name = "SupervisorsForm";
            this.Text = "SupervisorsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_btton;
        private System.Windows.Forms.Button Remove_btton;
        private System.Windows.Forms.ListView Activities_lstview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView NotSupervisors_lstView;
        private System.Windows.Forms.ListView Supervisors_lstView;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader Last;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}