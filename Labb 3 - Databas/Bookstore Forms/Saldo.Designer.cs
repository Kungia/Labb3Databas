
namespace Labb3.Bookstore_Forms
{
    partial class Saldo
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
            this.datatable = new System.Windows.Forms.DataGridView();
            this.Buysellshort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).BeginInit();
            this.SuspendLayout();
            // 
            // datatable
            // 
            this.datatable.AllowUserToOrderColumns = true;
            this.datatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatable.Location = new System.Drawing.Point(12, 12);
            this.datatable.Name = "datatable";
            this.datatable.RowHeadersWidth = 51;
            this.datatable.RowTemplate.Height = 29;
            this.datatable.Size = new System.Drawing.Size(776, 378);
            this.datatable.TabIndex = 0;
            // 
            // Buysellshort
            // 
            this.Buysellshort.Location = new System.Drawing.Point(12, 409);
            this.Buysellshort.Name = "Buysellshort";
            this.Buysellshort.Size = new System.Drawing.Size(94, 29);
            this.Buysellshort.TabIndex = 1;
            this.Buysellshort.Text = "Köp/Sälj";
            this.Buysellshort.UseVisualStyleBackColor = true;
            this.Buysellshort.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Buysellshort);
            this.Controls.Add(this.datatable);
            this.Name = "Saldo";
            this.Text = "Saldo";
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datatable;
        private System.Windows.Forms.Button Buysellshort;
    }
}