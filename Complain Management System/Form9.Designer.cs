namespace Complain_Management_System
{
    partial class Form9
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSearchCompID = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchType = new System.Windows.Forms.Button();
            this.dgvPComplain = new System.Windows.Forms.DataGridView();
            this.btnEditCus = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btntake = new System.Windows.Forms.Button();
            this.txtTAcID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPComplain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(267, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 70);
            this.panel1.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 39);
            this.label7.TabIndex = 7;
            this.label7.Text = "View Complain";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(21, 659);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 33);
            this.btnBack.TabIndex = 78;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCusID
            // 
            this.txtCusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(165, 44);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(234, 26);
            this.txtCusID.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "Complain ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 82;
            this.label9.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Emergency",
            "Warrenty",
            "Normal"});
            this.cmbType.Location = new System.Drawing.Point(165, 92);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(234, 28);
            this.cmbType.TabIndex = 83;
            // 
            // btnSearchCompID
            // 
            this.btnSearchCompID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSearchCompID.Location = new System.Drawing.Point(461, 41);
            this.btnSearchCompID.Name = "btnSearchCompID";
            this.btnSearchCompID.Size = new System.Drawing.Size(204, 34);
            this.btnSearchCompID.TabIndex = 87;
            this.btnSearchCompID.Text = "Search";
            this.btnSearchCompID.UseVisualStyleBackColor = false;
            this.btnSearchCompID.Click += new System.EventHandler(this.btnSearchCompID_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnSearchType);
            this.groupBox1.Controls.Add(this.dgvPComplain);
            this.groupBox1.Controls.Add(this.btnSearchCompID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCusID);
            this.groupBox1.Location = new System.Drawing.Point(21, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 477);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearchType
            // 
            this.btnSearchType.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSearchType.Location = new System.Drawing.Point(461, 89);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.Size = new System.Drawing.Size(204, 34);
            this.btnSearchType.TabIndex = 89;
            this.btnSearchType.Text = "Search";
            this.btnSearchType.UseVisualStyleBackColor = false;
            this.btnSearchType.Click += new System.EventHandler(this.btnSearchType_Click);
            // 
            // dgvPComplain
            // 
            this.dgvPComplain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPComplain.Location = new System.Drawing.Point(43, 144);
            this.dgvPComplain.Name = "dgvPComplain";
            this.dgvPComplain.RowHeadersWidth = 51;
            this.dgvPComplain.RowTemplate.Height = 24;
            this.dgvPComplain.Size = new System.Drawing.Size(732, 303);
            this.dgvPComplain.TabIndex = 88;
            this.dgvPComplain.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPComplain_CellMouseClick);
            // 
            // btnEditCus
            // 
            this.btnEditCus.Location = new System.Drawing.Point(64, 589);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Size = new System.Drawing.Size(171, 44);
            this.btnEditCus.TabIndex = 89;
            this.btnEditCus.Text = "Edit Customer";
            this.btnEditCus.UseVisualStyleBackColor = true;
            this.btnEditCus.Click += new System.EventHandler(this.btnEditCus_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(18, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 17);
            this.lblID.TabIndex = 90;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // btntake
            // 
            this.btntake.Location = new System.Drawing.Point(662, 589);
            this.btntake.Name = "btntake";
            this.btntake.Size = new System.Drawing.Size(172, 44);
            this.btntake.TabIndex = 91;
            this.btntake.Text = "Take Action";
            this.btntake.UseVisualStyleBackColor = true;
            this.btntake.Click += new System.EventHandler(this.btntake_Click);
            // 
            // txtTAcID
            // 
            this.txtTAcID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTAcID.Location = new System.Drawing.Point(466, 597);
            this.txtTAcID.Name = "txtTAcID";
            this.txtTAcID.ReadOnly = true;
            this.txtTAcID.Size = new System.Drawing.Size(174, 26);
            this.txtTAcID.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "Complain ID";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTAcID);
            this.Controls.Add(this.btntake);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnEditCus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Complain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPComplain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSearchCompID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPComplain;
        private System.Windows.Forms.Button btnEditCus;
        private System.Windows.Forms.Button btnSearchType;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btntake;
        private System.Windows.Forms.TextBox txtTAcID;
        private System.Windows.Forms.Label label1;
    }
}