using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tester
{
    public partial class Form1 : Form
    {
        private string path= "C:\\Users\\DELL\\source\\repos\\MydataGridView\\user.txt";
        public Form1()
        {
            InitializeComponent();
            bool flag = MydataGridView.MyUserDL.ReadUserData(path);
            customdgv1.Ulist = MydataGridView.MyUserDL.UserList;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customdgv1.Ispresent += customdgv1_IsPresent;

            customdgv1.Isdelete += customdgv1_Isdelete;
        }

        private void customdgv1_Load(object sender, EventArgs e)
        {

        }
        private void customdgv1_Isdelete(object sender, EventArgs e)
        {
            MessageBox.Show("Record is deleted succesfully...");
            MydataGridView.MyUserDL.StoreUserData(path);
        }
        private void customdgv1_IsPresent(object sender, EventArgs e)
        {
            MessageBox.Show("Yes..This user is present in the list...");
        }
    }
}
