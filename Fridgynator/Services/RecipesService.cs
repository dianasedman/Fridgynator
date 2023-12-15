using System;
using System.Collections.Generic;

namespace Fridgynator.Views
{
	internal static class RecipesService
	{
		private static List<Recipes> recipes = new List<Recipes>
		{
			new()
            {
                Name = "KODUNE HAKKLIHAKASTE",
                Subtitle = "  Parim kaste maailmas",
                HeroImage = "Hakklihakaste.jpg",
                Description = "1 sl võid või õli\r\n\r\n1 sibul\r\n\r\n400-500 g hakkliha (nt Rakvere kodune hakkliha või Rakvere veisehakkliha)\r\n\r\n1 sl nisujahu\r\n\r\n5 dl vett või puljongit\r\n\r\n4 sl Saare hapukoort\r\n\r\nsoola ja musta pipart\r\n\r\nhakitud värsket tilli või peterselli " +
                "Valmistamine: " +
				"Kuumuta pannil või või õli. Lisa hakitud sibul ja prae kergelt läbi. Siis lisa hakkliha ja prae segades, kuni hakkliha on kenasti küps. Maitsesta soola-pipraga.  " +
				"Puista peale nisujahu, sega läbi. Lisa vedelik ning hauta kastet kümmekond minutit. Lõpus sega juurde hapukoor ja soovi korral hakitud maitseroheline. " +
				"Serveeri keedetud kartulite ja värske salatiga. ",
               
                Images = new()
                {
					"https://nami-nami.ee/files/recipes/380/hakklihakaste.jpg"
				}


           },
            new ()
            {
                Name = "Rabarberikook",
                Subtitle = "Suussulav koos",
                HeroImage = "rabarberikook.jpg",
                Description = "Tainas:\r\n100 g võid\r\n\r\n85 g suhkrut (1 dl, võib olla roosuhkur)\r\n\r\n50 g Saare 20% hapukoort\r\n\r\n1 muna\r\n\r\n180 g nisujahu (3 dl)\r\n\r\n1 tl küpsetuspulbrit\r\n\r\nTäidis:\r\n250 g Saare 20% hapukoort\r\n\r\n4 sl suhkrut\r\n\r\n1 muna\r\n\r\n1 tl vanillisuhkrut\r\n\r\nKate:\r\n4-5 rabarbrivart\r\n\r\ndemerara suhkrut " +
				"Vahusta toasoe või suhkruga. Sega juurde hapukoor, muna ja küpsetuspulbriga segatud jahu ning sega tainas ühtlaseks (tainas on pehme, aga mitte vedel). " +
				"Suru tainas võitatud 24 cm lahtikäiva vormi põhjale ja servadele. " +
				"Sega täidiseained omavahel ja kalla vormi. " +
				"Kata tükeldatud rabarbriga* ning puista peale veidi demerara suhkrut. Küpseta 200kraadise ahju keskosas umbes 30 minutit, kuni tainas on kuldne ja täidis hüübinud. Lase veidi vormis jahtuda, siis libista ettevaatlikult koogialusele..",
                
                Images = new List<string>
                {
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778",
                    
                }
                },
            new()
            {
                Name = "Hapukapsasupp",
                Subtitle = "Nii nagu vanaema seda tegi...",
                HeroImage = "hapukapsasupp.jpg",
                Description = "1,5 l vett\r\n\r\n300-400 g sealiha (külje- või kaelatükk)\r\n\r\n300 g hapukapsast\r\n\r\n0,5 dl odrakruupe\r\n\r\n1 suur porgand\r\n\r\n1 sibul\r\n\r\nsoola\r\n\r\nsuhkrusiirupit või suhkrut\r\n\r\n1 väike loorberileht\r\n\r\n2-3 tera musta pipart " +
				"Pane liha vette ja kuumuta keemiseni. Riisu tekkinud vaht. " +
				"Pane seejärel lihale hapukapsas, siis leotatud kruubid, hakitud porgand ja sibul. Maitsesta soola, pipra ja loorberilehega, natuke lisa ka suhkrut või siirupit. Keeda madalal kuumusel umbes kaks tundi, kuni kruubid ja liha on pehmed. " +
				"Timmi maitse parajaks ja serveeri.",
                
                Images = new()
                {
                    "https://science.nasa.gov/_ipx/animated_true&w_1280&f_webp/https://images-assets.nasa.gov/image/PIA20037/PIA20037~orig.jpg%3Fw=1041%26h=717%26fit=clip%26crop=faces%252Cfocalpoint",
                    
                }
         },
            new()
            {
                Name = "Kartulipuder",
                Subtitle = "Maailma parim",
                HeroImage = "kartulipuder.jpg",
                Description = "1 kg kartulit (nt Laura või Marabel)\r\n\r\n2 dl sooja piima\r\n\r\n50 g võid\r\n\r\nsoola ja musta pipart " +
				"Vala vesi ära ja lase kartulitel potis veidi auruda. Tambi kartulid pudrunuia abil katki, lisades samal ajal vähehaaval kuuma piima ja tükeldatud või. Klopi puder puulusikaga kohevaks. Maitsesta soola ja pipraga ja serveeri.",
               
                Images = new()
                {
                    "https://t3.ftcdn.net/jpg/02/71/65/66/240_F_271656664_Vgdjv5mqCxFesA1DtM4e8GUZmhSWNbti.jpg",
                    
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

		public class Recipes
		{
			public string Name { get; set; }
			public string Subtitle { get; set; }
			public string HeroImage { get; set; }
			public string Description { get; set; }
			public List<string> Images { get; set; }
		}
	}
}

