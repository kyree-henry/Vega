using API.Models;

namespace API.Contracts
{
    public class MakeResource
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public IEnumerable<ModelResource>? Models { get; set; }
    }
}
