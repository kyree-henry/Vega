namespace API.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public int MakeId { get; set; }
        public virtual Make? Make { get; set; }
    }
}