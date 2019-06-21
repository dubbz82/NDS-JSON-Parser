namespace NDS_JSON_Parser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtGameID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSDKVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCardType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAntiPiracy = new System.Windows.Forms.Label();
            this.dgvAlieses = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkFileLocationSD = new System.Windows.Forms.CheckBox();
            this.chkFileLocationSlot1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblClockSpeed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chk3DS = new System.Windows.Forms.CheckBox();
            this.chkDSi = new System.Windows.Forms.CheckBox();
            this.lblSDCardCompatibility = new System.Windows.Forms.Label();
            this.lblSlot1Compatibility = new System.Windows.Forms.Label();
            this.lbl3dsCompatibility = new System.Windows.Forms.Label();
            this.lblDSiCompatibility = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCompatibility = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlGameInfo = new System.Windows.Forms.Panel();
            this.dgvSDCardTesters = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlieses)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSDCardTesters)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Game ID";
            // 
            // txtGameID
            // 
            this.txtGameID.Location = new System.Drawing.Point(12, 42);
            this.txtGameID.MaxLength = 4;
            this.txtGameID.Name = "txtGameID";
            this.txtGameID.Size = new System.Drawing.Size(74, 20);
            this.txtGameID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(142, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvAlieses);
            this.groupBox1.Controls.Add(this.lblAntiPiracy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCardType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblRegion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSDKVersion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(55, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SDK Version";
            // 
            // lblSDKVersion
            // 
            this.lblSDKVersion.AutoSize = true;
            this.lblSDKVersion.Location = new System.Drawing.Point(489, 29);
            this.lblSDKVersion.Name = "lblSDKVersion";
            this.lblSDKVersion.Size = new System.Drawing.Size(0, 13);
            this.lblSDKVersion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Region";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(55, 68);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(0, 13);
            this.lblRegion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Card Type";
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Location = new System.Drawing.Point(489, 68);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(0, 13);
            this.lblCardType.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Anti-Piracy";
            // 
            // lblAntiPiracy
            // 
            this.lblAntiPiracy.AutoSize = true;
            this.lblAntiPiracy.Location = new System.Drawing.Point(74, 111);
            this.lblAntiPiracy.Name = "lblAntiPiracy";
            this.lblAntiPiracy.Size = new System.Drawing.Size(0, 13);
            this.lblAntiPiracy.TabIndex = 9;
            // 
            // dgvAlieses
            // 
            this.dgvAlieses.AllowUserToAddRows = false;
            this.dgvAlieses.AllowUserToDeleteRows = false;
            this.dgvAlieses.AllowUserToResizeColumns = false;
            this.dgvAlieses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlieses.ColumnHeadersVisible = false;
            this.dgvAlieses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlieses.EnableHeadersVisualStyles = false;
            this.dgvAlieses.Location = new System.Drawing.Point(409, 128);
            this.dgvAlieses.Name = "dgvAlieses";
            this.dgvAlieses.ReadOnly = true;
            this.dgvAlieses.RowHeadersVisible = false;
            this.dgvAlieses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlieses.Size = new System.Drawing.Size(362, 63);
            this.dgvAlieses.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Aliases";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(6, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1036, 208);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NDS Bootstrap";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAdditionalNotes);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dgvSDCardTesters);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblCompatibility);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblDSiCompatibility);
            this.groupBox3.Controls.Add(this.lbl3dsCompatibility);
            this.groupBox3.Controls.Add(this.lblSlot1Compatibility);
            this.groupBox3.Controls.Add(this.lblSDCardCompatibility);
            this.groupBox3.Controls.Add(this.chkDSi);
            this.groupBox3.Controls.Add(this.chk3DS);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblClockSpeed);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.chkFileLocationSlot1);
            this.groupBox3.Controls.Add(this.chkFileLocationSD);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblVersion);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1024, 175);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SD Card";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Version";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(56, 16);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "File Location";
            // 
            // chkFileLocationSD
            // 
            this.chkFileLocationSD.AutoCheck = false;
            this.chkFileLocationSD.AutoSize = true;
            this.chkFileLocationSD.Location = new System.Drawing.Point(80, 44);
            this.chkFileLocationSD.Name = "chkFileLocationSD";
            this.chkFileLocationSD.Size = new System.Drawing.Size(66, 17);
            this.chkFileLocationSD.TabIndex = 3;
            this.chkFileLocationSD.Text = "SD Card";
            this.chkFileLocationSD.UseVisualStyleBackColor = true;
            // 
            // chkFileLocationSlot1
            // 
            this.chkFileLocationSlot1.AutoCheck = false;
            this.chkFileLocationSlot1.AutoSize = true;
            this.chkFileLocationSlot1.Location = new System.Drawing.Point(152, 44);
            this.chkFileLocationSlot1.Name = "chkFileLocationSlot1";
            this.chkFileLocationSlot1.Size = new System.Drawing.Size(53, 17);
            this.chkFileLocationSlot1.TabIndex = 4;
            this.chkFileLocationSlot1.Text = "Slot-1";
            this.chkFileLocationSlot1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Clock Speed";
            // 
            // lblClockSpeed
            // 
            this.lblClockSpeed.AutoSize = true;
            this.lblClockSpeed.Location = new System.Drawing.Point(81, 75);
            this.lblClockSpeed.Name = "lblClockSpeed";
            this.lblClockSpeed.Size = new System.Drawing.Size(0, 13);
            this.lblClockSpeed.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Console Tested On";
            // 
            // chk3DS
            // 
            this.chk3DS.AutoCheck = false;
            this.chk3DS.AutoSize = true;
            this.chk3DS.Location = new System.Drawing.Point(403, 43);
            this.chk3DS.Name = "chk3DS";
            this.chk3DS.Size = new System.Drawing.Size(47, 17);
            this.chk3DS.TabIndex = 8;
            this.chk3DS.Text = "3DS";
            this.chk3DS.UseVisualStyleBackColor = true;
            // 
            // chkDSi
            // 
            this.chkDSi.AutoCheck = false;
            this.chkDSi.AutoSize = true;
            this.chkDSi.Location = new System.Drawing.Point(456, 43);
            this.chkDSi.Name = "chkDSi";
            this.chkDSi.Size = new System.Drawing.Size(43, 17);
            this.chkDSi.TabIndex = 9;
            this.chkDSi.Text = "DSi";
            this.chkDSi.UseVisualStyleBackColor = true;
            // 
            // lblSDCardCompatibility
            // 
            this.lblSDCardCompatibility.AutoSize = true;
            this.lblSDCardCompatibility.Location = new System.Drawing.Point(88, 59);
            this.lblSDCardCompatibility.Name = "lblSDCardCompatibility";
            this.lblSDCardCompatibility.Size = new System.Drawing.Size(0, 13);
            this.lblSDCardCompatibility.TabIndex = 10;
            // 
            // lblSlot1Compatibility
            // 
            this.lblSlot1Compatibility.AutoSize = true;
            this.lblSlot1Compatibility.Location = new System.Drawing.Point(168, 59);
            this.lblSlot1Compatibility.Name = "lblSlot1Compatibility";
            this.lblSlot1Compatibility.Size = new System.Drawing.Size(0, 13);
            this.lblSlot1Compatibility.TabIndex = 11;
            // 
            // lbl3dsCompatibility
            // 
            this.lbl3dsCompatibility.AutoSize = true;
            this.lbl3dsCompatibility.Location = new System.Drawing.Point(400, 59);
            this.lbl3dsCompatibility.Name = "lbl3dsCompatibility";
            this.lbl3dsCompatibility.Size = new System.Drawing.Size(0, 13);
            this.lbl3dsCompatibility.TabIndex = 12;
            // 
            // lblDSiCompatibility
            // 
            this.lblDSiCompatibility.AutoSize = true;
            this.lblDSiCompatibility.Location = new System.Drawing.Point(458, 59);
            this.lblDSiCompatibility.Name = "lblDSiCompatibility";
            this.lblDSiCompatibility.Size = new System.Drawing.Size(0, 13);
            this.lblDSiCompatibility.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Compatibility";
            // 
            // lblCompatibility
            // 
            this.lblCompatibility.AutoSize = true;
            this.lblCompatibility.Location = new System.Drawing.Point(296, 88);
            this.lblCompatibility.Name = "lblCompatibility";
            this.lblCompatibility.Size = new System.Drawing.Size(0, 13);
            this.lblCompatibility.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(708, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Testers";
            // 
            // pnlGameInfo
            // 
            this.pnlGameInfo.Controls.Add(this.groupBox1);
            this.pnlGameInfo.Controls.Add(this.groupBox2);
            this.pnlGameInfo.Location = new System.Drawing.Point(12, 89);
            this.pnlGameInfo.Name = "pnlGameInfo";
            this.pnlGameInfo.Size = new System.Drawing.Size(1061, 449);
            this.pnlGameInfo.TabIndex = 5;
            this.pnlGameInfo.Visible = false;
            // 
            // dgvSDCardTesters
            // 
            this.dgvSDCardTesters.AllowUserToAddRows = false;
            this.dgvSDCardTesters.AllowUserToDeleteRows = false;
            this.dgvSDCardTesters.AllowUserToResizeColumns = false;
            this.dgvSDCardTesters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSDCardTesters.ColumnHeadersVisible = false;
            this.dgvSDCardTesters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSDCardTesters.EnableHeadersVisualStyles = false;
            this.dgvSDCardTesters.Location = new System.Drawing.Point(711, 59);
            this.dgvSDCardTesters.Name = "dgvSDCardTesters";
            this.dgvSDCardTesters.RowHeadersVisible = false;
            this.dgvSDCardTesters.Size = new System.Drawing.Size(307, 110);
            this.dgvSDCardTesters.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Additional Notes";
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Location = new System.Drawing.Point(10, 130);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(0, 13);
            this.lblAdditionalNotes.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 549);
            this.Controls.Add(this.pnlGameInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtGameID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NDS Api Frontend by dubbz82";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlieses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlGameInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSDCardTesters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGameID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSDKVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAntiPiracy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAlieses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkFileLocationSlot1;
        private System.Windows.Forms.CheckBox chkFileLocationSD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblClockSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkDSi;
        private System.Windows.Forms.CheckBox chk3DS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSlot1Compatibility;
        private System.Windows.Forms.Label lblSDCardCompatibility;
        private System.Windows.Forms.Label lblDSiCompatibility;
        private System.Windows.Forms.Label lbl3dsCompatibility;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCompatibility;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlGameInfo;
        private System.Windows.Forms.DataGridView dgvSDCardTesters;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.Label label14;
    }
}

