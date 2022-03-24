
namespace SomerenUI
{
    partial class DrinksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinksForm));
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.buttonDeleteDrinks = new System.Windows.Forms.Button();
            this.buttonEditDrinks = new System.Windows.Forms.Button();
            this.buttonAddDrinks = new System.Windows.Forms.Button();
            this.listViewDrinks = new System.Windows.Forms.ListView();
            this.Drink_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drink_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drink_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drink_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drink_Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drink_StockInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drink_Orders = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.buttonDeleteDrinks);
            this.pnlDrinks.Controls.Add(this.buttonEditDrinks);
            this.pnlDrinks.Controls.Add(this.buttonAddDrinks);
            this.pnlDrinks.Controls.Add(this.listViewDrinks);
            this.pnlDrinks.Controls.Add(this.pictureBox3);
            this.pnlDrinks.Controls.Add(this.label1);
            this.pnlDrinks.Location = new System.Drawing.Point(10, 11);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(981, 466);
            this.pnlDrinks.TabIndex = 9;
            // 
            // buttonDeleteDrinks
            // 
            this.buttonDeleteDrinks.Location = new System.Drawing.Point(164, 369);
            this.buttonDeleteDrinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteDrinks.Name = "buttonDeleteDrinks";
            this.buttonDeleteDrinks.Size = new System.Drawing.Size(70, 25);
            this.buttonDeleteDrinks.TabIndex = 8;
            this.buttonDeleteDrinks.Text = "Delete";
            this.buttonDeleteDrinks.UseVisualStyleBackColor = true;
            this.buttonDeleteDrinks.Click += new System.EventHandler(this.buttonDeleteDrinks_Click);
            // 
            // buttonEditDrinks
            // 
            this.buttonEditDrinks.Location = new System.Drawing.Point(90, 369);
            this.buttonEditDrinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditDrinks.Name = "buttonEditDrinks";
            this.buttonEditDrinks.Size = new System.Drawing.Size(70, 25);
            this.buttonEditDrinks.TabIndex = 7;
            this.buttonEditDrinks.Text = "Edit";
            this.buttonEditDrinks.UseVisualStyleBackColor = true;
            this.buttonEditDrinks.Click += new System.EventHandler(this.buttonEditDrinks_Click);
            // 
            // buttonAddDrinks
            // 
            this.buttonAddDrinks.Location = new System.Drawing.Point(16, 369);
            this.buttonAddDrinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddDrinks.Name = "buttonAddDrinks";
            this.buttonAddDrinks.Size = new System.Drawing.Size(70, 25);
            this.buttonAddDrinks.TabIndex = 6;
            this.buttonAddDrinks.Text = "Add";
            this.buttonAddDrinks.UseVisualStyleBackColor = true;
            this.buttonAddDrinks.Click += new System.EventHandler(this.buttonAddDrinks_Click);
            // 
            // listViewDrinks
            // 
            this.listViewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Drink_Number,
            this.Drink_Name,
            this.Drink_Price,
            this.Drink_Type,
            this.Drink_Stock,
            this.Drink_StockInfo,
            this.Drink_Orders});
            this.listViewDrinks.FullRowSelect = true;
            this.listViewDrinks.HideSelection = false;
            this.listViewDrinks.Location = new System.Drawing.Point(16, 42);
            this.listViewDrinks.Name = "listViewDrinks";
            this.listViewDrinks.Size = new System.Drawing.Size(779, 307);
            this.listViewDrinks.TabIndex = 5;
            this.listViewDrinks.UseCompatibleStateImageBehavior = false;
            this.listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // Drink_Number
            // 
            this.Drink_Number.Text = "Number";
            this.Drink_Number.Width = 0;
            // 
            // Drink_Name
            // 
            this.Drink_Name.Text = "Name";
            this.Drink_Name.Width = 150;
            // 
            // Drink_Price
            // 
            this.Drink_Price.Text = "Price";
            this.Drink_Price.Width = 80;
            // 
            // Drink_Type
            // 
            this.Drink_Type.Text = "Type";
            this.Drink_Type.Width = 150;
            // 
            // Drink_Stock
            // 
            this.Drink_Stock.Text = "In Stock";
            this.Drink_Stock.Width = 70;
            // 
            // Drink_StockInfo
            // 
            this.Drink_StockInfo.Text = "Stock Info";
            this.Drink_StockInfo.Width = 175;
            // 
            // Drink_Orders
            // 
            this.Drink_Orders.Text = "Times Ordered";
            this.Drink_Orders.Width = 150;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drinks Supplies";
            // 
            // DrinksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 510);
            this.Controls.Add(this.pnlDrinks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DrinksForm";
            this.Text = "DrinksForm";
            this.pnlDrinks.ResumeLayout(false);
            this.pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.Button buttonDeleteDrinks;
        private System.Windows.Forms.Button buttonEditDrinks;
        private System.Windows.Forms.Button buttonAddDrinks;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ColumnHeader Drink_Number;
        private System.Windows.Forms.ColumnHeader Drink_Name;
        private System.Windows.Forms.ColumnHeader Drink_Price;
        private System.Windows.Forms.ColumnHeader Drink_Type;
        private System.Windows.Forms.ColumnHeader Drink_Stock;
        private System.Windows.Forms.ColumnHeader Drink_StockInfo;
        private System.Windows.Forms.ColumnHeader Drink_Orders;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}