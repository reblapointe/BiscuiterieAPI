using Biscuiterie.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Buiscuiterie.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new BuiscuiterieContext(
                    serviceProvider.GetRequiredService<DbContextOptions
                    <BuiscuiterieContext>>());
            SeedDB(context);
        }
        public static void SeedDB(BuiscuiterieContext context)
        {
            if (context.Biscuit.Any())
            {
                return;
            }
            // Ce sont les 5 biscuits préférés de l'équipe RICARDO
            context.Biscuit.AddRange(
                new Biscuit { Nom = "Double gingembre", ProprietaireId = "alice" },
                new Biscuit { Nom = "Brisures de chocolat", ProprietaireId = "alice" },
                new Biscuit { Nom = "Amaretti", ProprietaireId = "alice" },
                new Biscuit { Nom = "S'mores au beurre noisette", ProprietaireId = "alice" },
                new Biscuit { Nom = "Canneberges", ProprietaireId = "alice" });
            context.SaveChanges();
        }

    }
}
