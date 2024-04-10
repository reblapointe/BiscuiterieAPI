using Biscuiterie.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Buiscuiterie.Data
{
public class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BuiscuiterieContext(
                serviceProvider.GetRequiredService<DbContextOptions
                <BuiscuiterieContext>>()))
        {
            SeedDB(context);
        }
    }
    public static void SeedDB(BuiscuiterieContext context)
    {
        if (context.Biscuit.Any())
        {
            return;
        }
        // Ce sont les 5 biscuits préférés de l'équipe RICARDO
        context.Biscuit.AddRange(
            new Biscuit { Nom = "Double gingembre" },
            new Biscuit { Nom = "Brisures de chocolat" },
            new Biscuit { Nom = "Amaretti" },
            new Biscuit { Nom = "S'mores au beurre noisette" },
            new Biscuit { Nom = "Canneberges" });
        context.SaveChanges();
    }

}
}
