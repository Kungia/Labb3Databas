
namespace Labb_3___Databas
{
    partial class KöpSälj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KöpSälj));
            this.BookSelect = new System.Windows.Forms.ListBox();
            this.SelectBooklabel = new System.Windows.Forms.Label();
            this.Antal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.BookSelect.ItemHeight = 16;
            this.BookSelect.Location = new System.Drawing.Point(12, 39);
            this.BookSelect.Name = "BookSelect";
            this.BookSelect.Size = new System.Drawing.Size(202, 148);
            this.BookSelect.TabIndex = 3;
            // 
            // SelectBooklabel
            // 
            this.SelectBooklabel.AutoSize = true;
            this.SelectBooklabel.Location = new System.Drawing.Point(12, 19);
            this.SelectBooklabel.Name = "SelectBooklabel";
            this.SelectBooklabel.Size = new System.Drawing.Size(62, 17);
            this.SelectBooklabel.TabIndex = 4;
            this.SelectBooklabel.Text = "Välj bok:";
            // 
            // Antal
            // 
            this.Antal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Antal.AutoSize = true;
            this.Antal.Location = new System.Drawing.Point(261, 19);
            this.Antal.Name = "Antal";
            this.Antal.Size = new System.Drawing.Size(71, 17);
            this.Antal.TabIndex = 5;
            this.Antal.Text = "Välj Antal:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(264, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 22);
            this.textBox1.TabIndex = 6;
            // 
            // RadioKöp
            // 
            this.RadioKöp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioKöp.AutoSize = true;
            this.RadioKöp.Location = new System.Drawing.Point(264, 84);
            this.RadioKöp.Name = "RadioKöp";
            this.RadioKöp.Size = new System.Drawing.Size(81, 21);
            this.RadioKöp.TabIndex = 7;
            this.RadioKöp.TabStop = true;
            this.RadioKöp.Text = "Köp bok";
            this.RadioKöp.UseVisualStyleBackColor = true;
            // 
            // RadioSälj
            // 
            this.RadioSälj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioSälj.AutoSize = true;
            this.RadioSälj.Location = new System.Drawing.Point(264, 122);
            this.RadioSälj.Name = "RadioSälj";
            this.RadioSälj.Size = new System.Drawing.Size(79, 21);
            this.RadioSälj.TabIndex = 8;
            this.RadioSälj.TabStop = true;
            this.RadioSälj.Text = "Sälj bok";
            this.RadioSälj.UseVisualStyleBackColor = true;
            // 
            // Executebtn
            // 
            this.Executebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Executebtn.Location = new System.Drawing.Point(258, 161);
            this.Executebtn.Name = "Executebtn";
            this.Executebtn.Size = new System.Drawing.Size(99, 26);
            this.Executebtn.TabIndex = 9;
            this.Executebtn.Text = "Bekräfta";
            this.Executebtn.UseVisualStyleBackColor = true;
            // 
            // Transactionlabel
            // 
            this.Transactionlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Transactionlabel.AutoSize = true;
            this.Transactionlabel.Location = new System.Drawing.Point(9, 237);
            this.Transactionlabel.Name = "Transactionlabel";
            this.Transactionlabel.Size = new System.Drawing.Size(414, 17);
            this.Transactionlabel.TabIndex = 10;
            this.Transactionlabel.Text = "Fyll i fälten och tryck på \"Bekräfta\" för att köpa eller sälja en bok.";
            // 
            // Lagersaldoshortcut
            // 
            this.Lagersaldoshortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lagersaldoshortcut.Location = new System.Drawing.Point(15, 276);
            this.Lagersaldoshortcut.Name = "Lagersaldoshortcut";
            this.Lagersaldoshortcut.Size = new System.Drawing.Size(99, 26);
            this.Lagersaldoshortcut.TabIndex = 11;
            this.Lagersaldoshortcut.Text = "Lagersaldo";
            this.Lagersaldoshortcut.UseVisualStyleBackColor = true;
            this.Lagersaldoshortcut.Click += new System.EventHandler(this.Lagersaldoshortcut_Click);
            // 
            // KöpSälj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 314);
            this.Controls.Add(this.Lagersaldoshortcut);
            this.Controls.Add(this.Transactionlabel);
            this.Controls.Add(this.Executebtn);
            this.Controls.Add(this.RadioSälj);
            this.Controls.Add(this.RadioKöp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Antal);
            this.Controls.Add(this.SelectBooklabel);
            this.Controls.Add(this.BookSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 450);
            this.Name = "KöpSälj";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookSelect;
        private System.Windows.Forms.Label SelectBooklabel;
        private System.Windows.Forms.Label Antal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RadioKöp;
        private System.Windows.Forms.RadioButton RadioSälj;
        private System.Windows.Forms.Button Executebtn;
        private System.Windows.Forms.Label Transactionlabel;
        private System.Windows.Forms.Button Lagersaldoshortcut;
    }
}