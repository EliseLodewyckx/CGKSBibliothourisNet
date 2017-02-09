using System;
using System.Collections.Generic;



namespace Bibliothouris.Forms.Members {
    public interface IMemberService {

        List<Member> GetAllMembers();
       void AddMember(String INSZ, String FirstName, String LastName, String City);
    }

    public class MemberService : IMemberService {
        private MemberRepository repository;  

        public MemberService() : this (new MemberRepository()) {

        }
        public MemberService (MemberRepository repository) {
            this.repository = repository;
        }
        public List<Member> GetAllMembers() {
            return repository.GetAllMembers();
        }

        public void AddMember(string INSZ, string FirstName, string LastName, string City)
        {
            repository.AddMember(new Member(INSZ, FirstName, LastName, City));
        }
    }
}