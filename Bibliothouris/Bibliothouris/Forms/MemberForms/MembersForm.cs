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
        void AddMember(Member member);
        void ClearAllMembers();
        DialogResult ShowDialog();
    }

    public partial class MembersForm : Form, IMemberView {

        private MemberController memberController;

        public MembersForm() {
            InitializeComponent();
        }

        public void SetController (MemberController memberController) {
            this.memberController = memberController;
        }

        public void AddMember(Member member)
        {
            memberListView.Items.Add(CreateMemberListViewItem(member));
        }
            
        private ListViewItem CreateMemberListViewItem(Member member) {
            ListViewItem memberItem = new ListViewItem(member.INSZ);
            memberItem.SubItems.Add(member.FirstName);
            memberItem.SubItems.Add(member.LastName);
            memberItem.SubItems.Add(member.Address.getCity());
            return memberItem;
           
        }

        public void ClearAllMembers()
        {
            memberListView.Items.Clear();
        }


     /*  private void MemberListView_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void MemberListView_SelectedIndexChanged_1(object sender, EventArgs e) {

        }*/

        private void add_Click(object sender, EventArgs e)
        {
            memberController.addMemberView();

        }
    }
}
