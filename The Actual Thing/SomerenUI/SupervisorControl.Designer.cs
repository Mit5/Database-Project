
namespace SomerenUI
{
    partial class SupervisorsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Supervisors_lstView = new System.Windows.Forms.ListView();
            this.NotSupervisors_lstView = new System.Windows.Forms.ListView();
            this.Activities_lstview = new System.Windows.Forms.ListView();
            this.Remove_btton = new System.Windows.Forms.Button();
            this.Add_btton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Supervisors_lstView
            // 
            this.Supervisors_lstView.HideSelection = false;
            this.Supervisors_lstView.Location = new System.Drawing.Point(41, 294);
            this.Supervisors_lstView.Name = "Supervisors_lstView";
            this.Supervisors_lstView.Size = new System.Drawing.Size(427, 183);
            this.Supervisors_lstView.TabIndex = 0;
            this.Supervisors_lstView.UseCompatibleStateImageBehavior = false;
            // 
            // NotSupervisors_lstView
            // 
            this.NotSupervisors_lstView.HideSelection = false;
            this.NotSupervisors_lstView.Location = new System.Drawing.Point(508, 294);
            this.NotSupervisors_lstView.Name = "NotSupervisors_lstView";
            this.NotSupervisors_lstView.Size = new System.Drawing.Size(449, 183);
            this.NotSupervisors_lstView.TabIndex = 1;
            this.NotSupervisors_lstView.UseCompatibleStateImageBehavior = false;
            // 
            // Activities_lstview
            // 
            this.Activities_lstview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Activities_lstview.HideSelection = false;
            this.Activities_lstview.Location = new System.Drawing.Point(287, 60);
            this.Activities_lstview.Name = "Activities_lstview";
            this.Activities_lstview.Size = new System.Drawing.Size(398, 170);
            this.Activities_lstview.TabIndex = 2;
            this.Activities_lstview.UseCompatibleStateImageBehavior = false;
            this.Activities_lstview.View = System.Windows.Forms.View.Details;
            // 
            // Remove_btton
            // 
            this.Remove_btton.Location = new System.Drawing.Point(167, 512);
            this.Remove_btton.Name = "Remove_btton";
            this.Remove_btton.Size = new System.Drawing.Size(123, 37);
            this.Remove_btton.TabIndex = 3;
            this.Remove_btton.Text = "Remove";
            this.Remove_btton.UseVisualStyleBackColor = true;
            // 
            // Add_btton
            // 
            this.Add_btton.Location = new System.Drawing.Point(668, 512);
            this.Add_btton.Name = "Add_btton";
            this.Add_btton.Size = new System.Drawing.Size(137, 37);
            this.Add_btton.TabIndex = 4;
            this.Add_btton.Text = "Add";
            this.Add_btton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Non-Supervisors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Supervisors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Activities";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Start";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "End";
            this.columnHeader4.Width = 95;
            // 
            // SupervisorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_btton);
            this.Controls.Add(this.Remove_btton);
            this.Controls.Add(this.Activities_lstview);
            this.Controls.Add(this.NotSupervisors_lstView);
            this.Controls.Add(this.Supervisors_lstView);
            this.Name = "SupervisorsControl";
            this.Size = new System.Drawing.Size(992, 583);
            this.Load += new System.EventHandler(this.SupervisorsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Supervisors_lstView;
        private System.Windows.Forms.ListView NotSupervisors_lstView;
        private System.Windows.Forms.ListView Activities_lstview;
        private System.Windows.Forms.Button Remove_btton;
        private System.Windows.Forms.Button Add_btton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
