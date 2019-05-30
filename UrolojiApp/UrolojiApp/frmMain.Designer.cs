namespace UrolojiApp
{
    partial class frmMain
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnFindPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDr = new System.Windows.Forms.Button();
            this.btnOpType = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpLeft.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Firebrick;
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnThree);
            this.pnlTop.Controls.Add(this.btnList);
            this.pnlTop.Controls.Add(this.btnTwo);
            this.pnlTop.Controls.Add(this.btnOne);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(803, 59);
            this.pnlTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoEllipsis = true;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(719, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnThree
            // 
            this.btnThree.AutoEllipsis = true;
            this.btnThree.BackColor = System.Drawing.Color.Transparent;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnThree.ForeColor = System.Drawing.Color.White;
            this.btnThree.Location = new System.Drawing.Point(188, 3);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(75, 50);
            this.btnThree.TabIndex = 0;
            this.btnThree.Text = "button1";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Transparent;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.Color.White;
            this.btnTwo.Location = new System.Drawing.Point(84, 3);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(98, 50);
            this.btnTwo.TabIndex = 0;
            this.btnTwo.Text = "Bilgi Giriş";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Transparent;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.Color.White;
            this.btnOne.Location = new System.Drawing.Point(3, 3);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 50);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "Böbrek";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpLeft
            // 
            this.grpLeft.BackColor = System.Drawing.Color.Firebrick;
            this.grpLeft.Controls.Add(this.pnl1);
            this.grpLeft.Controls.Add(this.pnl3);
            this.grpLeft.Controls.Add(this.pnl2);
            this.grpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpLeft.ForeColor = System.Drawing.Color.White;
            this.grpLeft.Location = new System.Drawing.Point(0, 59);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(205, 433);
            this.grpLeft.TabIndex = 1;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "Böbrek Giriş";
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Firebrick;
            this.pnl1.Controls.Add(this.btnFindPatient);
            this.pnl1.Controls.Add(this.btnAddPatient);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl1.Location = new System.Drawing.Point(403, 16);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(200, 414);
            this.pnl1.TabIndex = 0;
            this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1_Paint);
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPatient.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPatient.ForeColor = System.Drawing.Color.White;
            this.btnFindPatient.Location = new System.Drawing.Point(9, 61);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(185, 34);
            this.btnFindPatient.TabIndex = 0;
            this.btnFindPatient.Text = "Hasta Bul";
            this.btnFindPatient.UseVisualStyleBackColor = true;
            this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(9, 21);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(185, 34);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Hasta Giriş";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.Firebrick;
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl3.Location = new System.Drawing.Point(203, 16);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(200, 414);
            this.pnl3.TabIndex = 0;
            this.pnl3.Visible = false;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Firebrick;
            this.pnl2.Controls.Add(this.btnSub);
            this.pnl2.Controls.Add(this.btnDr);
            this.pnl2.Controls.Add(this.btnOpType);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl2.Location = new System.Drawing.Point(3, 16);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(200, 414);
            this.pnl2.TabIndex = 0;
            this.pnl2.Visible = false;
            // 
            // btnSub
            // 
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Location = new System.Drawing.Point(9, 99);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(185, 34);
            this.btnSub.TabIndex = 0;
            this.btnSub.Text = "Altgrup Giriş";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDr
            // 
            this.btnDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDr.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDr.ForeColor = System.Drawing.Color.White;
            this.btnDr.Location = new System.Drawing.Point(9, 61);
            this.btnDr.Name = "btnDr";
            this.btnDr.Size = new System.Drawing.Size(185, 34);
            this.btnDr.TabIndex = 0;
            this.btnDr.Text = "Doktor Giriş";
            this.btnDr.UseVisualStyleBackColor = true;
            this.btnDr.Click += new System.EventHandler(this.btnDr_Click);
            // 
            // btnOpType
            // 
            this.btnOpType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpType.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpType.ForeColor = System.Drawing.Color.White;
            this.btnOpType.Location = new System.Drawing.Point(9, 21);
            this.btnOpType.Name = "btnOpType";
            this.btnOpType.Size = new System.Drawing.Size(185, 34);
            this.btnOpType.TabIndex = 0;
            this.btnOpType.Text = "Operasyon Tür Giriş";
            this.btnOpType.UseVisualStyleBackColor = true;
            this.btnOpType.Click += new System.EventHandler(this.btnOpType_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Transparent;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(372, 6);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(98, 50);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "Üroloji Listesi";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(803, 492);
            this.Controls.Add(this.grpLeft);
            this.Controls.Add(this.pnlTop);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.grpLeft.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFindPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnOpType;
        private System.Windows.Forms.Button btnDr;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnList;
    }
}