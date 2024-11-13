using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MydataGridView;

namespace MydataGridView
{
    public partial class Customdgv: UserControl
    {
        private List<MyUser> ulist = new List<MyUser>();
        private int userx = 120, usery = 80;
        private int passx = 320, passy = 80;
        private int rolex = 500, roley = 80;
        private int delx = 610, dely = 80;
        private EventHandler ispresent;
        private EventHandler isdelete;
        public Customdgv()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            bool flag = MyUserDL.Checkuniqueusername(searchtxt.Text);
            if (flag == false)
            {
                Ispresent?.Invoke(this, EventArgs.Empty);
            }
        }

        public EventHandler Ispresent { get => ispresent; set => ispresent = value; }
        public EventHandler Isdelete { get => isdelete; set => isdelete = value; }
        public List<MyUser> Ulist { get => ulist; set => ulist = value; }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ulist.Count; i++)
            {
                createusernamelabels(i);
                createpasswordlabels(i);
                createrolelabels(i);
                createdelbutton(i);
            }
        }
        private void createusernamelabels(int count)
        {
            Label lable1 = new Label();
            lable1.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
            lable1.Name = "lblu" + count;
            lable1.Text = ulist[count].UserName;
            lable1.AutoSize = true;
            Point p = new Point(userx, usery);
            lable1.Location = p;
            lable1.Size = new Size(200, 36);
            Controls.Add(lable1);
            lable1.TextAlign = ContentAlignment.MiddleCenter;
            lable1.BackColor = Color.Beige;
            usery += 40;
        }
        private void createpasswordlabels(int count)
        {
            Label lable1 = new Label();
            lable1.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
            lable1.Name = "lblu" + count;
            lable1.Text = ulist[count].UserPassword;
            lable1.AutoSize = true;
            Point p = new Point(passx, passy);
            lable1.Location = p;
            lable1.Size = new Size(200, 36);
            Controls.Add(lable1);
            lable1.TextAlign = ContentAlignment.MiddleCenter;
            lable1.BackColor = Color.Beige;
            passy += 40;
        }
        private void createrolelabels(int count)
        {
            Label lable1 = new Label();
            lable1.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
            lable1.Name = "lblu" + count;
            lable1.Text = ulist[count].UserRole;
            lable1.AutoSize = true;
            Point p = new Point(rolex, roley);
            lable1.Location = p;
            lable1.Size = new Size(200, 36);
            Controls.Add(lable1);
            lable1.TextAlign = ContentAlignment.MiddleCenter;
            lable1.BackColor = Color.Beige;
            roley += 40;
        }
        private void createdelbutton(int count)
        {
            Button btn = new Button();
            Controls.Add(btn);
            btn.Name = "btn" + count;
            btn.Size = new Size(80, 36);
            btn.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.BackColor = Color.Beige;
            btn.AutoSize = true;
            btn.Text = "Delete";
            Point p = new Point(delx, dely);
            btn.Location = p;
            btn.Click += new EventHandler(this.button_click);
            dely += 40;

        }
        private void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            int count = btn.Name[3] - 48;
            ulist.RemoveAt(count);
            Isdelete?.Invoke(this, EventArgs.Empty);
        }
    }
}
