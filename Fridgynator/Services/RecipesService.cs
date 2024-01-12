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
		private static List<Recipes> recipes = new()
		{
			new()
			{
				Name = " Hakklihakaste",
				Subtitle = "   Parim kaste maailmas!",
				HeroImage = "hakklihakaste.png",
				Description = "**Koostisosad:**\r\n" +
							  "1 sl võid või õli\r\n" +
							  "1 sibul\r\n" +
							  "400-500 g hakkliha (nt Rakvere kodune hakkliha või Rakvere veisehakkliha)\r\n" +
							  "1 sl nisujahu\r\n" +
							  "5 dl vett või puljongit\r\n" +
							  "4 sl Saare hapukoort\r\n" +
							  "soola ja musta pipart\r\n" +
							  "hakitud värsket tilli või peterselli\r\n\r\n" +
							  "**Valmistamine:**\r\n" +
							  "Kuumuta pannil või või õli. Lisa hakitud sibul ja prae kergelt läbi. Siis lisa hakkliha ja prae segades, kuni hakkliha on kenasti küps. Maitsesta soola-pipraga.\r\n" +
							  "Puista peale nisujahu, sega läbi. Lisa vedelik ning hauta kastet kümmekond minutit. Lõpus sega juurde hapukoor ja soovi korral hakitud maitseroheline.\r\n" +
							  "Serveeri keedetud kartulite ja värske salatiga.",
				AccentColorStart = Color.FromArgb("#a480cf"),
				AccentColorEnd = Color.FromArgb("#779be7"),
				Images = new()
				{
					"https://nami-nami.ee/files/recipes/380/hakklihakaste.jpg"
				}
			},
			new()
			{
				Name = " Rabarberikook",
				Subtitle = "   Suussulav kook!",
				HeroImage = "rabarberikook.jpg",
				Description = "**Tainas:**\r\n" +
							  "100 g võid\r\n" +
							  "85 g suhkrut (1 dl, võib olla roosuhkur)\r\n" +
							  "50 g Saare 20% hapukoort\r\n" +
							  "1 muna\r\n" +
							  "180 g nisujahu (3 dl)\r\n" +
							  "1 tl küpsetuspulbrit\r\n" +
							  "\r\n" +
							  "**Täidis:**\r\n"+
							  "250 g Saare 20% hapukoort\r\n" +
							  "4 sl suhkrut\r\n" +
							  "1 muna\r\n" +
							  "1 tl vanillisuhkrut\r\n" +
							  "\r\n" +
							  "**Kate:**\r\n" +
							  "4-5 rabarbrivart\r\n" +
							  "demerara suhkrut\r\n" +
							  "\r\n" +
							  "**Valmistamine:**\r\n" +
							  "Vahusta toasoe või suhkruga. Sega juurde hapukoor, muna ja küpsetuspulbriga segatud jahu ning sega tainas ühtlaseks (tainas on pehme, aga mitte vedel).\r\n\r\nSuru tainas võitatud 24 cm lahtikäiva vormi põhjale ja servadele.\r\n" +
							  "Kata tükeldatud rabarbriga* ning puista peale veidi demerara suhkrut.\r\n\r\nKüpseta 200kraadise ahju keskosas umbes 30 minutit, kuni tainas on kuldne ja täidis hüübinud.\r\n" +
							  "Lase veidi vormis jahtuda, siis libista ettevaatlikult koogialusele.",
                AccentColorStart = Color.FromArgb("#a480cf"),
                AccentColorEnd = Color.FromArgb("#779be7"),
                Images = new ()
				{
					"https://images.delfi.ee/media-api-image-cropper/v1/0715f140-b8fc-11eb-a43e-c39d2a6aaf33.jpg?noup&w=1200&h=711"
				}
			},
			new()
			{
				Name = " Hapukapsasupp",
				Subtitle = "   Vanaema moodi...",
				HeroImage = "hapukapsasupp.jpg",
				Description = "**Koostisosad:**\r\n" +
							  "1,5 l vett\r\n" +
							  "300-400 g sealiha (külje- või kaelatükk)\r\n" +
							  "300 g hapukapsast\r\n" +
							  "0,5 dl odrakruupe\r\n" +
							  "1 suur porgand\r\n" +
							  "1 sibul\r\n" +
							  "soola\r\n" +
							  "suhkrusiirupit või suhkrut\r\n" +
							  "1 väike loorberileht\r\n" +
							  "2-3 tera musta pipart\r\n\r\n" +
							  "**Valmistamine:**\r\n" +
							  "Pane liha vette ja kuumuta keemiseni. Riisu tekkinud vaht.\r\n" +
							  "Pane seejärel lihale hapukapsas, siis leotatud kruubid, hakitud porgand ja sibul. Maitsesta soola, pipra ja loorberilehega, natuke lisa ka suhkrut või siirupit. Keeda madalal kuumusel umbes kaks tundi, kuni kruubid ja liha on pehmed.\r\n" +
							  "Timmi maitse parajaks ja serveeri.",
				AccentColorStart = Color.FromArgb("#a480cf"),
				AccentColorEnd = Color.FromArgb("#779be7"),
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
				Description = "**Koostisosad:**\r\n" +
							  "1 kg kartulit (nt Laura või Marabel)\r\n" +
							  "2 dl sooja piima\r\n" +
							  "50 g võid\r\n" +
							  "soola ja musta pipart\r\n\r\n" +
							  "**Valmistamine:**\r\n" +
							  "Vala vesi ära ja lase kartulitel potis veidi auruda. Tambi kartulid pudrunuia abil katki, lisades samal ajal vähehaaval kuuma piima ja tükeldatud või. Klopi puder puulusikaga kohevaks. Maitsesta soola ja pipraga ja serveeri.",
				AccentColorStart = Color.FromArgb("#a480cf"),
				AccentColorEnd = Color.FromArgb("#779be7"),
				Images = new()
				{
					"https://nami-nami.ee/files/recipes/7337/Juta2021OliivoliKartulipuder.jpg"
				}
			},

		};

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
