namespace User1.Model
{
    public class UserLogin
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

    }
    public enum UserStatusCode
    {
        Invited =100,
        Active=200,
        Deactive =400
    }
}
