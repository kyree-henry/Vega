namespace API.Models
{
    public class Make
    {
        public Make()
        {
            Models = [];
        }

        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public ICollection<Model> Models { get; set; }
    }
}