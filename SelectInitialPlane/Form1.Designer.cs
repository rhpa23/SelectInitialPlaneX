namespace SelectInitialPlane
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
            this.cmbInstaledPlanes = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblSelNewPlane = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAmountPlanes = new System.Windows.Forms.Label();
            this.pbxThumbnail = new System.Windows.Forms.PictureBox();
            this.lblAtcAirline = new System.Windows.Forms.Label();
            this.lblAtcFlightNumber = new System.Windows.Forms.Label();
            this.lblAtcId = new System.Windows.Forms.Label();
            this.lblAtcParkingCodes = new System.Windows.Forms.Label();
            this.lblUiCreatedBy = new System.Windows.Forms.Label();
            this.lblUiManufacturer = new System.Windows.Forms.Label();
            this.lblUiType = new System.Windows.Forms.Label();
            this.lblUiTypeRole = new System.Windows.Forms.Label();
            this.lblUiVariation = new System.Windows.Forms.Label();
            this.lblAirlineName = new System.Windows.Forms.Label();
            this.lblPathFS = new System.Windows.Forms.Label();
            this.lblCurrentSituation = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolTipForm = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnail)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbInstaledPlanes
            // 
            this.cmbInstaledPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstaledPlanes.FormattingEnabled = true;
            this.cmbInstaledPlanes.Location = new System.Drawing.Point(18, 27);
            this.cmbInstaledPlanes.Name = "cmbInstaledPlanes";
            this.cmbInstaledPlanes.Size = new System.Drawing.Size(267, 21);
            this.cmbInstaledPlanes.TabIndex = 0;
            this.cmbInstaledPlanes.SelectedIndexChanged += new System.EventHandler(this.cmbInstaledPlanes_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(124, 483);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Comfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblSelNewPlane
            // 
            this.lblSelNewPlane.AutoSize = true;
            this.lblSelNewPlane.Location = new System.Drawing.Point(15, 11);
            this.lblSelNewPlane.Name = "lblSelNewPlane";
            this.lblSelNewPlane.Size = new System.Drawing.Size(73, 13);
            this.lblSelNewPlane.TabIndex = 2;
            this.lblSelNewPlane.Text = "Select Aircraft";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbxThumbnail);
            this.groupBox1.Location = new System.Drawing.Point(18, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(18, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 194);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
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
            // pbxThumbnail
            // 
            this.pbxThumbnail.Location = new System.Drawing.Point(5, 14);
            this.pbxThumbnail.Name = "pbxThumbnail";
            this.pbxThumbnail.Size = new System.Drawing.Size(256, 128);
            this.pbxThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxThumbnail.TabIndex = 0;
            this.pbxThumbnail.TabStop = false;
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
            // lblAtcFlightNumber
            // 
            this.lblAtcFlightNumber.AutoSize = true;
            this.lblAtcFlightNumber.Location = new System.Drawing.Point(11, 53);
            this.lblAtcFlightNumber.Name = "lblAtcFlightNumber";
            this.lblAtcFlightNumber.Size = new System.Drawing.Size(73, 13);
            this.lblAtcFlightNumber.TabIndex = 1;
            this.lblAtcFlightNumber.Text = "Flight number:";
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
            // lblAtcParkingCodes
            // 
            this.lblAtcParkingCodes.AutoSize = true;
            this.lblAtcParkingCodes.Location = new System.Drawing.Point(11, 87);
            this.lblAtcParkingCodes.Name = "lblAtcParkingCodes";
            this.lblAtcParkingCodes.Size = new System.Drawing.Size(78, 13);
            this.lblAtcParkingCodes.TabIndex = 3;
            this.lblAtcParkingCodes.Text = "Parking codes:";
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
            // lblUiManufacturer
            // 
            this.lblUiManufacturer.AutoSize = true;
            this.lblUiManufacturer.Location = new System.Drawing.Point(11, 121);
            this.lblUiManufacturer.Name = "lblUiManufacturer";
            this.lblUiManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblUiManufacturer.TabIndex = 5;
            this.lblUiManufacturer.Text = "Manufacturer:";
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
            // lblUiTypeRole
            // 
            this.lblUiTypeRole.AutoSize = true;
            this.lblUiTypeRole.Location = new System.Drawing.Point(11, 155);
            this.lblUiTypeRole.Name = "lblUiTypeRole";
            this.lblUiTypeRole.Size = new System.Drawing.Size(54, 13);
            this.lblUiTypeRole.TabIndex = 7;
            this.lblUiTypeRole.Text = "Type role:";
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
            // lblAirlineName
            // 
            this.lblAirlineName.AutoSize = true;
            this.lblAirlineName.Location = new System.Drawing.Point(11, 20);
            this.lblAirlineName.Name = "lblAirlineName";
            this.lblAirlineName.Size = new System.Drawing.Size(67, 13);
            this.lblAirlineName.TabIndex = 9;
            this.lblAirlineName.Text = "Airline name:";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAmountPlanes);
            this.groupBox3.Controls.Add(this.lblCurrentSituation);
            this.groupBox3.Controls.Add(this.lblPathFS);
            this.groupBox3.Location = new System.Drawing.Point(18, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 68);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra Info";
            // 
            // toolTipForm
            // 
            this.toolTipForm.AutoPopDelay = 25000;
            this.toolTipForm.InitialDelay = 500;
            this.toolTipForm.IsBalloon = true;
            this.toolTipForm.ReshowDelay = 100;
            this.toolTipForm.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipForm.ToolTipTitle = "Description:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSelNewPlane);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbInstaledPlanes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Initial FSX Aircraft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnail)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbInstaledPlanes;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblSelNewPlane;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAmountPlanes;
        private System.Windows.Forms.PictureBox pbxThumbnail;
        private System.Windows.Forms.Label lblUiVariation;
        private System.Windows.Forms.Label lblUiTypeRole;
        private System.Windows.Forms.Label lblUiType;
        private System.Windows.Forms.Label lblUiManufacturer;
        private System.Windows.Forms.Label lblUiCreatedBy;
        private System.Windows.Forms.Label lblAtcParkingCodes;
        private System.Windows.Forms.Label lblAtcId;
        private System.Windows.Forms.Label lblAtcFlightNumber;
        private System.Windows.Forms.Label lblAtcAirline;
        private System.Windows.Forms.Label lblAirlineName;
        private System.Windows.Forms.Label lblPathFS;
        private System.Windows.Forms.Label lblCurrentSituation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolTip toolTipForm;
    }
}

