namespace Assignment9
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
            this.btnCalculateFee = new System.Windows.Forms.Button();
            this.radioBtnFootball = new System.Windows.Forms.RadioButton();
            this.radioBtnHandball = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMembershipDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFeeToBePaid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateFee
            // 
            this.btnCalculateFee.Location = new System.Drawing.Point(79, 229);
            this.btnCalculateFee.Name = "btnCalculateFee";
            this.btnCalculateFee.Size = new System.Drawing.Size(329, 59);
            this.btnCalculateFee.TabIndex = 0;
            this.btnCalculateFee.Text = "&Calculate Fee";
            this.btnCalculateFee.UseVisualStyleBackColor = true;
            this.btnCalculateFee.Click += new System.EventHandler(this.btnCalculateFee_Click);
            // 
            // radioBtnFootball
            // 
            this.radioBtnFootball.AutoSize = true;
            this.radioBtnFootball.Location = new System.Drawing.Point(271, 45);
            this.radioBtnFootball.Name = "radioBtnFootball";
            this.radioBtnFootball.Size = new System.Drawing.Size(79, 21);
            this.radioBtnFootball.TabIndex = 1;
            this.radioBtnFootball.TabStop = true;
            this.radioBtnFootball.Text = "Football";
            this.radioBtnFootball.UseVisualStyleBackColor = true;
            // 
            // radioBtnHandball
            // 
            this.radioBtnHandball.AutoSize = true;
            this.radioBtnHandball.Location = new System.Drawing.Point(274, 94);
            this.radioBtnHandball.Name = "radioBtnHandball";
            this.radioBtnHandball.Size = new System.Drawing.Size(85, 21);
            this.radioBtnHandball.TabIndex = 2;
            this.radioBtnHandball.TabStop = true;
            this.radioBtnHandball.Text = "Handball";
            this.radioBtnHandball.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(275, 148);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(133, 22);
            this.txtAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Membership duration";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMembershipDuration
            // 
            this.txtMembershipDuration.Location = new System.Drawing.Point(274, 182);
            this.txtMembershipDuration.Name = "txtMembershipDuration";
            this.txtMembershipDuration.Size = new System.Drawing.Size(134, 22);
            this.txtMembershipDuration.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fee to be paid";
            // 
            // lblFeeToBePaid
            // 
            this.lblFeeToBePaid.AutoSize = true;
            this.lblFeeToBePaid.Location = new System.Drawing.Point(213, 321);
            this.lblFeeToBePaid.Name = "lblFeeToBePaid";
            this.lblFeeToBePaid.Size = new System.Drawing.Size(0, 17);
            this.lblFeeToBePaid.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 369);
            this.Controls.Add(this.lblFeeToBePaid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMembershipDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnHandball);
            this.Controls.Add(this.radioBtnFootball);
            this.Controls.Add(this.btnCalculateFee);
            this.Name = "Form1";
            this.Text = "Selection assignment 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateFee;
        private System.Windows.Forms.RadioButton radioBtnFootball;
        private System.Windows.Forms.RadioButton radioBtnHandball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMembershipDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFeeToBePaid;
    }
}

