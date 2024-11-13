
namespace tester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customdgv1 = new MydataGridView.Customdgv();
            this.SuspendLayout();
            // 
            // customdgv1
            // 
            this.customdgv1.Isdelete = null;
            this.customdgv1.Ispresent = null;
            this.customdgv1.Location = new System.Drawing.Point(12, 12);
            this.customdgv1.Name = "customdgv1";
            this.customdgv1.Size = new System.Drawing.Size(800, 450);
            this.customdgv1.TabIndex = 0;
            this.customdgv1.Ulist = ((System.Collections.Generic.List<MydataGridView.MyUser>)(resources.GetObject("customdgv1.Ulist")));
            this.customdgv1.Load += new System.EventHandler(this.customdgv1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 494);
            this.Controls.Add(this.customdgv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MydataGridView.Customdgv customdgv1;
    }
}

