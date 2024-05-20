using API.Models;

namespace API.Contracts
{
    public class ModelResource
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public int MakeId { get; set; }
    }
}
