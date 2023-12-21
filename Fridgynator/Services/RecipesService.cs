using Fridgynator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridgynator.Services
{
	internal static class RecipesService
	{
		private static List<Recipes> recipes = new ()
		{
			new()
            {
                Name = " Hakklihakaste",
                Subtitle = "   Parim kaste maailmas!",
                HeroImage = "hakklihakaste.png",
                Description = "Mercury is the smallest planet in the Solar " +
				"System and the closest to the Sun. Its orbit around the Sun takes " +
				"87.97 Earth days, the shortest of all the Sun's planets. " +
				"It is named after the Roman god Mercurius (Mercury), god " +
				"of commerce, messenger of the gods, and mediator between gods " +
				"and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
				"Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
				"planet; its apparent distance from the Sun as viewed from Earth " +
				"never exceeds 28°.",
				AccentColorStart = Color.FromArgb("#353535"),
				AccentColorEnd = Color.FromArgb("#8d9098"),
				Images = new()
                {
					"https://nami-nami.ee/files/recipes/380/hakklihakaste.jpg"
				}


           },
            new ()
            {
                Name = " Rabarberikook",
                Subtitle = "   Suussulav kook!",
                HeroImage = "rabarberikook.jpg",
                Description = "Tainas:\r\n100 g võid\r\n\r\n85 g suhkrut (1 dl, võib olla roosuhkur)\r\n\r\n50 g Saare 20% hapukoort\r\n\r\n1 muna\r\n\r\n180 g nisujahu (3 dl)\r\n\r\n1 tl küpsetuspulbrit\r\n\r\nTäidis:\r\n250 g Saare 20% hapukoort\r\n\r\n4 sl suhkrut\r\n\r\n1 muna\r\n\r\n1 tl vanillisuhkrut\r\n\r\nKate:\r\n4-5 rabarbrivart\r\n\r\ndemerara suhkrut " +
				"Vahusta toasoe või suhkruga. Sega juurde hapukoor, muna ja küpsetuspulbriga segatud jahu ning sega tainas ühtlaseks (tainas on pehme, aga mitte vedel). " +
				"Suru tainas võitatud 24 cm lahtikäiva vormi põhjale ja servadele. " +
				"Sega täidiseained omavahel ja kalla vormi. " +
				"Kata tükeldatud rabarbriga* ning puista peale veidi demerara suhkrut. Küpseta 200kraadise ahju keskosas umbes 30 minutit, kuni tainas on kuldne ja täidis hüübinud. Lase veidi vormis jahtuda, siis libista ettevaatlikult koogialusele..",
				AccentColorStart = Color.FromArgb("#353535"),
				AccentColorEnd = Color.FromArgb("#8d9098"),
				Images = new List<string>
                {
					"https://i0.wp.com/tuuliretseptid.ee/wp-content/uploads/2020/01/DSC8944-scaled.jpg?resize=810%2C1217&ssl=1"
				}

                },
            new()
            {
                Name = " Hapukapsasupp",
                Subtitle = "   Vanaema moodi...",
                HeroImage = "hapukapsasupp.jpg",
                Description = "1,5 l vett\r\n\r\n300-400 g sealiha (külje- või kaelatükk)\r\n\r\n300 g hapukapsast\r\n\r\n0,5 dl odrakruupe\r\n\r\n1 suur porgand\r\n\r\n1 sibul\r\n\r\nsoola\r\n\r\nsuhkrusiirupit või suhkrut\r\n\r\n1 väike loorberileht\r\n\r\n2-3 tera musta pipart " +
				"Pane liha vette ja kuumuta keemiseni. Riisu tekkinud vaht. " +
				"Pane seejärel lihale hapukapsas, siis leotatud kruubid, hakitud porgand ja sibul. Maitsesta soola, pipra ja loorberilehega, natuke lisa ka suhkrut või siirupit. Keeda madalal kuumusel umbes kaks tundi, kuni kruubid ja liha on pehmed. " +
				"Timmi maitse parajaks ja serveeri.",
				AccentColorStart = Color.FromArgb("#353535"),
				AccentColorEnd = Color.FromArgb("#8d9098"),
				Images = new()
                {
					"https://nami-nami.ee/files//recipes/406/Juta2020HapukapsaSupp.jpg",
                    
                }
         },
            new()
            {
                Name = " Kartulipuder",
                Subtitle = "   Maailma parim!",
                HeroImage = "kartulipuder.png",
                Description = "1 kg kartulit (nt Laura või Marabel)\r\n\r\n2 dl sooja piima\r\n\r\n50 g võid\r\n\r\nsoola ja musta pipart " +
				"Vala vesi ära ja lase kartulitel potis veidi auruda. Tambi kartulid pudrunuia abil katki, lisades samal ajal vähehaaval kuuma piima ja tükeldatud või. Klopi puder puulusikaga kohevaks. Maitsesta soola ja pipraga ja serveeri.",
			    AccentColorStart = Color.FromArgb("#353535"),
				AccentColorEnd = Color.FromArgb("#8d9098"),
				Images = new()
                {
					"https://nami-nami.ee/files/recipes/7337/Juta2021OliivoliKartulipuder.jpg"
				}
            } };



        public static List<Recipes> GetFeaturedRecipes()
        {
            var random = new Random();
            var randomizedRecipes = recipes.OrderBy(item => random.Next());

            return randomizedRecipes.Take(2).ToList();
        }

        public static List<Recipes> GetAllRecipes()
            => recipes;
		
	}
}

