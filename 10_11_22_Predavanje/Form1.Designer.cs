namespace _10_11_22_Predavanje
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
            this.btnReturnCompare = new System.Windows.Forms.Button();
            this.lblReturn1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturnCompare
            // 
            this.btnReturnCompare.Location = new System.Drawing.Point(93, 25);
            this.btnReturnCompare.Name = "btnReturnCompare";
            this.btnReturnCompare.Size = new System.Drawing.Size(118, 23);
            this.btnReturnCompare.TabIndex = 5;
            this.btnReturnCompare.Text = "Ispiši i usporedi";
            this.btnReturnCompare.UseVisualStyleBackColor = true;
            this.btnReturnCompare.Click += new System.EventHandler(this.btnReturnCompare_Click);
            // 
            // lblReturn1
            // 
            this.lblReturn1.AutoSize = true;
            this.lblReturn1.Location = new System.Drawing.Point(67, 71);
            this.lblReturn1.Name = "lblReturn1";
            this.lblReturn1.Size = new System.Drawing.Size(0, 13);
            this.lblReturn1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnCompare);
            this.Controls.Add(this.lblReturn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnCompare;
        private System.Windows.Forms.Label lblReturn1;
    }
}

