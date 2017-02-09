namespace Bibliothouris.Forms.Members {
    partial class MembersForm {
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
            this.memberListView = new System.Windows.Forms.ListView();
            this.INSZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memberListView
            // 
            this.memberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.INSZ,
            this.FirstName,
            this.LastName,
            this.City});
            this.memberListView.Location = new System.Drawing.Point(24, 28);
            this.memberListView.Name = "memberListView";
            this.memberListView.Size = new System.Drawing.Size(733, 423);
            this.memberListView.TabIndex = 0;
            this.memberListView.UseCompatibleStateImageBehavior = false;
            this.memberListView.View = System.Windows.Forms.View.Details;
            // 
            // INSZ
            // 
            this.INSZ.Text = "INSZ";
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            // 
            // City
            // 
            this.City.Text = "City";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add_Click);
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memberListView);
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView memberListView;
        private System.Windows.Forms.ColumnHeader INSZ;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
    }
}