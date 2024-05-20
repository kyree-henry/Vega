namespace API.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public virtual ICollection<Model>? Models { get; set; }
    }
}