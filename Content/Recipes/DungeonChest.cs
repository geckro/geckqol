using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class DungeonChest : ModSystem
	{
		public override void AddRecipes()
		{
			var magic_missile = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MagicMissile);

			magic_missile.AddIngredient(ItemID.IceBlock, 150);
			magic_missile.AddIngredient(ItemID.FallenStar, 5);
			magic_missile.AddIngredient(ItemID.Bone, 10);
			magic_missile.AddTile(TileID.BoneWelder);
			magic_missile.Register();

			var muramasa = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Muramasa);

			muramasa.AddIngredient(ItemID.Katana, 1);
			muramasa.AddIngredient(ItemID.WaterBucket, 5);
			muramasa.AddRecipeGroup("geckqol:GPBar", 5);
			muramasa.AddTile(TileID.BoneWelder);
			muramasa.Register();

			var cobalt_shield = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CobaltShield);

			cobalt_shield.AddIngredient(ItemID.CobaltBar, 10);
			cobalt_shield.AddRecipeGroup("geckqol:GPBar", 5);
			cobalt_shield.AddTile(TileID.MythrilAnvil);
			cobalt_shield.Register();

			var aqua_scepter = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.AquaScepter);

			aqua_scepter.AddIngredient(ItemID.WaterGun, 1);
			aqua_scepter.AddIngredient(ItemID.WaterBucket, 5);
			aqua_scepter.AddRecipeGroup("geckqol:EvilBar", 10);
			aqua_scepter.AddTile(TileID.BoneWelder);
			aqua_scepter.Register();

			var valor = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Valor);

			valor.AddIngredient(ItemID.Rally, 1);
			valor.AddIngredient(ItemID.Bone, 30);
			valor.AddTile(TileID.BoneWelder);
			valor.Register();

			var handgun = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Handgun);

			handgun.AddIngredient(ItemID.Minishark, 1);
			handgun.AddIngredient(ItemID.IllegalGunParts, 1);
			handgun.AddIngredient(ItemID.Bone, 100);
			handgun.AddTile(TileID.BoneWelder);
			handgun.Register();

			var shadow_key = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.ShadowKey);

			shadow_key.AddIngredient(ItemID.GoldenKey, 1);
			shadow_key.AddIngredient(ItemID.Obsidian, 75);
			shadow_key.AddIngredient(ItemID.AngryBonesBanner, 1);
			shadow_key.AddTile(TileID.BoneWelder);
			shadow_key.Register();
		}
	}
}