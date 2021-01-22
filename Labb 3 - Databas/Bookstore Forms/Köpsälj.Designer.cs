
namespace Labb3
{
    partial class Köpsälj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Köpsälj));
            this.BookSelect = new System.Windows.Forms.ListBox();
            this.SelectBooklabel = new System.Windows.Forms.Label();
            this.Antal = new System.Windows.Forms.Label();
            this.AntalSelect = new System.Windows.Forms.TextBox();
            this.RadioKöp = new System.Windows.Forms.RadioButton();
            this.RadioSälj = new System.Windows.Forms.RadioButton();
            this.Executebtn = new System.Windows.Forms.Button();
            this.Transactionlabel = new System.Windows.Forms.Label();
            this.Lagersaldoshortcut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookSelect
            // 
            this.BookSelect.FormattingEnabled = true;
            resources.ApplyResources(this.BookSelect, "BookSelect");
            this.BookSelect.Name = "BookSelect";
            // 
            // SelectBooklabel
            // 
            resources.ApplyResources(this.SelectBooklabel, "SelectBooklabel");
            this.SelectBooklabel.Name = "SelectBooklabel";
            // 
            // Antal
            // 
            resources.ApplyResources(this.Antal, "Antal");
            this.Antal.Name = "Antal";
            // 
            // AntalSelect
            // 
            resources.ApplyResources(this.AntalSelect, "AntalSelect");
            this.AntalSelect.Name = "AntalSelect";
            // 
            // RadioKöp
            // 
            resources.ApplyResources(this.RadioKöp, "RadioKöp");
            this.RadioKöp.Name = "RadioKöp";
            this.RadioKöp.TabStop = true;
            this.RadioKöp.UseVisualStyleBackColor = true;
            // 
            // RadioSälj
            // 
            resources.ApplyResources(this.RadioSälj, "RadioSälj");
            this.RadioSälj.Name = "RadioSälj";
            this.RadioSälj.TabStop = true;
            this.RadioSälj.UseVisualStyleBackColor = true;
            // 
            // Executebtn
            // 
            resources.ApplyResources(this.Executebtn, "Executebtn");
            this.Executebtn.Name = "Executebtn";
            this.Executebtn.UseVisualStyleBackColor = true;
            this.Executebtn.Click += new System.EventHandler(this.Executebtn_Click);
            // 
            // Transactionlabel
            // 
            resources.ApplyResources(this.Transactionlabel, "Transactionlabel");
            this.Transactionlabel.Name = "Transactionlabel";
            // 
            // Lagersaldoshortcut
            // 
            resources.ApplyResources(this.Lagersaldoshortcut, "Lagersaldoshortcut");
            this.Lagersaldoshortcut.Name = "Lagersaldoshortcut";
            this.Lagersaldoshortcut.UseVisualStyleBackColor = true;
            this.Lagersaldoshortcut.Click += new System.EventHandler(this.Lagersaldoshortcut_Click);
            // 
            // Köpsälj
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lagersaldoshortcut);
            this.Controls.Add(this.Transactionlabel);
            this.Controls.Add(this.Executebtn);
            this.Controls.Add(this.RadioSälj);
            this.Controls.Add(this.RadioKöp);
            this.Controls.Add(this.AntalSelect);
            this.Controls.Add(this.Antal);
            this.Controls.Add(this.SelectBooklabel);
            this.Controls.Add(this.BookSelect);
            this.Name = "Köpsälj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookSelect;
        private System.Windows.Forms.Label SelectBooklabel;
        private System.Windows.Forms.Label Antal;
        private System.Windows.Forms.TextBox AntalSelect;
        private System.Windows.Forms.RadioButton RadioKöp;
        private System.Windows.Forms.RadioButton RadioSälj;
        private System.Windows.Forms.Button Executebtn;
        private System.Windows.Forms.Label Transactionlabel;
        private System.Windows.Forms.Button Lagersaldoshortcut;
    }
}