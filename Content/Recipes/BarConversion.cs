using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class BarConversion : ModSystem
	{
		public override void AddRecipes()
		{
			var TinO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.TinBar);

			TinO.AddIngredient(ItemID.CopperBar, 2);
			TinO.AddTile(TileID.CrystalBall);
			TinO.Register();

			var copperO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CopperBar);

			copperO.AddIngredient(ItemID.	TinBar, 2);
			copperO.AddTile(TileID.CrystalBall);
			copperO.Register();

			var leadO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.LeadBar);

			leadO.AddIngredient(ItemID.IronBar, 2);
			leadO.AddTile(TileID.CrystalBall);
			leadO.Register();

			var ironO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.IronBar);

			ironO.AddIngredient(ItemID.LeadBar, 2);
			ironO.AddTile(TileID.CrystalBall);
			ironO.Register();

			var tungstenO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.TungstenBar);

			tungstenO.AddIngredient(ItemID.SilverBar, 2);
			tungstenO.AddTile(TileID.CrystalBall);
			tungstenO.Register();

			var silverO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.SilverBar);

			silverO.AddIngredient(ItemID.TungstenBar, 2);
			silverO.AddTile(TileID.CrystalBall);
			silverO.Register();

			var platinumO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.PlatinumBar);

			platinumO.AddIngredient(ItemID.GoldBar, 2);
			platinumO.AddTile(TileID.CrystalBall);
			platinumO.Register();

			var goldO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.GoldBar);

			goldO.AddIngredient(ItemID.PlatinumBar, 2);
			goldO.AddTile(TileID.CrystalBall);
			goldO.Register();

			var crimO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CrimtaneBar);

			crimO.AddIngredient(ItemID.DemoniteBar, 2);
			crimO.AddTile(TileID.CrystalBall);
			crimO.Register();

			var demonO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.DemoniteBar);

			demonO.AddIngredient(ItemID.CrimtaneBar, 2);
			demonO.AddTile(TileID.CrystalBall);
			demonO.Register();

			var pallO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.PalladiumBar);

			pallO.AddIngredient(ItemID.CobaltBar, 2);
			pallO.AddTile(TileID.CrystalBall);
			pallO.Register();

			var cobaltO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CobaltBar);

			cobaltO.AddIngredient(ItemID.PalladiumBar, 2);
			cobaltO.AddTile(TileID.CrystalBall);
			cobaltO.Register();

			var oricO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.OrichalcumBar);

			oricO.AddIngredient(ItemID.MythrilBar, 2);
			oricO.AddTile(TileID.CrystalBall);
			oricO.Register();

			var mythO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MythrilBar);

			mythO.AddIngredient(ItemID.OrichalcumBar, 2);
			mythO.AddTile(TileID.CrystalBall);
			mythO.Register();

			var titaO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.TitaniumBar);

			titaO.AddIngredient(ItemID.AdamantiteBar, 3);
			titaO.AddTile(TileID.CrystalBall);
			titaO.Register();

			var adamO = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.AdamantiteBar);

			adamO.AddIngredient(ItemID.TitaniumBar, 3);
			adamO.AddTile(TileID.CrystalBall);
			adamO.Register();
		}
	}
}