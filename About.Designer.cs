namespace Assignment_8
{
    partial class About
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Courselabel = new System.Windows.Forms.Label();
            this.Assignmentlabel = new System.Windows.Forms.Label();
            this.Authorlabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Datelabel);
            this.groupBox1.Controls.Add(this.Authorlabel);
            this.groupBox1.Controls.Add(this.Assignmentlabel);
            this.groupBox1.Controls.Add(this.Courselabel);
            this.groupBox1.Location = new System.Drawing.Point(22, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(262, 161);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(75, 23);
            this.Closebutton.TabIndex = 1;
            this.Closebutton.Text = "&Close";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Courselabel
            // 
            this.Courselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courselabel.Location = new System.Drawing.Point(7, 16);
            this.Courselabel.Name = "Courselabel";
            this.Courselabel.Size = new System.Drawing.Size(301, 24);
            this.Courselabel.TabIndex = 0;
            this.Courselabel.Text = "CSIS1175 - Introduction to Programming";
            // 
            // Assignmentlabel
            // 
            this.Assignmentlabel.Location = new System.Drawing.Point(7, 45);
            this.Assignmentlabel.Name = "Assignmentlabel";
            this.Assignmentlabel.Size = new System.Drawing.Size(143, 19);
            this.Assignmentlabel.TabIndex = 1;
            this.Assignmentlabel.Text = "Assignment for Chapter 9";
            // 
            // Authorlabel
            // 
            this.Authorlabel.Location = new System.Drawing.Point(7, 71);
            this.Authorlabel.Name = "Authorlabel";
            this.Authorlabel.Size = new System.Drawing.Size(124, 18);
            this.Authorlabel.TabIndex = 2;
            this.Authorlabel.Text = "Author :  Hoa Thien Ha";
            // 
            // Datelabel
            // 
            this.Datelabel.Location = new System.Drawing.Point(7, 97);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(100, 23);
            this.Datelabel.TabIndex = 3;
            this.Datelabel.Text = "Date: November 28";
            // 
            // About
            // 
            this.AcceptButton = this.Closebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 195);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Authorlabel;
        private System.Windows.Forms.Label Assignmentlabel;
        private System.Windows.Forms.Label Courselabel;
    }
}