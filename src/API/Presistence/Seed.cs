using API.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace API.Presistence
{
    public static class Seed
    {
        public static async Task SeedMakesAndModelsAsync(DataContext context)
        {
            if (await context.Makes.AnyAsync()) return;

            string seedData = await File.ReadAllTextAsync("Presistence/MakesAndModelsSeedData.json");
            List<Make>? makes = JsonConvert.DeserializeObject<List<Make>>(seedData);

            if (makes!.Count == 0) return;

            context.Makes.AddRange(makes);
            await context.SaveChangesAsync();
        }
    }
}