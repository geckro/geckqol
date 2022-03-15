using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class IceChest : ModSystem
	{
		public override void AddRecipes()
		{
			var ice_boomerang = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.IceBoomerang);

			ice_boomerang.AddIngredient(ItemID.EnchantedBoomerang, 1);
			ice_boomerang.AddIngredient(ItemID.IceBlock, 200);
			ice_boomerang.AddTile(TileID.Anvils);
			ice_boomerang.Register();

			var ice_blade = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.IceBlade);

			ice_blade.AddRecipeGroup("geckqol:GPSword", 1);
			ice_blade.AddIngredient(ItemID.IceBlock, 100);
			ice_blade.AddIngredient(ItemID.IceTorch, 50);
			ice_blade.AddTile(TileID.Anvils);
			ice_blade.Register();

			var ice_skates = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.IceSkates);

			ice_skates.AddIngredient(ItemID.IceBlock, 200);
			ice_skates.AddRecipeGroup("geckqol:GPBar", 5);
			ice_skates.AddTile(TileID.Anvils);
			ice_skates.Register();

			var snowball_cannon = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.SnowballCannon);

			snowball_cannon.AddIngredient(ItemID.Snowball, 999);
			snowball_cannon.AddRecipeGroup("geckqol:EvilGun", 1);
			snowball_cannon.AddTile(TileID.Anvils);
			snowball_cannon.Register();

			var blizzard_bottle = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.BlizzardinaBottle);

			blizzard_bottle.AddIngredient(ItemID.CloudinaBottle, 1);
			blizzard_bottle.AddIngredient(ItemID.IceBlock, 300);
			blizzard_bottle.AddTile(TileID.SkyMill);
			blizzard_bottle.Register();

			var flurry_boots = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.FlurryBoots);

			flurry_boots.AddIngredient(ItemID.Feather, 6);
			flurry_boots.AddIngredient(ItemID.SwiftnessPotion, 5);
			flurry_boots.AddIngredient(ItemID.Silk, 20);
			flurry_boots.AddIngredient(ItemID.IceBlock, 400);
			flurry_boots.AddIngredient(ItemID.SnowBlock, 400);
			flurry_boots.AddTile(TileID.TinkerersWorkbench);
			flurry_boots.Register();

			var ice_fish = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Fish);

			ice_fish.AddIngredient(ItemID.IceBlock, 200);
			ice_fish.AddIngredient(ItemID.Bass, 5);
			ice_fish.AddIngredient(ItemID.AtlanticCod, 5);
			ice_fish.AddIngredient(ItemID.FrostMinnow, 5);
			ice_fish.AddTile(TileID.IceMachine);
			ice_fish.Register();

			var ice_machine = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.IceMachine);

			ice_machine.AddIngredient(ItemID.IceBlock, 999);
			ice_machine.AddIngredient(ItemID.Solidifier, 1);
			ice_machine.AddTile(TileID.HeavyWorkBench);
			ice_machine.Register();

			var ice_mirror = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.IceMirror);

			ice_mirror.AddIngredient(ItemID.MagicMirror, 1);
			ice_mirror.AddIngredient(ItemID.IceBlock, 100);
			ice_mirror.AddTile(TileID.CrystalBall);
			ice_mirror.Register();
		}
	}
}