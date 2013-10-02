namespace Math_Methods
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.btnCalculateCosine = new System.Windows.Forms.Button();
            this.btnCalculateTangent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.lblTrigResult = new System.Windows.Forms.Label();
            this.btnCalculateLog = new System.Windows.Forms.Button();
            this.lblLogResult = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPowerResult = new System.Windows.Forms.Label();
            this.btnCalculatePower = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPower = new System.Windows.Forms.TextBox();
            this.btnCalculateSine = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculateSine);
            this.groupBox1.Controls.Add(this.lblTrigResult);
            this.groupBox1.Controls.Add(this.btnCalculateTangent);
            this.groupBox1.Controls.Add(this.btnCalculateCosine);
            this.groupBox1.Controls.Add(this.tbAngle);
            this.groupBox1.Controls.Add(this.lblAngle);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trigonometric Functions";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(89, 33);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(87, 13);
            this.lblAngle.TabIndex = 0;
            this.lblAngle.Text = "Angle (degrees) :";
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(182, 30);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(100, 20);
            this.tbAngle.TabIndex = 1;
            // 
            // btnCalculateCosine
            // 
            this.btnCalculateCosine.Location = new System.Drawing.Point(155, 67);
            this.btnCalculateCosine.Name = "btnCalculateCosine";
            this.btnCalculateCosine.Size = new System.Drawing.Size(104, 23);
            this.btnCalculateCosine.TabIndex = 3;
            this.btnCalculateCosine.Text = "Calculate &Cosine";
            this.btnCalculateCosine.UseVisualStyleBackColor = true;
            this.btnCalculateCosine.Click += new System.EventHandler(this.btnCalculateCosine_Click);
            // 
            // btnCalculateTangent
            // 
            this.btnCalculateTangent.Location = new System.Drawing.Point(265, 67);
            this.btnCalculateTangent.Name = "btnCalculateTangent";
            this.btnCalculateTangent.Size = new System.Drawing.Size(104, 23);
            this.btnCalculateTangent.TabIndex = 4;
            this.btnCalculateTangent.Text = "Calculate &Tangent";
            this.btnCalculateTangent.UseVisualStyleBackColor = true;
            this.btnCalculateTangent.Click += new System.EventHandler(this.btnCalculateTangent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLogResult);
            this.groupBox2.Controls.Add(this.btnCalculateLog);
            this.groupBox2.Controls.Add(this.tbLog);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logarithm Base 10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log10:";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(160, 25);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(100, 20);
            this.tbLog.TabIndex = 5;
            // 
            // lblTrigResult
            // 
            this.lblTrigResult.Location = new System.Drawing.Point(45, 105);
            this.lblTrigResult.Name = "lblTrigResult";
            this.lblTrigResult.Size = new System.Drawing.Size(324, 23);
            this.lblTrigResult.TabIndex = 5;
            this.lblTrigResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculateLog
            // 
            this.btnCalculateLog.Location = new System.Drawing.Point(155, 61);
            this.btnCalculateLog.Name = "btnCalculateLog";
            this.btnCalculateLog.Size = new System.Drawing.Size(104, 23);
            this.btnCalculateLog.TabIndex = 6;
            this.btnCalculateLog.Text = "Calculate &Log10";
            this.btnCalculateLog.UseVisualStyleBackColor = true;
            this.btnCalculateLog.Click += new System.EventHandler(this.btnCalculateLog_Click);
            // 
            // lblLogResult
            // 
            this.lblLogResult.Location = new System.Drawing.Point(44, 96);
            this.lblLogResult.Name = "lblLogResult";
            this.lblLogResult.Size = new System.Drawing.Size(325, 23);
            this.lblLogResult.TabIndex = 6;
            this.lblLogResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPower);
            this.groupBox3.Controls.Add(this.lblPowerResult);
            this.groupBox3.Controls.Add(this.tbNumber);
            this.groupBox3.Controls.Add(this.btnCalculatePower);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(24, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 120);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Power";
            // 
            // lblPowerResult
            // 
            this.lblPowerResult.Location = new System.Drawing.Point(44, 85);
            this.lblPowerResult.Name = "lblPowerResult";
            this.lblPowerResult.Size = new System.Drawing.Size(325, 23);
            this.lblPowerResult.TabIndex = 10;
            this.lblPowerResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculatePower
            // 
            this.btnCalculatePower.Location = new System.Drawing.Point(150, 55);
            this.btnCalculatePower.Name = "btnCalculatePower";
            this.btnCalculatePower.Size = new System.Drawing.Size(104, 23);
            this.btnCalculatePower.TabIndex = 9;
            this.btnCalculatePower.Text = "Calculate &Power";
            this.btnCalculatePower.UseVisualStyleBackColor = true;
            this.btnCalculatePower.Click += new System.EventHandler(this.btnCalculatePower_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(65, 19);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "to the";
            // 
            // tbPower
            // 
            this.tbPower.Location = new System.Drawing.Point(229, 22);
            this.tbPower.Name = "tbPower";
            this.tbPower.Size = new System.Drawing.Size(100, 20);
            this.tbPower.TabIndex = 8;
            // 
            // btnCalculateSine
            // 
            this.btnCalculateSine.Location = new System.Drawing.Point(44, 67);
            this.btnCalculateSine.Name = "btnCalculateSine";
            this.btnCalculateSine.Size = new System.Drawing.Size(104, 23);
            this.btnCalculateSine.TabIndex = 2;
            this.btnCalculateSine.Text = "Calculate &Sine";
            this.btnCalculateSine.UseVisualStyleBackColor = true;
            this.btnCalculateSine.Click += new System.EventHandler(this.btnCalculateSine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Math Methods";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculateTangent;
        private System.Windows.Forms.Button btnCalculateCosine;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrigResult;
        private System.Windows.Forms.Button btnCalculateLog;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label lblLogResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPowerResult;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnCalculatePower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPower;
        private System.Windows.Forms.Button btnCalculateSine;
    }
}

