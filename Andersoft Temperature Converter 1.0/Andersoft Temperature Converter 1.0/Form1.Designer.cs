namespace Andersoft_Temperature_Converter_1._0
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.btnToKelvin = new System.Windows.Forms.Button();
            this.btnToRankine = new System.Windows.Forms.Button();
            this.btnToNewton = new System.Windows.Forms.Button();
            this.btnToDelisle = new System.Windows.Forms.Button();
            this.btnToAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.lblRankine = new System.Windows.Forms.Label();
            this.lblNewton = new System.Windows.Forms.Label();
            this.lblDelisle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit:";
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(158, 24);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.tbFahrenheit.TabIndex = 1;
            // 
            // btnToKelvin
            // 
            this.btnToKelvin.Location = new System.Drawing.Point(12, 60);
            this.btnToKelvin.Name = "btnToKelvin";
            this.btnToKelvin.Size = new System.Drawing.Size(146, 23);
            this.btnToKelvin.TabIndex = 2;
            this.btnToKelvin.Text = "Convert to &Kelvin";
            this.btnToKelvin.UseVisualStyleBackColor = true;
            this.btnToKelvin.Click += new System.EventHandler(this.btnToKelvin_Click);
            // 
            // btnToRankine
            // 
            this.btnToRankine.Location = new System.Drawing.Point(12, 89);
            this.btnToRankine.Name = "btnToRankine";
            this.btnToRankine.Size = new System.Drawing.Size(146, 23);
            this.btnToRankine.TabIndex = 3;
            this.btnToRankine.Text = "Convert to &Rankine";
            this.btnToRankine.UseVisualStyleBackColor = true;
            this.btnToRankine.Click += new System.EventHandler(this.btnToRankine_Click);
            // 
            // btnToNewton
            // 
            this.btnToNewton.Location = new System.Drawing.Point(12, 118);
            this.btnToNewton.Name = "btnToNewton";
            this.btnToNewton.Size = new System.Drawing.Size(146, 23);
            this.btnToNewton.TabIndex = 4;
            this.btnToNewton.Text = "Convert to &Newton";
            this.btnToNewton.UseVisualStyleBackColor = true;
            this.btnToNewton.Click += new System.EventHandler(this.btnToNewton_Click);
            // 
            // btnToDelisle
            // 
            this.btnToDelisle.Location = new System.Drawing.Point(12, 147);
            this.btnToDelisle.Name = "btnToDelisle";
            this.btnToDelisle.Size = new System.Drawing.Size(146, 23);
            this.btnToDelisle.TabIndex = 5;
            this.btnToDelisle.Text = "Convert to &Delisle";
            this.btnToDelisle.UseVisualStyleBackColor = true;
            this.btnToDelisle.Click += new System.EventHandler(this.btnToDelisle_Click);
            // 
            // btnToAll
            // 
            this.btnToAll.Location = new System.Drawing.Point(12, 176);
            this.btnToAll.Name = "btnToAll";
            this.btnToAll.Size = new System.Drawing.Size(146, 23);
            this.btnToAll.TabIndex = 6;
            this.btnToAll.Text = "Convert to &All Temperatures";
            this.btnToAll.UseVisualStyleBackColor = true;
            this.btnToAll.Click += new System.EventHandler(this.btnToAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(173, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblKelvin
            // 
            this.lblKelvin.Location = new System.Drawing.Point(173, 60);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(161, 23);
            this.lblKelvin.TabIndex = 9;
            this.lblKelvin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRankine
            // 
            this.lblRankine.Location = new System.Drawing.Point(173, 89);
            this.lblRankine.Name = "lblRankine";
            this.lblRankine.Size = new System.Drawing.Size(161, 23);
            this.lblRankine.TabIndex = 10;
            this.lblRankine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewton
            // 
            this.lblNewton.Location = new System.Drawing.Point(173, 118);
            this.lblNewton.Name = "lblNewton";
            this.lblNewton.Size = new System.Drawing.Size(161, 23);
            this.lblNewton.TabIndex = 11;
            this.lblNewton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDelisle
            // 
            this.lblDelisle.Location = new System.Drawing.Point(173, 147);
            this.lblDelisle.Name = "lblDelisle";
            this.lblDelisle.Size = new System.Drawing.Size(161, 23);
            this.lblDelisle.TabIndex = 12;
            this.lblDelisle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(77, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 250);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDelisle);
            this.Controls.Add(this.lblNewton);
            this.Controls.Add(this.lblRankine);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToAll);
            this.Controls.Add(this.btnToDelisle);
            this.Controls.Add(this.btnToNewton);
            this.Controls.Add(this.btnToRankine);
            this.Controls.Add(this.btnToKelvin);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Andersoft Temperature Converter 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.Button btnToKelvin;
        private System.Windows.Forms.Button btnToRankine;
        private System.Windows.Forms.Button btnToNewton;
        private System.Windows.Forms.Button btnToDelisle;
        private System.Windows.Forms.Button btnToAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Label lblRankine;
        private System.Windows.Forms.Label lblNewton;
        private System.Windows.Forms.Label lblDelisle;
        private System.Windows.Forms.Button btnClear;
    }
}

