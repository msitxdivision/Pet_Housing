using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.ShowDialog();

            //判斷以會員登入
            if (fl.loginMember) 
            {
                frmMemberUI mui = new frmMemberUI();
                mui.TopLevel = false;
                mui.AutoScroll = true;
                mui.Dock = DockStyle.Fill;
                panMainForm.Controls.Add(mui);
                mui.Show();
            }

            //判斷以管理員登入
            if (fl.loginAdmin) 
            {
                frmAdminUI aui = new frmAdminUI();
                aui.TopLevel = false;
                aui.AutoScroll = true;
                aui.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                aui.Dock = DockStyle.Fill;
                panMainForm.Controls.Add(aui);
                aui.Show();
            }

            //判斷使用者不登入, 表單關閉
            if (fl.closelogin) 
            {
                this.Close();
            }
        }
    }
}
