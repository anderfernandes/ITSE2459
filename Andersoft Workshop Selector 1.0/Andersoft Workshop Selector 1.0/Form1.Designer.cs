namespace Andersoft_Workshop_Selector_1._0
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
            this.lboWorkshop = new System.Windows.Forms.ListBox();
            this.lboLocation = new System.Windows.Forms.ListBox();
            this.lblRegistrationPrice = new System.Windows.Forms.Label();
            this.lblLodgingPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboWorkshop
            // 
            this.lboWorkshop.FormattingEnabled = true;
            this.lboWorkshop.Items.AddRange(new object[] {
            "Handling Stress (3 days)",
            "Time Management (3 days)",
            "Supervision Skills (3 days)",
            "Negotiation (5 days)",
            "How to Interview (1 day)"});
            this.lboWorkshop.Location = new System.Drawing.Point(12, 34);
            this.lboWorkshop.Name = "lboWorkshop";
            this.lboWorkshop.Size = new System.Drawing.Size(142, 82);
            this.lboWorkshop.TabIndex = 1;
            // 
            // lboLocation
            // 
            this.lboLocation.FormattingEnabled = true;
            this.lboLocation.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.lboLocation.Location = new System.Drawing.Point(180, 34);
            this.lboLocation.Name = "lboLocation";
            this.lboLocation.Size = new System.Drawing.Size(143, 82);
            this.lboLocation.TabIndex = 2;
            // 
            // lblRegistrationPrice
            // 
            this.lblRegistrationPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistrationPrice.Location = new System.Drawing.Point(12, 133);
            this.lblRegistrationPrice.Name = "lblRegistrationPrice";
            this.lblRegistrationPrice.Size = new System.Drawing.Size(311, 23);
            this.lblRegistrationPrice.TabIndex = 2;
            // 
            // lblLodgingPrice
            // 
            this.lblLodgingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLodgingPrice.Location = new System.Drawing.Point(12, 158);
            this.lblLodgingPrice.Name = "lblLodgingPrice";
            this.lblLodgingPrice.Size = new System.Drawing.Size(311, 23);
            this.lblLodgingPrice.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(12, 184);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(311, 23);
            this.lblTotal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Select a Workshop:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select a Location:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(34, 225);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(225, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(130, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 263);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblLodgingPrice);
            this.Controls.Add(this.lblRegistrationPrice);
            this.Controls.Add(this.lboLocation);
            this.Controls.Add(this.lboWorkshop);
            this.Name = "Form1";
            this.Text = "Andersoft Workshop Selector 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboWorkshop;
        private System.Windows.Forms.ListBox lboLocation;
        private System.Windows.Forms.Label lblRegistrationPrice;
        private System.Windows.Forms.Label lblLodgingPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
    }
}

