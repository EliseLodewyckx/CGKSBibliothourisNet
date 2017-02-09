using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliothouris.Forms.Members;

namespace Bibliothouris.Forms.MemberForms {

    public interface IMemberAddView
    {
        void SetController(MemberController memberController);
        void Close();
        void Clear();
        DialogResult ShowDialog();
    }



    public partial class MemberAddForm : Form, IMemberAddView
    {

        private MemberController memberController;
        
        public MemberAddForm() {
            InitializeComponent();
        }

        public void SetController(MemberController memberController)
        {
            this.memberController = memberController;
        }
       
        private void add_Click(object sender, EventArgs e) {
            memberController.AddMember(INSZMember.Text, FirstNameMember.Text, LastNameMember.Text, CityMember.Text);

        }

        public void Clear()
        {
            INSZMember.Text = "";
            FirstNameMember.Text = "";
            LastNameMember.Text = "";
            CityMember.Text = "";
        }
    }
}
