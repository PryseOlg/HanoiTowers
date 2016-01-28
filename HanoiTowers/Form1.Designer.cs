namespace HanoiTowers
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstHamleler = new System.Windows.Forms.ListBox();
            this.pbKule1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.oynatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbHiz = new System.Windows.Forms.ToolStripComboBox();
            this.pbKule2 = new System.Windows.Forms.PictureBox();
            this.pbKule3 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbKule1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKule2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKule3)).BeginInit();
            this.SuspendLayout();
            // 
            // lstHamleler
            // 
            this.lstHamleler.FormattingEnabled = true;
            this.lstHamleler.Location = new System.Drawing.Point(13, 38);
            this.lstHamleler.Name = "lstHamleler";
            this.lstHamleler.Size = new System.Drawing.Size(142, 485);
            this.lstHamleler.TabIndex = 0;
            // 
            // pbKule1
            // 
            this.pbKule1.Image = ((System.Drawing.Image)(resources.GetObject("pbKule1.Image")));
            this.pbKule1.Location = new System.Drawing.Point(160, 25);
            this.pbKule1.Name = "pbKule1";
            this.pbKule1.Size = new System.Drawing.Size(200, 500);
            this.pbKule1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKule1.TabIndex = 1;
            this.pbKule1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDurum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtDurum
            // 
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(44, 17);
            this.txtDurum.Text = "Durum";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeni,
            this.oynatToolStripMenuItem,
            this.cmbHiz});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnYeni
            // 
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(43, 23);
            this.btnYeni.Text = "New";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // oynatToolStripMenuItem
            // 
            this.oynatToolStripMenuItem.Name = "oynatToolStripMenuItem";
            this.oynatToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.oynatToolStripMenuItem.Text = "Play";
            this.oynatToolStripMenuItem.Click += new System.EventHandler(this.oynatToolStripMenuItem_Click);
            // 
            // cmbHiz
            // 
            this.cmbHiz.Items.AddRange(new object[] {
            "Slower - 0.5 Move / Sec",
            "Slow - 1 Move / Sec",
            "Normal - 2 Move / Sec",
            "Fast - 4 Move / Sec",
            "Faster - 5 Move / Sec"});
            this.cmbHiz.Name = "cmbHiz";
            this.cmbHiz.Size = new System.Drawing.Size(121, 23);
            this.cmbHiz.Text = "Speed";
            this.cmbHiz.SelectedIndexChanged += new System.EventHandler(this.cmbHiz_IndexChanged);
            // 
            // pbKule2
            // 
            this.pbKule2.Image = ((System.Drawing.Image)(resources.GetObject("pbKule2.Image")));
            this.pbKule2.Location = new System.Drawing.Point(366, 25);
            this.pbKule2.Name = "pbKule2";
            this.pbKule2.Size = new System.Drawing.Size(200, 500);
            this.pbKule2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKule2.TabIndex = 4;
            this.pbKule2.TabStop = false;
            // 
            // pbKule3
            // 
            this.pbKule3.Image = ((System.Drawing.Image)(resources.GetObject("pbKule3.Image")));
            this.pbKule3.Location = new System.Drawing.Point(571, 25);
            this.pbKule3.Name = "pbKule3";
            this.pbKule3.Size = new System.Drawing.Size(200, 500);
            this.pbKule3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKule3.TabIndex = 5;
            this.pbKule3.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(10, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(81, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Moves to Solve";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pbKule3);
            this.Controls.Add(this.pbKule2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbKule1);
            this.Controls.Add(this.lstHamleler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hanoi Kuleleri Problemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKule1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKule2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKule3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHamleler;
        private System.Windows.Forms.PictureBox pbKule1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtDurum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnYeni;
        private System.Windows.Forms.PictureBox pbKule2;
        private System.Windows.Forms.PictureBox pbKule3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ToolStripMenuItem oynatToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripComboBox cmbHiz;
    }
}

