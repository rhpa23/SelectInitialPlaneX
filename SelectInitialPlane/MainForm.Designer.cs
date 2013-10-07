namespace SelectInitialPlane
{
    partial class MainForm
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
            this.pnlIcons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbAircraftManufacturer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAmountPlanes = new System.Windows.Forms.Label();
            this.lblCurrentSituation = new System.Windows.Forms.Label();
            this.lblPathFS = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAirlineName = new System.Windows.Forms.Label();
            this.lblUiVariation = new System.Windows.Forms.Label();
            this.lblUiTypeRole = new System.Windows.Forms.Label();
            this.lblUiType = new System.Windows.Forms.Label();
            this.lblUiManufacturer = new System.Windows.Forms.Label();
            this.lblUiCreatedBy = new System.Windows.Forms.Label();
            this.lblAtcParkingCodes = new System.Windows.Forms.Label();
            this.lblAtcId = new System.Windows.Forms.Label();
            this.lblAtcFlightNumber = new System.Windows.Forms.Label();
            this.lblAtcAirline = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbDX10 = new System.Windows.Forms.CheckBox();
            this.ckbBloomEffects = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbAircraftTitle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTipForm = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIcons
            // 
            this.pnlIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIcons.AutoScroll = true;
            this.pnlIcons.Location = new System.Drawing.Point(4, 6);
            this.pnlIcons.Name = "pnlIcons";
            this.pnlIcons.Size = new System.Drawing.Size(673, 667);
            this.pnlIcons.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(881, 640);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 33);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(772, 640);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbAircraftManufacturer
            // 
            this.cmbAircraftManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAircraftManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAircraftManufacturer.FormattingEnabled = true;
            this.cmbAircraftManufacturer.Location = new System.Drawing.Point(20, 56);
            this.cmbAircraftManufacturer.Name = "cmbAircraftManufacturer";
            this.cmbAircraftManufacturer.Size = new System.Drawing.Size(203, 21);
            this.cmbAircraftManufacturer.TabIndex = 3;
            this.cmbAircraftManufacturer.SelectedIndexChanged += new System.EventHandler(this.cmbAircraftManufacturer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aircraft manufacturer:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblAmountPlanes);
            this.groupBox3.Controls.Add(this.lblCurrentSituation);
            this.groupBox3.Controls.Add(this.lblPathFS);
            this.groupBox3.Location = new System.Drawing.Point(9, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 68);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra Info";
            // 
            // lblAmountPlanes
            // 
            this.lblAmountPlanes.AutoSize = true;
            this.lblAmountPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPlanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAmountPlanes.Location = new System.Drawing.Point(6, 48);
            this.lblAmountPlanes.Name = "lblAmountPlanes";
            this.lblAmountPlanes.Size = new System.Drawing.Size(95, 13);
            this.lblAmountPlanes.TabIndex = 6;
            this.lblAmountPlanes.Text = "Amount of planes: ";
            // 
            // lblCurrentSituation
            // 
            this.lblCurrentSituation.AutoSize = true;
            this.lblCurrentSituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSituation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCurrentSituation.Location = new System.Drawing.Point(6, 35);
            this.lblCurrentSituation.Name = "lblCurrentSituation";
            this.lblCurrentSituation.Size = new System.Drawing.Size(86, 13);
            this.lblCurrentSituation.TabIndex = 8;
            this.lblCurrentSituation.Text = "Current situation:";
            // 
            // lblPathFS
            // 
            this.lblPathFS.AutoSize = true;
            this.lblPathFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPathFS.Location = new System.Drawing.Point(6, 22);
            this.lblPathFS.Name = "lblPathFS";
            this.lblPathFS.Size = new System.Drawing.Size(54, 13);
            this.lblPathFS.TabIndex = 7;
            this.lblPathFS.Text = "FSX path:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblAirlineName);
            this.groupBox2.Controls.Add(this.lblUiVariation);
            this.groupBox2.Controls.Add(this.lblUiTypeRole);
            this.groupBox2.Controls.Add(this.lblUiType);
            this.groupBox2.Controls.Add(this.lblUiManufacturer);
            this.groupBox2.Controls.Add(this.lblUiCreatedBy);
            this.groupBox2.Controls.Add(this.lblAtcParkingCodes);
            this.groupBox2.Controls.Add(this.lblAtcId);
            this.groupBox2.Controls.Add(this.lblAtcFlightNumber);
            this.groupBox2.Controls.Add(this.lblAtcAirline);
            this.groupBox2.Location = new System.Drawing.Point(8, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 194);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // lblAirlineName
            // 
            this.lblAirlineName.AutoSize = true;
            this.lblAirlineName.Location = new System.Drawing.Point(11, 20);
            this.lblAirlineName.Name = "lblAirlineName";
            this.lblAirlineName.Size = new System.Drawing.Size(67, 13);
            this.lblAirlineName.TabIndex = 9;
            this.lblAirlineName.Text = "Airline name:";
            // 
            // lblUiVariation
            // 
            this.lblUiVariation.AutoSize = true;
            this.lblUiVariation.Location = new System.Drawing.Point(11, 172);
            this.lblUiVariation.Name = "lblUiVariation";
            this.lblUiVariation.Size = new System.Drawing.Size(51, 13);
            this.lblUiVariation.TabIndex = 8;
            this.lblUiVariation.Text = "Variation:";
            // 
            // lblUiTypeRole
            // 
            this.lblUiTypeRole.AutoSize = true;
            this.lblUiTypeRole.Location = new System.Drawing.Point(11, 155);
            this.lblUiTypeRole.Name = "lblUiTypeRole";
            this.lblUiTypeRole.Size = new System.Drawing.Size(54, 13);
            this.lblUiTypeRole.TabIndex = 7;
            this.lblUiTypeRole.Text = "Type role:";
            // 
            // lblUiType
            // 
            this.lblUiType.AutoSize = true;
            this.lblUiType.Location = new System.Drawing.Point(11, 138);
            this.lblUiType.Name = "lblUiType";
            this.lblUiType.Size = new System.Drawing.Size(34, 13);
            this.lblUiType.TabIndex = 6;
            this.lblUiType.Text = "Type:";
            // 
            // lblUiManufacturer
            // 
            this.lblUiManufacturer.AutoSize = true;
            this.lblUiManufacturer.Location = new System.Drawing.Point(11, 121);
            this.lblUiManufacturer.Name = "lblUiManufacturer";
            this.lblUiManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblUiManufacturer.TabIndex = 5;
            this.lblUiManufacturer.Text = "Manufacturer:";
            // 
            // lblUiCreatedBy
            // 
            this.lblUiCreatedBy.AutoSize = true;
            this.lblUiCreatedBy.Location = new System.Drawing.Point(11, 104);
            this.lblUiCreatedBy.Name = "lblUiCreatedBy";
            this.lblUiCreatedBy.Size = new System.Drawing.Size(61, 13);
            this.lblUiCreatedBy.TabIndex = 4;
            this.lblUiCreatedBy.Text = "Created by:";
            // 
            // lblAtcParkingCodes
            // 
            this.lblAtcParkingCodes.AutoSize = true;
            this.lblAtcParkingCodes.Location = new System.Drawing.Point(11, 87);
            this.lblAtcParkingCodes.Name = "lblAtcParkingCodes";
            this.lblAtcParkingCodes.Size = new System.Drawing.Size(78, 13);
            this.lblAtcParkingCodes.TabIndex = 3;
            this.lblAtcParkingCodes.Text = "Parking codes:";
            // 
            // lblAtcId
            // 
            this.lblAtcId.AutoSize = true;
            this.lblAtcId.Location = new System.Drawing.Point(11, 70);
            this.lblAtcId.Name = "lblAtcId";
            this.lblAtcId.Size = new System.Drawing.Size(38, 13);
            this.lblAtcId.TabIndex = 2;
            this.lblAtcId.Text = "Atc Id:";
            // 
            // lblAtcFlightNumber
            // 
            this.lblAtcFlightNumber.AutoSize = true;
            this.lblAtcFlightNumber.Location = new System.Drawing.Point(11, 53);
            this.lblAtcFlightNumber.Name = "lblAtcFlightNumber";
            this.lblAtcFlightNumber.Size = new System.Drawing.Size(73, 13);
            this.lblAtcFlightNumber.TabIndex = 1;
            this.lblAtcFlightNumber.Text = "Flight number:";
            // 
            // lblAtcAirline
            // 
            this.lblAtcAirline.AutoSize = true;
            this.lblAtcAirline.Location = new System.Drawing.Point(11, 36);
            this.lblAtcAirline.Name = "lblAtcAirline";
            this.lblAtcAirline.Size = new System.Drawing.Size(56, 13);
            this.lblAtcAirline.TabIndex = 0;
            this.lblAtcAirline.Text = "Atc airline:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Aircraft title";
            // 
            // ckbDX10
            // 
            this.ckbDX10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbDX10.AutoSize = true;
            this.ckbDX10.Location = new System.Drawing.Point(57, 25);
            this.ckbDX10.Name = "ckbDX10";
            this.ckbDX10.Size = new System.Drawing.Size(112, 17);
            this.ckbDX10.TabIndex = 14;
            this.ckbDX10.Text = "Enable DirectX 10";
            this.ckbDX10.UseVisualStyleBackColor = true;
            // 
            // ckbBloomEffects
            // 
            this.ckbBloomEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbBloomEffects.AutoSize = true;
            this.ckbBloomEffects.Location = new System.Drawing.Point(57, 49);
            this.ckbBloomEffects.Name = "ckbBloomEffects";
            this.ckbBloomEffects.Size = new System.Drawing.Size(127, 17);
            this.ckbBloomEffects.TabIndex = 15;
            this.ckbBloomEffects.Text = "Enable Bloom Effects";
            this.ckbBloomEffects.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckbBloomEffects);
            this.groupBox1.Controls.Add(this.ckbDX10);
            this.groupBox1.Location = new System.Drawing.Point(11, 517);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 80);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extras";
            // 
            // txbAircraftTitle
            // 
            this.txbAircraftTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAircraftTitle.Location = new System.Drawing.Point(23, 128);
            this.txbAircraftTitle.Name = "txbAircraftTitle";
            this.txbAircraftTitle.Size = new System.Drawing.Size(202, 20);
            this.txbAircraftTitle.TabIndex = 17;
            this.txbAircraftTitle.TextChanged += new System.EventHandler(this.txbAircraftTitle_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txbAircraftTitle);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbAircraftManufacturer);
            this.panel1.Location = new System.Drawing.Point(683, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 628);
            this.panel1.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 685);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlIcons);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(980, 723);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose FSX plane";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlIcons;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbAircraftManufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAmountPlanes;
        private System.Windows.Forms.Label lblCurrentSituation;
        private System.Windows.Forms.Label lblPathFS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAirlineName;
        private System.Windows.Forms.Label lblUiVariation;
        private System.Windows.Forms.Label lblUiTypeRole;
        private System.Windows.Forms.Label lblUiType;
        private System.Windows.Forms.Label lblUiManufacturer;
        private System.Windows.Forms.Label lblUiCreatedBy;
        private System.Windows.Forms.Label lblAtcParkingCodes;
        private System.Windows.Forms.Label lblAtcId;
        private System.Windows.Forms.Label lblAtcFlightNumber;
        private System.Windows.Forms.Label lblAtcAirline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbDX10;
        private System.Windows.Forms.CheckBox ckbBloomEffects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbAircraftTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipForm;
    }
}

