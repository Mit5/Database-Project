
namespace SomerenUI
{
    partial class RoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.roomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRooms = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRooms
            // 
            this.pnlRooms.Controls.Add(this.listViewRooms);
            this.pnlRooms.Controls.Add(this.pictureBox2);
            this.pnlRooms.Controls.Add(this.lblRooms);
            this.pnlRooms.Location = new System.Drawing.Point(25, 20);
            this.pnlRooms.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(1251, 574);
            this.pnlRooms.TabIndex = 7;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomNumber,
            this.capacity,
            this.roomType});
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(21, 52);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(1020, 377);
            this.listViewRooms.TabIndex = 5;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // roomNumber
            // 
            this.roomNumber.Text = "Number";
            // 
            // capacity
            // 
            this.capacity.Text = "Capacity";
            // 
            // roomType
            // 
            this.roomType.Text = "Type";
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.Location = new System.Drawing.Point(13, 12);
            this.lblRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(108, 33);
            this.lblRooms.TabIndex = 3;
            this.lblRooms.Text = "Rooms";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1058, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 151);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 614);
            this.Controls.Add(this.pnlRooms);
            this.Name = "RoomsForm";
            this.Text = "RoomsForm";
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader roomNumber;
        private System.Windows.Forms.ColumnHeader capacity;
        private System.Windows.Forms.ColumnHeader roomType;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRooms;
    }
}