namespace finding_the_average
{
    partial class frmFindingTheAverage
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
            this.lblMark1 = new System.Windows.Forms.Label();
            this.lblMark2 = new System.Windows.Forms.Label();
            this.lblMark3 = new System.Windows.Forms.Label();
            this.lblMark4 = new System.Windows.Forms.Label();
            this.lblMark5 = new System.Windows.Forms.Label();
            this.txtMark1 = new System.Windows.Forms.TextBox();
            this.txtMark2 = new System.Windows.Forms.TextBox();
            this.txtMark3 = new System.Windows.Forms.TextBox();
            this.txtMark4 = new System.Windows.Forms.TextBox();
            this.txtMark5 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMark1
            // 
            this.lblMark1.AutoSize = true;
            this.lblMark1.Location = new System.Drawing.Point(12, 9);
            this.lblMark1.Name = "lblMark1";
            this.lblMark1.Size = new System.Drawing.Size(80, 13);
            this.lblMark1.TabIndex = 0;
            this.lblMark1.Text = "Enter first mark:";
            // 
            // lblMark2
            // 
            this.lblMark2.AutoSize = true;
            this.lblMark2.Location = new System.Drawing.Point(12, 37);
            this.lblMark2.Name = "lblMark2";
            this.lblMark2.Size = new System.Drawing.Size(99, 13);
            this.lblMark2.TabIndex = 1;
            this.lblMark2.Text = "Enter second mark:";
            // 
            // lblMark3
            // 
            this.lblMark3.AutoSize = true;
            this.lblMark3.Location = new System.Drawing.Point(12, 66);
            this.lblMark3.Name = "lblMark3";
            this.lblMark3.Size = new System.Drawing.Size(84, 13);
            this.lblMark3.TabIndex = 2;
            this.lblMark3.Text = "Enter third mark:";
            // 
            // lblMark4
            // 
            this.lblMark4.AutoSize = true;
            this.lblMark4.Location = new System.Drawing.Point(12, 96);
            this.lblMark4.Name = "lblMark4";
            this.lblMark4.Size = new System.Drawing.Size(91, 13);
            this.lblMark4.TabIndex = 3;
            this.lblMark4.Text = "Enter fourth mark:";
            // 
            // lblMark5
            // 
            this.lblMark5.AutoSize = true;
            this.lblMark5.Location = new System.Drawing.Point(12, 123);
            this.lblMark5.Name = "lblMark5";
            this.lblMark5.Size = new System.Drawing.Size(81, 13);
            this.lblMark5.TabIndex = 4;
            this.lblMark5.Text = "Enter fifth mark:";
            // 
            // txtMark1
            // 
            this.txtMark1.Location = new System.Drawing.Point(114, 6);
            this.txtMark1.Name = "txtMark1";
            this.txtMark1.Size = new System.Drawing.Size(100, 20);
            this.txtMark1.TabIndex = 5;
            // 
            // txtMark2
            // 
            this.txtMark2.Location = new System.Drawing.Point(114, 34);
            this.txtMark2.Name = "txtMark2";
            this.txtMark2.Size = new System.Drawing.Size(100, 20);
            this.txtMark2.TabIndex = 6;
            // 
            // txtMark3
            // 
            this.txtMark3.Location = new System.Drawing.Point(114, 63);
            this.txtMark3.Name = "txtMark3";
            this.txtMark3.Size = new System.Drawing.Size(100, 20);
            this.txtMark3.TabIndex = 7;
            // 
            // txtMark4
            // 
            this.txtMark4.Location = new System.Drawing.Point(114, 93);
            this.txtMark4.Name = "txtMark4";
            this.txtMark4.Size = new System.Drawing.Size(100, 20);
            this.txtMark4.TabIndex = 8;
            // 
            // txtMark5
            // 
            this.txtMark5.Location = new System.Drawing.Point(114, 120);
            this.txtMark5.Name = "txtMark5";
            this.txtMark5.Size = new System.Drawing.Size(100, 20);
            this.txtMark5.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(66, 146);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(109, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(15, 184);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(260, 142);
            this.lblDisplay.TabIndex = 11;
            // 
            // frmFindingTheAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 335);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMark5);
            this.Controls.Add(this.txtMark4);
            this.Controls.Add(this.txtMark3);
            this.Controls.Add(this.txtMark2);
            this.Controls.Add(this.txtMark1);
            this.Controls.Add(this.lblMark5);
            this.Controls.Add(this.lblMark4);
            this.Controls.Add(this.lblMark3);
            this.Controls.Add(this.lblMark2);
            this.Controls.Add(this.lblMark1);
            this.Name = "frmFindingTheAverage";
            this.Text = "Calculating Average Of Marks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMark1;
        private System.Windows.Forms.Label lblMark2;
        private System.Windows.Forms.Label lblMark3;
        private System.Windows.Forms.Label lblMark4;
        private System.Windows.Forms.Label lblMark5;
        private System.Windows.Forms.TextBox txtMark1;
        private System.Windows.Forms.TextBox txtMark2;
        private System.Windows.Forms.TextBox txtMark3;
        private System.Windows.Forms.TextBox txtMark4;
        private System.Windows.Forms.TextBox txtMark5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDisplay;
    }
}

