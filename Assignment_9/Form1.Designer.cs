namespace Assignment_9
{
    partial class btnFootball
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
            this.radioBtnFootball = new System.Windows.Forms.RadioButton();
            this.radioBtnHandball = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFeeToBePaid = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMembershipDuration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            // 
            // radioBtnFootball
            // 
            this.radioBtnFootball.AutoSize = true;
            this.radioBtnFootball.Location = new System.Drawing.Point(197, 42);
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
            this.radioBtnHandball.Location = new System.Drawing.Point(197, 86);
            this.radioBtnHandball.Name = "radioBtnHandball";
            this.radioBtnHandball.Size = new System.Drawing.Size(85, 21);
            this.radioBtnHandball.TabIndex = 2;
            this.radioBtnHandball.TabStop = true;
            this.radioBtnHandball.Text = "Handball";
            this.radioBtnHandball.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Membership duration";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(42, 257);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(264, 61);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate Fee";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fee to be paid";
            // 
            // lblFeeToBePaid
            // 
            this.lblFeeToBePaid.AutoSize = true;
            this.lblFeeToBePaid.Location = new System.Drawing.Point(206, 360);
            this.lblFeeToBePaid.Name = "lblFeeToBePaid";
            this.lblFeeToBePaid.Size = new System.Drawing.Size(46, 17);
            this.lblFeeToBePaid.TabIndex = 9;
            this.lblFeeToBePaid.Text = "label5";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(197, 147);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(109, 22);
            this.txtAge.TabIndex = 10;
            this.txtAge.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMembershipDuration
            // 
            this.txtMembershipDuration.Location = new System.Drawing.Point(197, 210);
            this.txtMembershipDuration.Name = "txtMembershipDuration";
            this.txtMembershipDuration.Size = new System.Drawing.Size(108, 22);
            this.txtMembershipDuration.TabIndex = 11;
            // 
            // btnFootball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMembershipDuration);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblFeeToBePaid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnHandball);
            this.Controls.Add(this.radioBtnFootball);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "btnFootball";
            this.Text = "Selection assignment 9";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtnFootball;
        private System.Windows.Forms.RadioButton radioBtnHandball;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFeeToBePaid;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMembershipDuration;
    }
}

