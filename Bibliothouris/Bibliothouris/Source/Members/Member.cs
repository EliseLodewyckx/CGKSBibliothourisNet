namespace Bibliothouris.Forms.Members {
    public class Member {

       public string INSZ;
       public string FirstName;
       public string LastName;
       public string City;

        public Member(string INSZ, string FirstName, string LastName, string City)
        {
            this.INSZ = INSZ;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.City = City;
        }
    }
}