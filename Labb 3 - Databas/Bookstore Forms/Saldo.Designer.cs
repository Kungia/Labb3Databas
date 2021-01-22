
namespace Labb3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saldo));
            this.LagersaldoDb = new System.Windows.Forms.DataGridView();
            this.KöpSäljbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LagersaldoDb)).BeginInit();
            this.SuspendLayout();
            // 
            // LagersaldoDb
            // 
            this.LagersaldoDb.AllowUserToAddRows = false;
            this.LagersaldoDb.AllowUserToDeleteRows = false;
            this.LagersaldoDb.AllowUserToOrderColumns = true;
            this.LagersaldoDb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LagersaldoDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LagersaldoDb.Location = new System.Drawing.Point(12, 15);
            this.LagersaldoDb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LagersaldoDb.Name = "LagersaldoDb";
            this.LagersaldoDb.ReadOnly = true;
            this.LagersaldoDb.RowHeadersWidth = 51;
            this.LagersaldoDb.RowTemplate.Height = 24;
            this.LagersaldoDb.Size = new System.Drawing.Size(776, 468);
            this.LagersaldoDb.TabIndex = 2;
            // 
            // KöpSäljbtn
            // 
            this.KöpSäljbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KöpSäljbtn.Location = new System.Drawing.Point(689, 515);
            this.KöpSäljbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KöpSäljbtn.Name = "KöpSäljbtn";
            this.KöpSäljbtn.Size = new System.Drawing.Size(99, 32);
            this.KöpSäljbtn.TabIndex = 10;
            this.KöpSäljbtn.Text = "Köp/Sälj";
            this.KöpSäljbtn.UseVisualStyleBackColor = true;
            this.KöpSäljbtn.Click += new System.EventHandler(this.KöpSäljbtn_Click);
            // 
            // Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.KöpSäljbtn);
            this.Controls.Add(this.LagersaldoDb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Saldo";
            this.Text = "Saldo";
            this.Load += new System.EventHandler(this.Lagersaldo___Lundells_Bookstore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LagersaldoDb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView LagersaldoDb;
        private System.Windows.Forms.Button KöpSäljbtn;
    }
}