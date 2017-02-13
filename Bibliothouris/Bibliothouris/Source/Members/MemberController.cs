using System.Windows.Forms;
using Bibliothouris.Forms.MemberForms;

namespace Bibliothouris.Forms.Members {

    public class MemberController {

        internal IMemberView view { get; }
        private IMemberAddView addview;
        private IMemberService service;

        public MemberController(IMemberView memberView,IMemberAddView addview, IMemberService memberservice) {
            this.view = memberView;
            this.addview = addview;
            this.service = memberservice;
            this.view.SetController(this);
            this.addview.SetController(this);
        }

        public void LoadAllMembers() {
            foreach (Member member in service.GetAllMembers()) {
                view.AddMember(member);
            }
        }

        public void AddMember(string INSZ, string FirstName, string LastName, string street, string number, string postalCode, string City)
        {  
            service.AddMember(INSZ, FirstName, LastName, street, number,postalCode, City);
            addview.Close();
               ClearAllMembers();
            LoadAllMembers();
        }

        public void addMemberView()
        {
            addview.Clear();
            addview.ShowDialog();
        }

        public void ClearAllMembers()
        {
            view.ClearAllMembers();
        }

    
    }
}