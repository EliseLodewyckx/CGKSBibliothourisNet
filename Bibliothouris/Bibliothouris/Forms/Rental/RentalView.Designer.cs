namespace Bibliothouris.Forms
{
    partial class RentalView
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
            this.bookBtn = new System.Windows.Forms.Button();
            this.memberBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(12, 12);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(113, 65);
            this.bookBtn.TabIndex = 0;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // memberBtn
            // 
            this.memberBtn.Location = new System.Drawing.Point(159, 12);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(113, 65);
            this.memberBtn.TabIndex = 1;
            this.memberBtn.Text = "Member";
            this.memberBtn.UseVisualStyleBackColor = true;
            this.memberBtn.Click += new System.EventHandler(this.memberBtn_Click);
            // 
            // RentalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.memberBtn);
            this.Controls.Add(this.bookBtn);
            this.Name = "RentalView";
            this.Text = "RentalView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button memberBtn;
    }
}