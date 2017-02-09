namespace Bibliothouris.Forms.MemberForms {
    partial class MemberAddForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.INSZMember = new System.Windows.Forms.TextBox();
            this.FirstNameMember = new System.Windows.Forms.TextBox();
            this.LastNameMember = new System.Windows.Forms.TextBox();
            this.CityMember = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName";
            this.label2.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // INSZMember
            // 
            this.INSZMember.Location = new System.Drawing.Point(122, 17);
            this.INSZMember.Name = "INSZMember";
            this.INSZMember.Size = new System.Drawing.Size(181, 20);
            this.INSZMember.TabIndex = 4;
            // 
            // FirstNameMember
            // 
            this.FirstNameMember.Location = new System.Drawing.Point(121, 54);
            this.FirstNameMember.Name = "FirstNameMember";
            this.FirstNameMember.Size = new System.Drawing.Size(182, 20);
            this.FirstNameMember.TabIndex = 5;
            // 
            // LastNameMember
            // 
            this.LastNameMember.Location = new System.Drawing.Point(121, 91);
            this.LastNameMember.Name = "LastNameMember";
            this.LastNameMember.Size = new System.Drawing.Size(182, 20);
            this.LastNameMember.TabIndex = 6;
            // 
            // CityMember
            // 
            this.CityMember.Location = new System.Drawing.Point(121, 126);
            this.CityMember.Name = "CityMember";
            this.CityMember.Size = new System.Drawing.Size(183, 20);
            this.CityMember.TabIndex = 7;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(38, 180);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // MemberAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 649);
            this.Controls.Add(this.add);
            this.Controls.Add(this.CityMember);
            this.Controls.Add(this.LastNameMember);
            this.Controls.Add(this.FirstNameMember);
            this.Controls.Add(this.INSZMember);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MemberAddForm";
            this.Text = "MemberAddForm";
            this.Load += new System.EventHandler(this.MemberAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox INSZMember;
        private System.Windows.Forms.TextBox FirstNameMember;
        private System.Windows.Forms.TextBox LastNameMember;
        private System.Windows.Forms.TextBox CityMember;
        private System.Windows.Forms.Button add;
    }
}