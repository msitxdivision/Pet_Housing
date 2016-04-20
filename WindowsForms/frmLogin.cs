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

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.memberDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'memberDataSet.Member' 資料表。您可以視需要進行移動或移除。
            this.memberTableAdapter.Fill(this.memberDataSet.Member);

        }

        private void btnMemberLogin_Click(object sender, EventArgs e) //會員登入
        {

        }

        private void btnMemberAdd_Click(object sender, EventArgs e) //加入會員
        {

        }

        private void btnAdminLogin_Click(object sender, EventArgs e) //管理員登入
        {
           
        }
    }
}
