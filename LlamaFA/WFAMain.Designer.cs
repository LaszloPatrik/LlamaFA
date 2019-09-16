namespace LlamaFA
{
    partial class F1
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
            this.b1 = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbEv = new System.Windows.Forms.TextBox();
            this.tbIz = new System.Windows.Forms.TextBox();
            this.cbNev = new System.Windows.Forms.ComboBox();
            this.lbSzul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Enabled = false;
            this.b1.Location = new System.Drawing.Point(12, 105);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(357, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "Új Láma";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.B1_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(9, 63);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(27, 13);
            this.l1.TabIndex = 1;
            this.l1.Text = "Név";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(141, 63);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(45, 13);
            this.l2.TabIndex = 2;
            this.l2.Text = "Szül. év";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(266, 63);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(55, 13);
            this.l3.TabIndex = 3;
            this.l3.Text = "Kedvelt íz";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(12, 79);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(100, 20);
            this.tbNev.TabIndex = 4;
            // 
            // tbEv
            // 
            this.tbEv.Location = new System.Drawing.Point(144, 79);
            this.tbEv.Name = "tbEv";
            this.tbEv.Size = new System.Drawing.Size(100, 20);
            this.tbEv.TabIndex = 5;
            // 
            // tbIz
            // 
            this.tbIz.Location = new System.Drawing.Point(269, 79);
            this.tbIz.Name = "tbIz";
            this.tbIz.Size = new System.Drawing.Size(100, 20);
            this.tbIz.TabIndex = 6;
            // 
            // cbNev
            // 
            this.cbNev.FormattingEnabled = true;
            this.cbNev.Location = new System.Drawing.Point(12, 12);
            this.cbNev.Name = "cbNev";
            this.cbNev.Size = new System.Drawing.Size(121, 21);
            this.cbNev.TabIndex = 7;
            this.cbNev.SelectedIndexChanged += new System.EventHandler(this.CbNev_SelectedIndexChanged);
            // 
            // lbSzul
            // 
            this.lbSzul.AutoSize = true;
            this.lbSzul.Location = new System.Drawing.Point(218, 15);
            this.lbSzul.Name = "lbSzul";
            this.lbSzul.Size = new System.Drawing.Size(59, 13);
            this.lbSzul.TabIndex = 8;
            this.lbSzul.Text = "#Szül. év#";
            // 
            // F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 136);
            this.Controls.Add(this.lbSzul);
            this.Controls.Add(this.cbNev);
            this.Controls.Add(this.tbIz);
            this.Controls.Add(this.tbEv);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.b1);
            this.Name = "F1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbEv;
        private System.Windows.Forms.TextBox tbIz;
        private System.Windows.Forms.ComboBox cbNev;
        private System.Windows.Forms.Label lbSzul;
    }
}

