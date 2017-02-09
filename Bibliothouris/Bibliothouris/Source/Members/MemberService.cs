using System;
using System.Collections.Generic;



namespace Bibliothouris.Forms.Members {
    public interface IMemberService {

        List<Member> GetAllMembers();
       // void add(String INSZ, String FirstName, String LastName, String City);
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
    }
}