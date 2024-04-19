using API_JWT.Enum;

namespace API_JWT.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string User { get; set; }
        public DepartureEnum Departure  { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime TokenCreateDate { get; set; } = DateTime.Now;

    }
}
