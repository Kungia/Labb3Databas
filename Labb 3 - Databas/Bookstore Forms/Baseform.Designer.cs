
namespace Labb_3___Databas
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.LagersaldoBtn = new System.Windows.Forms.Button();
            this.BuySellBtn = new System.Windows.Forms.Button();
            this.selectlabel = new System.Windows.Forms.Label();
            this.StoreSelect = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LagersaldoBtn
            // 
            this.LagersaldoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LagersaldoBtn.Location = new System.Drawing.Point(259, 115);
            this.LagersaldoBtn.Name = "LagersaldoBtn";
            this.LagersaldoBtn.Size = new System.Drawing.Size(124, 35);
            this.LagersaldoBtn.TabIndex = 0;
            this.LagersaldoBtn.Text = "Lagersaldo";
            this.LagersaldoBtn.UseVisualStyleBackColor = true;
            this.LagersaldoBtn.Click += new System.EventHandler(this.LagersaldoBtn_Click);
            // 
            // BuySellBtn
            // 
            this.BuySellBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuySellBtn.Location = new System.Drawing.Point(259, 50);
            this.BuySellBtn.Name = "BuySellBtn";
            this.BuySellBtn.Size = new System.Drawing.Size(124, 35);
            this.BuySellBtn.TabIndex = 1;
            this.BuySellBtn.Text = "Köp/Sälj";
            this.BuySellBtn.UseVisualStyleBackColor = true;
            this.BuySellBtn.Click += new System.EventHandler(this.BuySellBtn_Click);
            // 
            // selectlabel
            // 
            this.selectlabel.AutoSize = true;
            this.selectlabel.Location = new System.Drawing.Point(12, 30);
            this.selectlabel.Name = "selectlabel";
            this.selectlabel.Size = new System.Drawing.Size(69, 17);
            this.selectlabel.TabIndex = 3;
            this.selectlabel.Text = "Välj butik:";
            // 
            // StoreSelect
            // 
            this.StoreSelect.FormattingEnabled = true;
            this.StoreSelect.ItemHeight = 16;
            this.StoreSelect.Location = new System.Drawing.Point(12, 50);
            this.StoreSelect.MaximumSize = new System.Drawing.Size(202, 100);
            this.StoreSelect.MinimumSize = new System.Drawing.Size(202, 100);
            this.StoreSelect.Name = "StoreSelect";
            this.StoreSelect.Size = new System.Drawing.Size(202, 100);
            this.StoreSelect.TabIndex = 2;
            this.StoreSelect.SelectedIndexChanged += new System.EventHandler(this.LagersaldoStoreSelect_SelectedIndexChanged);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 184);
            this.Controls.Add(this.selectlabel);
            this.Controls.Add(this.StoreSelect);
            this.Controls.Add(this.BuySellBtn);
            this.Controls.Add(this.LagersaldoBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 231);
            this.MinimumSize = new System.Drawing.Size(418, 231);
            this.Name = "BaseForm";
            this.Text = "Lundells Bookstore";
            this.Load += new System.EventHandler(this.BaseForm___Lundells_Bookstore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LagersaldoBtn;
        private System.Windows.Forms.Button BuySellBtn;
        private System.Windows.Forms.Label selectlabel;
        private System.Windows.Forms.ListBox StoreSelect;
    }
}