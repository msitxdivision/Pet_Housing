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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool closelogin = true; //判斷Login關閉
        public bool loginMember = false;
        public bool loginAdmin = false;

        private void btnMemberLogin_Click(object sender, EventArgs e) //會員登入
        {
            this.loginMember = true;
            this.closelogin = false;
            this.Close();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e) //管理員登入
        {
            MessageBox.Show("登入成功");
            this.loginAdmin = true;
            this.closelogin = false;
            this.Close();
        }

        private void btnMemberAdd_Click(object sender, EventArgs e) //加入會員
        {
            this.tabLoginForm.SelectedIndex = 0;
        }
    }
}
