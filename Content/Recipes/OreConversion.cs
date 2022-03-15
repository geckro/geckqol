using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class OreConversion : ModSystem
	{
		public override void AddRecipes()
		{
			var TinO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.TinOre);

			TinO.AddIngredient(ItemID.CopperOre, 2);
			TinO.AddTile(TileID.CrystalBall);
			TinO.Register();

			var copperO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CopperOre);

			copperO.AddIngredient(ItemID.TinOre, 2);
			copperO.AddTile(TileID.CrystalBall);
			copperO.Register();

			var leadO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.LeadOre);

			leadO.AddIngredient(ItemID.IronOre, 2);
			leadO.AddTile(TileID.CrystalBall);
			leadO.Register();

			var ironO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.IronOre);

			ironO.AddIngredient(ItemID.LeadOre, 2);
			ironO.AddTile(TileID.CrystalBall);
			ironO.Register();

			var tungstenO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.TungstenOre);

			tungstenO.AddIngredient(ItemID.SilverOre, 2);
			tungstenO.AddTile(TileID.CrystalBall);
			tungstenO.Register();

			var silverO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.SilverOre);

			silverO.AddIngredient(ItemID.TungstenOre, 2);
			silverO.AddTile(TileID.CrystalBall);
			silverO.Register();

			var platinumO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.PlatinumOre);

			platinumO.AddIngredient(ItemID.GoldOre, 2);
			platinumO.AddTile(TileID.CrystalBall);
			platinumO.Register();

			var goldO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.GoldOre);

			goldO.AddIngredient(ItemID.PlatinumOre, 2);
			goldO.AddTile(TileID.CrystalBall);
			goldO.Register();

			var crimO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CrimtaneOre);

			crimO.AddIngredient(ItemID.DemoniteOre, 2);
			crimO.AddTile(TileID.CrystalBall);
			crimO.Register();

			var demonO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.DemoniteOre);

			demonO.AddIngredient(ItemID.CrimtaneOre, 2);
			demonO.AddTile(TileID.CrystalBall);
			demonO.Register();

			var pallO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.PalladiumOre);

			pallO.AddIngredient(ItemID.CobaltOre, 2);
			pallO.AddTile(TileID.CrystalBall);
			pallO.Register();

			var cobaltO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CobaltOre);

			cobaltO.AddIngredient(ItemID.PalladiumOre, 2);
			cobaltO.AddTile(TileID.CrystalBall);
			cobaltO.Register();

			var oricO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.OrichalcumOre);

			oricO.AddIngredient(ItemID.MythrilOre, 2);
			oricO.AddTile(TileID.CrystalBall);
			oricO.Register();

			var mythO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MythrilOre);

			mythO.AddIngredient(ItemID.OrichalcumOre, 2);
			mythO.AddTile(TileID.CrystalBall);
			mythO.Register();

			var titaO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.TitaniumOre);

			titaO.AddIngredient(ItemID.AdamantiteOre, 3);
			titaO.AddTile(TileID.CrystalBall);
			titaO.Register();

			var adamO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.AdamantiteOre);

			adamO.AddIngredient(ItemID.TitaniumOre, 3);
			adamO.AddTile(TileID.CrystalBall);
			adamO.Register();
		}
	}
}