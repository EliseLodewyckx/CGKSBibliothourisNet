using System.Collections.Generic;

namespace Bibliothouris.Forms.Members {
    public class MemberRepository {

        List<Member> members; 
        public MemberRepository() {
            members = new List<Member>();
        }
        public virtual List<Member> GetAllMembers() {
            return members;
        }

        public void AddMember(Member member)
        {
           members.Add(member); 
        }
    }
}