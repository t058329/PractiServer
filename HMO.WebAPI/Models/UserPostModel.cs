namespace HMO.WebAPI.Models
{
    public class UserPostModel
    {
        public string UserId { get; set; } = null!;

        public string Firstname { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Kind { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string Hmo { get; set; } = null!;

        // public virtual ICollection<Child> Children { get; } = new List<Child>();

    }
}
