
namespace SomerenUI
{
    partial class RegisterForm
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.lstDrinks = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAlcohol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstStudents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkoutbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstDrinks
            // 
            this.lstDrinks.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.lstDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnName,
            this.columnPrice,
            this.columnStock,
            this.columnAlcohol});
            this.lstDrinks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDrinks.HideSelection = false;
            this.lstDrinks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstDrinks.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.lstDrinks.Location = new System.Drawing.Point(485, 36);
            this.lstDrinks.MultiSelect = false;
            this.lstDrinks.Name = "lstDrinks";
            this.lstDrinks.Size = new System.Drawing.Size(430, 244);
            this.lstDrinks.TabIndex = 0;
            this.lstDrinks.TileSize = new System.Drawing.Size(200, 100);
            this.lstDrinks.UseCompatibleStateImageBehavior = false;
            this.lstDrinks.View = System.Windows.Forms.View.Details;
            this.lstDrinks.SelectedIndexChanged += new System.EventHandler(this.lstDrinks_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 100;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 70;
            // 
            // columnStock
            // 
            this.columnStock.Text = "Stock";
            // 
            // columnAlcohol
            // 
            this.columnAlcohol.Text = "Alcohol";
            // 
            // lstStudents
            // 
            this.lstStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstStudents.HideSelection = false;
            this.lstStudents.Location = new System.Drawing.Point(46, 36);
            this.lstStudents.MultiSelect = false;
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(312, 244);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.UseCompatibleStateImageBehavior = false;
            this.lstStudents.View = System.Windows.Forms.View.Details;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 100;
            // 
            // checkoutbtn
            // 
            this.checkoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbtn.Location = new System.Drawing.Point(329, 392);
            this.checkoutbtn.Name = "checkoutbtn";
            this.checkoutbtn.Size = new System.Drawing.Size(201, 36);
            this.checkoutbtn.TabIndex = 3;
            this.checkoutbtn.Text = "Check Out";
            this.checkoutbtn.UseVisualStyleBackColor = true;
            this.checkoutbtn.Click += new System.EventHandler(this.checkoutbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount to pay:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(402, 332);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 39);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Drink";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 30;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkoutbtn);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.lstDrinks);
            this.Name = "RegisterForm";
            this.Text = "Cash  Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstDrinks;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnStock;
        private System.Windows.Forms.ColumnHeader columnAlcohol;
        private System.Windows.Forms.ListView lstStudents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button checkoutbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}