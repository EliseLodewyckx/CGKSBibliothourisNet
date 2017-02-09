using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothouris.Forms.Members {

    public interface IMemberView {
        void SetController(MemberController memberController);
    }





    public partial class MembersForm : Form, IMemberView {

        private MemberController memberController;

        public MembersForm() {
            InitializeComponent();
        }

        public void SetController (MemberController memberController) {
            this.memberController = memberController;
        }
        private ListViewItem CreateMemberListViewItem(Member member) {
            ListViewItem memberItem = new ListViewItem(member.INSZ);
            memberItem.SubItems.Add(member.FirstName);
            memberItem.SubItems.Add(member.LastName);
            memberItem.SubItems.Add(member.City);
            return memberItem;
           
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e) {

        }
    }
}
