
namespace tamrin2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnshowmember = new System.Windows.Forms.Button();
            this.btnbookinfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnshowmember
            // 
            this.btnshowmember.Location = new System.Drawing.Point(68, 194);
            this.btnshowmember.Name = "btnshowmember";
            this.btnshowmember.Size = new System.Drawing.Size(185, 29);
            this.btnshowmember.TabIndex = 0;
            this.btnshowmember.Text = "نمایش اطلاعات عضو";
            this.btnshowmember.UseVisualStyleBackColor = true;
            this.btnshowmember.Click += new System.EventHandler(this.btnshowmember_Click);
            // 
            // btnbookinfo
            // 
            this.btnbookinfo.Location = new System.Drawing.Point(68, 119);
            this.btnbookinfo.Name = "btnbookinfo";
            this.btnbookinfo.Size = new System.Drawing.Size(190, 29);
            this.btnbookinfo.TabIndex = 1;
            this.btnbookinfo.Text = "نمایش اطلاعات کتاب";
            this.btnbookinfo.UseVisualStyleBackColor = true;
            this.btnbookinfo.Click += new System.EventHandler(this.btnbookinfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 344);
            this.Controls.Add(this.btnbookinfo);
            this.Controls.Add(this.btnshowmember);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnshowmember;
        private System.Windows.Forms.Button btnbookinfo;
    }
}

