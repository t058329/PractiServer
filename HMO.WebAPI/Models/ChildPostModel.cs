namespace HMO.WebAPI.Models
{
    public class ChildPostModel
    {
        public string ChildId { get; set; } = null!;

        public string ParentId { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        // public virtual User Parent { get; set; }
    }

}
