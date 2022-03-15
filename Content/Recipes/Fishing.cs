using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class Fishing : ModSystem
	{
		public override void AddRecipes()
		{
			var crystal_serpent = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CrystalSerpent);

			crystal_serpent.AddIngredient(ItemID.CrystalShard, 75);
			crystal_serpent.AddIngredient(ItemID.HallowedFishingCrateHard, 3);
			crystal_serpent.AddTile(TileID.Anvils);
			crystal_serpent.Register();


		}
	}
}