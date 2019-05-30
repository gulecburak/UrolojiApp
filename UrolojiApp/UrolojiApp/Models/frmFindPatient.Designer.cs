namespace UrolojiApp.Models
{
    partial class frmFindPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataListPatient = new System.Windows.Forms.DataGridView();
            this.btnDefault = new System.Windows.Forms.Button();
            this.rdProt = new System.Windows.Forms.RadioButton();
            this.txtProtNo = new System.Windows.Forms.TextBox();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Hasta Bul :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataListPatient);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.Controls.Add(this.btnDefault);
            this.splitContainer1.Panel2.Controls.Add(this.rdProt);
            this.splitContainer1.Panel2.Controls.Add(this.txtProtNo);
            this.splitContainer1.Panel2.Controls.Add(this.rdName);
            this.splitContainer1.Panel2.Controls.Add(this.txtHastaAdi);
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Panel2.Controls.Add(this.btnFind);
            this.splitContainer1.Size = new System.Drawing.Size(800, 387);
            this.splitContainer1.SplitterDistance = 668;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataListPatient
            // 
            this.dataListPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataListPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataListPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListPatient.Location = new System.Drawing.Point(0, 0);
            this.dataListPatient.MultiSelect = false;
            this.dataListPatient.Name = "dataListPatient";
            this.dataListPatient.ReadOnly = true;
            this.dataListPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListPatient.Size = new System.Drawing.Size(664, 383);
            this.dataListPatient.TabIndex = 0;
            this.dataListPatient.DoubleClick += new System.EventHandler(this.dataListPatient_DoubleClick);
            // 
            // btnDefault
            // 
            this.btnDefault.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDefault.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDefault.Location = new System.Drawing.Point(0, 183);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(124, 59);
            this.btnDefault.TabIndex = 7;
            this.btnDefault.Text = "Sıfırla";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // rdProt
            // 
            this.rdProt.AutoSize = true;
            this.rdProt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rdProt.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdProt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdProt.Location = new System.Drawing.Point(0, 242);
            this.rdProt.Name = "rdProt";
            this.rdProt.Size = new System.Drawing.Size(124, 21);
            this.rdProt.TabIndex = 6;
            this.rdProt.TabStop = true;
            this.rdProt.Text = "Protokol No";
            this.rdProt.UseVisualStyleBackColor = true;
            this.rdProt.CheckedChanged += new System.EventHandler(this.rdProt_CheckedChanged);
            // 
            // txtProtNo
            // 
            this.txtProtNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtProtNo.Location = new System.Drawing.Point(0, 263);
            this.txtProtNo.Name = "txtProtNo";
            this.txtProtNo.Size = new System.Drawing.Size(124, 20);
            this.txtProtNo.TabIndex = 5;
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rdName.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdName.Location = new System.Drawing.Point(0, 283);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(124, 21);
            this.rdName.TabIndex = 4;
            this.rdName.TabStop = true;
            this.rdName.Text = "Isim";
            this.rdName.UseVisualStyleBackColor = true;
            this.rdName.CheckedChanged += new System.EventHandler(this.rdName_CheckedChanged);
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtHastaAdi.Location = new System.Drawing.Point(0, 304);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(124, 20);
            this.txtHastaAdi.TabIndex = 3;
            this.txtHastaAdi.TextChanged += new System.EventHandler(this.txtHastaAdi_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 59);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFind
            // 
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFind.Location = new System.Drawing.Point(0, 324);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(124, 59);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Bul";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // frmFindPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "frmFindPatient";
            this.ShowIcon = false;
            this.Text = "Hasta Bul";
            this.Load += new System.EventHandler(this.frmFindPatient_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataListPatient;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.RadioButton rdProt;
        private System.Windows.Forms.TextBox txtProtNo;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.Button btnDefault;
    }
}