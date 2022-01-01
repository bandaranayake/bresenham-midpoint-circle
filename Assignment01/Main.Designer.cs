namespace Assignment01
{
    partial class Main
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBresenham = new System.Windows.Forms.Button();
            this.btnMidpoint = new System.Windows.Forms.Button();
            this.txtCenter = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Center:";
            // 
            // btnBresenham
            // 
            this.btnBresenham.Location = new System.Drawing.Point(48, 87);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(100, 25);
            this.btnBresenham.TabIndex = 4;
            this.btnBresenham.Text = "Bresenham\'s";
            this.btnBresenham.UseVisualStyleBackColor = true;
            this.btnBresenham.Click += new System.EventHandler(this.BtnBresenham_Click);
            // 
            // btnMidpoint
            // 
            this.btnMidpoint.Location = new System.Drawing.Point(154, 87);
            this.btnMidpoint.Name = "btnMidpoint";
            this.btnMidpoint.Size = new System.Drawing.Size(100, 25);
            this.btnMidpoint.TabIndex = 5;
            this.btnMidpoint.Text = "Midpoint";
            this.btnMidpoint.UseVisualStyleBackColor = true;
            this.btnMidpoint.Click += new System.EventHandler(this.BtnMidpoint_Click);
            // 
            // txtCenter
            // 
            this.txtCenter.Location = new System.Drawing.Point(77, 47);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.Size = new System.Drawing.Size(177, 20);
            this.txtCenter.TabIndex = 1;
            this.txtCenter.Text = "200,200";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(77, 21);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(177, 20);
            this.txtRadius.TabIndex = 0;
            this.txtRadius.Text = "100";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.btnMidpoint);
            this.Controls.Add(this.btnBresenham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCenter);
            this.Controls.Add(this.txtRadius);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Cricle Drawing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.Button btnMidpoint;
        private System.Windows.Forms.TextBox txtCenter;
        private System.Windows.Forms.TextBox txtRadius;
    }
}

