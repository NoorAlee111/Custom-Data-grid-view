namespace MydataGridView
{
    partial class Customdgv
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Deletelbl = new System.Windows.Forms.Label();
            this.Rolelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(38, 10);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(89, 31);
            this.Searchbtn.TabIndex = 8;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(133, 12);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(143, 26);
            this.searchtxt.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.63043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.03623F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Controls.Add(this.Deletelbl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Rolelbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordlbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernamelbl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 23);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Deletelbl
            // 
            this.Deletelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Deletelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletelbl.Location = new System.Drawing.Point(543, 0);
            this.Deletelbl.Name = "Deletelbl";
            this.Deletelbl.Size = new System.Drawing.Size(69, 23);
            this.Deletelbl.TabIndex = 3;
            this.Deletelbl.Text = "Delete";
            this.Deletelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rolelbl
            // 
            this.Rolelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rolelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolelbl.Location = new System.Drawing.Point(363, 0);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(174, 23);
            this.Rolelbl.TabIndex = 2;
            this.Rolelbl.Text = "Role";
            this.Rolelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordlbl
            // 
            this.passwordlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(147, 0);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(210, 23);
            this.passwordlbl.TabIndex = 1;
            this.passwordlbl.Text = "Password";
            this.passwordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernamelbl
            // 
            this.usernamelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(3, 0);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(138, 23);
            this.usernamelbl.TabIndex = 0;
            this.usernamelbl.Text = "UserName";
            this.usernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customdgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Customdgv";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Deletelbl;
        private System.Windows.Forms.Label Rolelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label usernamelbl;
    }
}
