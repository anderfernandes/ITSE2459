namespace Food_Facts
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
            this.label1 = new System.Windows.Forms.Label();
            this.bananaRadioButton = new System.Windows.Forms.RadioButton();
            this.popcornRadioButton = new System.Windows.Forms.RadioButton();
            this.muffinRadioButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Food:";
            // 
            // bananaRadioButton
            // 
            this.bananaRadioButton.AutoSize = true;
            this.bananaRadioButton.Location = new System.Drawing.Point(45, 82);
            this.bananaRadioButton.Name = "bananaRadioButton";
            this.bananaRadioButton.Size = new System.Drawing.Size(71, 17);
            this.bananaRadioButton.TabIndex = 4;
            this.bananaRadioButton.TabStop = true;
            this.bananaRadioButton.Text = "1 Banana";
            this.bananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // popcornRadioButton
            // 
            this.popcornRadioButton.AutoSize = true;
            this.popcornRadioButton.Location = new System.Drawing.Point(45, 115);
            this.popcornRadioButton.Name = "popcornRadioButton";
            this.popcornRadioButton.Size = new System.Drawing.Size(106, 17);
            this.popcornRadioButton.TabIndex = 5;
            this.popcornRadioButton.TabStop = true;
            this.popcornRadioButton.Text = "1 cup of popcorn";
            this.popcornRadioButton.UseVisualStyleBackColor = true;
            // 
            // muffinRadioButton
            // 
            this.muffinRadioButton.AutoSize = true;
            this.muffinRadioButton.Location = new System.Drawing.Point(45, 149);
            this.muffinRadioButton.Name = "muffinRadioButton";
            this.muffinRadioButton.Size = new System.Drawing.Size(134, 17);
            this.muffinRadioButton.TabIndex = 6;
            this.muffinRadioButton.TabStop = true;
            this.muffinRadioButton.Text = "1 large blueberry muffin";
            this.muffinRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(45, 187);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(82, 36);
            this.displayButton.TabIndex = 7;
            this.displayButton.Text = "Display Food Facts";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(157, 187);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.muffinRadioButton);
            this.Controls.Add(this.popcornRadioButton);
            this.Controls.Add(this.bananaRadioButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Food Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bananaRadioButton;
        private System.Windows.Forms.RadioButton popcornRadioButton;
        private System.Windows.Forms.RadioButton muffinRadioButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
    }
}

