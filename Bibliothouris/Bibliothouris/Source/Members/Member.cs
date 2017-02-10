using Bibliothouris.Source.Members;

namespace Bibliothouris.Forms.Members {
    public class Member {

       public string INSZ;
       public string FirstName;
       public string LastName;
       public Address Address;

        public Member(string INSZ, string FirstName, string LastName, Address address)
        {
            this.INSZ = INSZ;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = address;
        }
    }
}