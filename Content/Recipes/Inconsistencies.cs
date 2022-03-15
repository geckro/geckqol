using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class Inconsistencies : ModSystem
	{
		public override void AddRecipes()
		{
			var mudDirt = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.DirtBlock);

			mudDirt.AddIngredient(ItemID.MudBlock, 1);
			mudDirt.AddCondition(Recipe.Condition.NearLava);
			mudDirt.Register();


		}
	}
}