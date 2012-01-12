namespace T19_Auto_Dealer_JJR
{
    partial class AutoDealer
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
            this.cboModel = new System.Windows.Forms.ComboBox ( );
            this.gbxParts = new System.Windows.Forms.GroupBox ( );
            this.gbxPartsSubtotal = new System.Windows.Forms.GroupBox ( );
            this.lblPartsSubtotal = new System.Windows.Forms.Label ( );
            this.lblPartsQuant = new System.Windows.Forms.Label ( );
            this.gbxShipping = new System.Windows.Forms.GroupBox ( );
            this.radDelivery = new System.Windows.Forms.RadioButton ( );
            this.radPickup = new System.Windows.Forms.RadioButton ( );
            this.txtPartsQuantity = new System.Windows.Forms.TextBox ( );
            this.txtNumber = new System.Windows.Forms.TextBox ( );
            this.txtPartName = new System.Windows.Forms.TextBox ( );
            this.lblPartNumber = new System.Windows.Forms.Label ( );
            this.lblPartName = new System.Windows.Forms.Label ( );
            this.gbxCars = new System.Windows.Forms.GroupBox ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.lblSubtotal = new System.Windows.Forms.Label ( );
            this.txtQuantity = new System.Windows.Forms.TextBox ( );
            this.lblQuantity = new System.Windows.Forms.Label ( );
            this.gbxSpecs = new System.Windows.Forms.GroupBox ( );
            this.chkGPS = new System.Windows.Forms.CheckBox ( );
            this.chkStereo = new System.Windows.Forms.CheckBox ( );
            this.chkCruise = new System.Windows.Forms.CheckBox ( );
            this.chkAC = new System.Windows.Forms.CheckBox ( );
            this.lblColor = new System.Windows.Forms.Label ( );
            this.lblModel = new System.Windows.Forms.Label ( );
            this.gbxSeats = new System.Windows.Forms.GroupBox ( );
            this.radCloth = new System.Windows.Forms.RadioButton ( );
            this.radLeather = new System.Windows.Forms.RadioButton ( );
            this.cboColor = new System.Windows.Forms.ComboBox ( );
            this.gbxTransmission = new System.Windows.Forms.GroupBox ( );
            this.radManual = new System.Windows.Forms.RadioButton ( );
            this.radAuto = new System.Windows.Forms.RadioButton ( );
            this.btnBuy = new System.Windows.Forms.Button ( );
            this.gbxTotal = new System.Windows.Forms.GroupBox ( );
            this.lblTotal = new System.Windows.Forms.Label ( );
            this.gbxParts.SuspendLayout ( );
            this.gbxPartsSubtotal.SuspendLayout ( );
            this.gbxShipping.SuspendLayout ( );
            this.gbxCars.SuspendLayout ( );
            this.groupBox1.SuspendLayout ( );
            this.gbxSpecs.SuspendLayout ( );
            this.gbxSeats.SuspendLayout ( );
            this.gbxTransmission.SuspendLayout ( );
            this.gbxTotal.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // cboModel
            // 
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point ( 61, 19 );
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size ( 138, 21 );
            this.cboModel.TabIndex = 0;
            // 
            // gbxParts
            // 
            this.gbxParts.Controls.Add ( this.gbxPartsSubtotal );
            this.gbxParts.Controls.Add ( this.lblPartsQuant );
            this.gbxParts.Controls.Add ( this.gbxShipping );
            this.gbxParts.Controls.Add ( this.txtPartsQuantity );
            this.gbxParts.Controls.Add ( this.txtNumber );
            this.gbxParts.Controls.Add ( this.txtPartName );
            this.gbxParts.Controls.Add ( this.lblPartNumber );
            this.gbxParts.Controls.Add ( this.lblPartName );
            this.gbxParts.Location = new System.Drawing.Point ( 25, 263 );
            this.gbxParts.Name = "gbxParts";
            this.gbxParts.Size = new System.Drawing.Size ( 284, 234 );
            this.gbxParts.TabIndex = 1;
            this.gbxParts.TabStop = false;
            this.gbxParts.Text = "Parts";
            // 
            // gbxPartsSubtotal
            // 
            this.gbxPartsSubtotal.Controls.Add ( this.lblPartsSubtotal );
            this.gbxPartsSubtotal.Location = new System.Drawing.Point ( 144, 96 );
            this.gbxPartsSubtotal.Name = "gbxPartsSubtotal";
            this.gbxPartsSubtotal.Size = new System.Drawing.Size ( 134, 65 );
            this.gbxPartsSubtotal.TabIndex = 4;
            this.gbxPartsSubtotal.TabStop = false;
            this.gbxPartsSubtotal.Text = "Parts Subtotal";
            // 
            // lblPartsSubtotal
            // 
            this.lblPartsSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartsSubtotal.Location = new System.Drawing.Point ( 24, 21 );
            this.lblPartsSubtotal.Name = "lblPartsSubtotal";
            this.lblPartsSubtotal.Size = new System.Drawing.Size ( 87, 23 );
            this.lblPartsSubtotal.TabIndex = 0;
            this.lblPartsSubtotal.Text = "$0.00";
            this.lblPartsSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartsQuant
            // 
            this.lblPartsQuant.AutoSize = true;
            this.lblPartsQuant.Location = new System.Drawing.Point ( 9, 186 );
            this.lblPartsQuant.Name = "lblPartsQuant";
            this.lblPartsQuant.Size = new System.Drawing.Size ( 81, 13 );
            this.lblPartsQuant.TabIndex = 3;
            this.lblPartsQuant.Text = "Parts Quantit&y:";
            // 
            // gbxShipping
            // 
            this.gbxShipping.Controls.Add ( this.radDelivery );
            this.gbxShipping.Controls.Add ( this.radPickup );
            this.gbxShipping.Location = new System.Drawing.Point ( 15, 96 );
            this.gbxShipping.Name = "gbxShipping";
            this.gbxShipping.Size = new System.Drawing.Size ( 112, 65 );
            this.gbxShipping.TabIndex = 2;
            this.gbxShipping.TabStop = false;
            this.gbxShipping.Text = "Shipping";
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Location = new System.Drawing.Point ( 24, 42 );
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size ( 64, 17 );
            this.radDelivery.TabIndex = 0;
            this.radDelivery.Text = "&Delivery";
            this.radDelivery.UseVisualStyleBackColor = true;
            // 
            // radPickup
            // 
            this.radPickup.AutoSize = true;
            this.radPickup.Checked = true;
            this.radPickup.Location = new System.Drawing.Point ( 7, 19 );
            this.radPickup.Name = "radPickup";
            this.radPickup.Size = new System.Drawing.Size ( 98, 17 );
            this.radPickup.TabIndex = 0;
            this.radPickup.TabStop = true;
            this.radPickup.Text = "In-St&ore Pickup";
            this.radPickup.UseVisualStyleBackColor = true;
            // 
            // txtPartsQuantity
            // 
            this.txtPartsQuantity.Location = new System.Drawing.Point ( 91, 183 );
            this.txtPartsQuantity.Name = "txtPartsQuantity";
            this.txtPartsQuantity.Size = new System.Drawing.Size ( 82, 21 );
            this.txtPartsQuantity.TabIndex = 1;
            this.txtPartsQuantity.Text = "0";
            this.txtPartsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point ( 97, 58 );
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size ( 102, 21 );
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point ( 97, 33 );
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size ( 181, 21 );
            this.txtPartName.TabIndex = 1;
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Location = new System.Drawing.Point ( 16, 61 );
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size ( 71, 13 );
            this.lblPartNumber.TabIndex = 0;
            this.lblPartNumber.Text = "Part Nu&mber:";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point ( 16, 33 );
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size ( 61, 13 );
            this.lblPartName.TabIndex = 0;
            this.lblPartName.Text = "Par&t Name:";
            // 
            // gbxCars
            // 
            this.gbxCars.Controls.Add ( this.groupBox1 );
            this.gbxCars.Controls.Add ( this.txtQuantity );
            this.gbxCars.Controls.Add ( this.lblQuantity );
            this.gbxCars.Controls.Add ( this.gbxSpecs );
            this.gbxCars.Controls.Add ( this.lblColor );
            this.gbxCars.Controls.Add ( this.lblModel );
            this.gbxCars.Controls.Add ( this.gbxSeats );
            this.gbxCars.Controls.Add ( this.cboColor );
            this.gbxCars.Controls.Add ( this.gbxTransmission );
            this.gbxCars.Controls.Add ( this.cboModel );
            this.gbxCars.Location = new System.Drawing.Point ( 25, 31 );
            this.gbxCars.Name = "gbxCars";
            this.gbxCars.Size = new System.Drawing.Size ( 429, 214 );
            this.gbxCars.TabIndex = 1;
            this.gbxCars.TabStop = false;
            this.gbxCars.Text = "Cars";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add ( this.lblSubtotal );
            this.groupBox1.Location = new System.Drawing.Point ( 282, 82 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size ( 141, 69 );
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Subtotal";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point ( 15, 25 );
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size ( 110, 19 );
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "$0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point ( 369, 19 );
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size ( 54, 21 );
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point ( 301, 22 );
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size ( 53, 13 );
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "&Quantity:";
            // 
            // gbxSpecs
            // 
            this.gbxSpecs.Controls.Add ( this.chkGPS );
            this.gbxSpecs.Controls.Add ( this.chkStereo );
            this.gbxSpecs.Controls.Add ( this.chkCruise );
            this.gbxSpecs.Controls.Add ( this.chkAC );
            this.gbxSpecs.Location = new System.Drawing.Point ( 19, 154 );
            this.gbxSpecs.Name = "gbxSpecs";
            this.gbxSpecs.Size = new System.Drawing.Size ( 404, 54 );
            this.gbxSpecs.TabIndex = 4;
            this.gbxSpecs.TabStop = false;
            this.gbxSpecs.Text = "Additional Specs";
            // 
            // chkGPS
            // 
            this.chkGPS.AutoSize = true;
            this.chkGPS.Location = new System.Drawing.Point ( 230, 19 );
            this.chkGPS.Name = "chkGPS";
            this.chkGPS.Size = new System.Drawing.Size ( 45, 17 );
            this.chkGPS.TabIndex = 0;
            this.chkGPS.Text = "&GPS";
            this.chkGPS.UseVisualStyleBackColor = true;
            // 
            // chkStereo
            // 
            this.chkStereo.AutoSize = true;
            this.chkStereo.Location = new System.Drawing.Point ( 285, 19 );
            this.chkStereo.Name = "chkStereo";
            this.chkStereo.Size = new System.Drawing.Size ( 96, 17 );
            this.chkStereo.TabIndex = 0;
            this.chkStereo.Text = "&Stereo System";
            this.chkStereo.UseVisualStyleBackColor = true;
            // 
            // chkCruise
            // 
            this.chkCruise.AutoSize = true;
            this.chkCruise.Location = new System.Drawing.Point ( 132, 19 );
            this.chkCruise.Name = "chkCruise";
            this.chkCruise.Size = new System.Drawing.Size ( 94, 17 );
            this.chkCruise.TabIndex = 0;
            this.chkCruise.Text = "Cr&uise Control";
            this.chkCruise.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            this.chkAC.AutoSize = true;
            this.chkAC.Location = new System.Drawing.Point ( 26, 19 );
            this.chkAC.Name = "chkAC";
            this.chkAC.Size = new System.Drawing.Size ( 101, 17 );
            this.chkAC.TabIndex = 0;
            this.chkAC.Text = "Ai&r Conditioning";
            this.chkAC.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point ( 16, 49 );
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size ( 32, 13 );
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "&Color";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point ( 16, 22 );
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size ( 39, 13 );
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "&Model:";
            // 
            // gbxSeats
            // 
            this.gbxSeats.Controls.Add ( this.radCloth );
            this.gbxSeats.Controls.Add ( this.radLeather );
            this.gbxSeats.Location = new System.Drawing.Point ( 133, 79 );
            this.gbxSeats.Name = "gbxSeats";
            this.gbxSeats.Size = new System.Drawing.Size ( 122, 72 );
            this.gbxSeats.TabIndex = 2;
            this.gbxSeats.TabStop = false;
            this.gbxSeats.Text = "Seats";
            // 
            // radCloth
            // 
            this.radCloth.AutoSize = true;
            this.radCloth.Location = new System.Drawing.Point ( 16, 46 );
            this.radCloth.Name = "radCloth";
            this.radCloth.Size = new System.Drawing.Size ( 50, 17 );
            this.radCloth.TabIndex = 0;
            this.radCloth.Text = "C&loth";
            this.radCloth.UseVisualStyleBackColor = true;
            // 
            // radLeather
            // 
            this.radLeather.AutoSize = true;
            this.radLeather.Checked = true;
            this.radLeather.Location = new System.Drawing.Point ( 16, 23 );
            this.radLeather.Name = "radLeather";
            this.radLeather.Size = new System.Drawing.Size ( 62, 17 );
            this.radLeather.TabIndex = 0;
            this.radLeather.TabStop = true;
            this.radLeather.Text = "&Leather";
            this.radLeather.UseVisualStyleBackColor = true;
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point ( 61, 46 );
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size ( 108, 21 );
            this.cboColor.TabIndex = 0;
            // 
            // gbxTransmission
            // 
            this.gbxTransmission.Controls.Add ( this.radManual );
            this.gbxTransmission.Controls.Add ( this.radAuto );
            this.gbxTransmission.Location = new System.Drawing.Point ( 19, 79 );
            this.gbxTransmission.Name = "gbxTransmission";
            this.gbxTransmission.Size = new System.Drawing.Size ( 108, 72 );
            this.gbxTransmission.TabIndex = 1;
            this.gbxTransmission.TabStop = false;
            this.gbxTransmission.Text = "Transmission";
            // 
            // radManual
            // 
            this.radManual.AutoSize = true;
            this.radManual.Location = new System.Drawing.Point ( 11, 46 );
            this.radManual.Name = "radManual";
            this.radManual.Size = new System.Drawing.Size ( 59, 17 );
            this.radManual.TabIndex = 0;
            this.radManual.Text = "M&anual";
            this.radManual.UseVisualStyleBackColor = true;
            // 
            // radAuto
            // 
            this.radAuto.AutoSize = true;
            this.radAuto.Checked = true;
            this.radAuto.Location = new System.Drawing.Point ( 11, 23 );
            this.radAuto.Name = "radAuto";
            this.radAuto.Size = new System.Drawing.Size ( 73, 17 );
            this.radAuto.TabIndex = 0;
            this.radAuto.TabStop = true;
            this.radAuto.Text = "&Automatic";
            this.radAuto.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point ( 345, 446 );
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size ( 103, 50 );
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "BUY!";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler ( this.btnBuy_Click );
            // 
            // gbxTotal
            // 
            this.gbxTotal.Controls.Add ( this.lblTotal );
            this.gbxTotal.Location = new System.Drawing.Point ( 343, 321 );
            this.gbxTotal.Name = "gbxTotal";
            this.gbxTotal.Size = new System.Drawing.Size ( 111, 90 );
            this.gbxTotal.TabIndex = 3;
            this.gbxTotal.TabStop = false;
            this.gbxTotal.Text = "Grand Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point ( 12, 34 );
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size ( 87, 23 );
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size ( 478, 509 );
            this.Controls.Add ( this.gbxTotal );
            this.Controls.Add ( this.btnBuy );
            this.Controls.Add ( this.gbxCars );
            this.Controls.Add ( this.gbxParts );
            this.Font = new System.Drawing.Font ( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.Name = "AutoDealer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T19 Auto Dealer JJR";
            this.Load += new System.EventHandler ( this.AutoDealer_Load );
            this.gbxParts.ResumeLayout ( false );
            this.gbxParts.PerformLayout ( );
            this.gbxPartsSubtotal.ResumeLayout ( false );
            this.gbxShipping.ResumeLayout ( false );
            this.gbxShipping.PerformLayout ( );
            this.gbxCars.ResumeLayout ( false );
            this.gbxCars.PerformLayout ( );
            this.groupBox1.ResumeLayout ( false );
            this.gbxSpecs.ResumeLayout ( false );
            this.gbxSpecs.PerformLayout ( );
            this.gbxSeats.ResumeLayout ( false );
            this.gbxSeats.PerformLayout ( );
            this.gbxTransmission.ResumeLayout ( false );
            this.gbxTransmission.PerformLayout ( );
            this.gbxTotal.ResumeLayout ( false );
            this.ResumeLayout ( false );

        }

        #endregion

        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.GroupBox gbxParts;
        private System.Windows.Forms.GroupBox gbxCars;
        private System.Windows.Forms.GroupBox gbxTransmission;
        private System.Windows.Forms.GroupBox gbxSeats;
        private System.Windows.Forms.RadioButton radCloth;
        private System.Windows.Forms.RadioButton radLeather;
        private System.Windows.Forms.RadioButton radManual;
        private System.Windows.Forms.RadioButton radAuto;
        private System.Windows.Forms.GroupBox gbxSpecs;
        private System.Windows.Forms.CheckBox chkGPS;
        private System.Windows.Forms.CheckBox chkStereo;
        private System.Windows.Forms.CheckBox chkCruise;
        private System.Windows.Forms.CheckBox chkAC;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.GroupBox gbxShipping;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblPartNumber;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.GroupBox gbxPartsSubtotal;
        private System.Windows.Forms.Label lblPartsSubtotal;
        private System.Windows.Forms.Label lblPartsQuant;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.RadioButton radPickup;
        private System.Windows.Forms.TextBox txtPartsQuantity;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.GroupBox gbxTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

