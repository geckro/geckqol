using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class SurfaceChest : ModSystem
	{
		public override void AddRecipes()
		{
			var spear = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Spear);

			spear.AddRecipeGroup("IronBar", 10);
			spear.AddRecipeGroup("geckqol:GPBar", 5);
			spear.AddTile(TileID.Anvils);
			spear.Register();

			var blowpipe = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Blowpipe);

			blowpipe.AddIngredient(ItemID.Acorn, 5);
			blowpipe.AddIngredient(ItemID.Wood, 50);
			blowpipe.AddIngredient(ItemID.WoodenArrow, 10);
			blowpipe.AddTile(TileID.WorkBenches);
			blowpipe.Register();

			var wooden_boomerang = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.WoodenBoomerang);

			wooden_boomerang.AddIngredient(ItemID.Wood, 100);
			wooden_boomerang.AddRecipeGroup("IronBar", 10);
			wooden_boomerang.AddTile(TileID.WorkBenches);
			wooden_boomerang.Register();

			var aglet = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Aglet);

			aglet.AddRecipeGroup("geckqol:GPBar", 5);
			aglet.AddIngredient(ItemID.SwiftnessPotion, 3);
			aglet.AddTile(TileID.TinkerersWorkbench);
			aglet.Register();

			var climbing_claws = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.ClimbingClaws);

			climbing_claws.AddRecipeGroup("IronBar", 10);
			climbing_claws.AddIngredient(ItemID.Spike, 6);
			climbing_claws.AddTile(TileID.WorkBenches);
			climbing_claws.Register();

			var umbrella = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Umbrella);

			umbrella.AddIngredient(ItemID.Silk, 20);
			umbrella.AddIngredient(ItemID.Wood, 25);
			umbrella.AddTile(TileID.Loom);
			umbrella.Register();

			var guide_plant_cordage = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CordageGuide);

			guide_plant_cordage.AddIngredient(ItemID.Rope, 500);
			guide_plant_cordage.AddIngredient(ItemID.Book, 1);
			guide_plant_cordage.AddTile(TileID.Bookcases);
			guide_plant_cordage.Register();

			var wand_of_sparking = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.WandofSparking);

			wand_of_sparking.AddIngredient(ItemID.Wood, 50);
			wand_of_sparking.AddIngredient(ItemID.LeafWand, 1);
			wand_of_sparking.AddTile(TileID.WorkBenches);
			wand_of_sparking.Register();

			var radar = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Radar);

			radar.AddRecipeGroup("IronBar", 10);
			radar.AddIngredient(ItemID.Chain, 25);
			radar.AddTile(TileID.TinkerersWorkbench);
			radar.Register();

			var step_stool = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.PortableStool);

			step_stool.AddIngredient(ItemID.Wood, 200);
			step_stool.AddTile(TileID.Sawmill);
			step_stool.Register();
		}
	}
}