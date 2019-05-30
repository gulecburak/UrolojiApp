namespace UrolojiApp.Models
{
    partial class frmDr
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
            this.chcLstDr = new System.Windows.Forms.CheckedListBox();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtAddDr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // chcLstDr
            // 
            this.chcLstDr.BackColor = System.Drawing.Color.DarkBlue;
            this.chcLstDr.CheckOnClick = true;
            this.chcLstDr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chcLstDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcLstDr.ForeColor = System.Drawing.Color.White;
            this.chcLstDr.FormattingEnabled = true;
            this.chcLstDr.Location = new System.Drawing.Point(0, 0);
            this.chcLstDr.Name = "chcLstDr";
            this.chcLstDr.Size = new System.Drawing.Size(327, 273);
            this.chcLstDr.TabIndex = 0;
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMid.Controls.Add(this.splitContainer1);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(0, 80);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(430, 277);
            this.pnlMid.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chcLstDr);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnTransfer);
            this.splitContainer1.Size = new System.Drawing.Size(430, 277);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransfer.Location = new System.Drawing.Point(0, 0);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(91, 273);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Aktar";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlTop.Controls.Add(this.txtAddDr);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnSave);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(430, 80);
            this.pnlTop.TabIndex = 2;
            // 
            // txtAddDr
            // 
            this.txtAddDr.Location = new System.Drawing.Point(110, 45);
            this.txtAddDr.Name = "txtAddDr";
            this.txtAddDr.Size = new System.Drawing.Size(308, 20);
            this.txtAddDr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doktor Adı :";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(430, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlBot
            // 
            this.pnlBot.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlBot.Controls.Add(this.btnKapat);
            this.pnlBot.Controls.Add(this.btnDelete);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 357);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(430, 72);
            this.pnlBot.TabIndex = 3;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Location = new System.Drawing.Point(0, 46);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(430, 26);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(430, 29);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 429);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBot);
            this.Name = "frmDr";
            this.Text = "Doktor Girişi";
            this.Load += new System.EventHandler(this.frmDr_Load);
            this.pnlMid.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chcLstDr;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtAddDr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnDelete;
    }
}