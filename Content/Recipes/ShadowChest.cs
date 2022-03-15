using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class ShadowChest : ModSystem
	{
		public override void AddRecipes()
		{
			var sunfury = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Sunfury);

			sunfury.AddIngredient(ItemID.FlamingMace, 1);
			sunfury.AddIngredient(ItemID.HellstoneBar, 25);
			sunfury.AddTile(TileID.BoneWelder);
			sunfury.Register();

			var flower_fire = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.FlowerofFire);

			flower_fire.AddIngredient(ItemID.NaturesGift, 1);
			flower_fire.AddIngredient(ItemID.HellstoneBar, 25);
			flower_fire.AddTile(TileID.BoneWelder);
			flower_fire.Register();

			var flamelash = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MagicMissile);

			flamelash.AddIngredient(ItemID.MagicMissile, 1);
			flamelash.AddIngredient(ItemID.HellstoneBar, 25);
			flamelash.AddTile(TileID.BoneWelder);
			flamelash.Register();

			var dark_lance = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MagicMissile);

			dark_lance.AddIngredient(ItemID.Trident, 1);
			dark_lance.AddIngredient(ItemID.Obsidian, 25);
			dark_lance.AddRecipeGroup("geckqol:EvilBar", 10);
			dark_lance.AddTile(TileID.BoneWelder);
			dark_lance.Register();

			var hellwing_bow = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.HellwingBow);

			hellwing_bow.AddIngredient(ItemID.MoltenFury, 1);
			hellwing_bow.AddRecipeGroup("geckqol:FireBat", 1);
			hellwing_bow.AddTile(TileID.BoneWelder);
			hellwing_bow.Register();

			var treasure_magnet = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.TreasureMagnet);

			treasure_magnet.AddIngredient(ItemID.LuckyHorseshoe, 1);
			treasure_magnet.AddIngredient(ItemID.HallowedBar, 5);
			treasure_magnet.AddTile(TileID.BoneWelder);
			treasure_magnet.Register();

			var demonic_hellcart = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.HellMinecart);

			demonic_hellcart.AddIngredient(ItemID.DemonBanner, 1);
			demonic_hellcart.AddIngredient(ItemID.LavaCharm, 1);
			demonic_hellcart.AddIngredient(ItemID.Minecart, 1);
			demonic_hellcart.AddTile(TileID.BoneWelder);
			demonic_hellcart.Register();

			var ornate_shadowkey = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.OrnateShadowKey);

			ornate_shadowkey.AddIngredient(ItemID.ShadowKey, 1);
			ornate_shadowkey.AddIngredient(ItemID.HellstoneBar, 5);
			ornate_shadowkey.AddIngredient(ItemID.ShadowChest, 1);
			ornate_shadowkey.AddTile(TileID.BoneWelder);
			ornate_shadowkey.Register();

			var slice_hellcake = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.HellCake);

			slice_hellcake.AddIngredient(ItemID.SliceOfCake, 1);
			slice_hellcake.AddIngredient(ItemID.Obsidian, 50);
			slice_hellcake.AddIngredient(ItemID.FireImpBanner, 1);
			slice_hellcake.AddTile(TileID.BoneWelder);
			slice_hellcake.Register();
		}
	}
}