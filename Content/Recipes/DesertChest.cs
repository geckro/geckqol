using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class DesertChest : ModSystem
	{
		public override void AddRecipes()
		{
			var storm_spear = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.ThunderSpear);

			storm_spear.AddIngredient(ItemID.Spear, 1);
			storm_spear.AddIngredient(ItemID.AntlionMandible, 15);
			storm_spear.AddRecipeGroup("geckqol:EvilBar", 10);
			storm_spear.AddTile(TileID.Anvils);
			storm_spear.Register();

			var thunder_zapper = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.ThunderStaff);

			thunder_zapper.AddIngredient(ItemID.WandofSparking, 1);
			thunder_zapper.AddIngredient(ItemID.AntlionMandible, 10);
			thunder_zapper.AddRecipeGroup("geckqol:EvilBar", 10);
			thunder_zapper.AddTile(TileID.Anvils);
			thunder_zapper.Register();

			var magic_conch = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MagicConch);

			magic_conch.AddIngredient(ItemID.Coral, 20);
			magic_conch.AddIngredient(ItemID.Seashell, 5);
			magic_conch.AddIngredient(ItemID.RecallPotion, 5);
			magic_conch.AddIngredient(ItemID.AntlionMandible, 5);
			magic_conch.AddTile(TileID.Anvils);
			magic_conch.Register();

			var snake_charmerflute = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MysticCoilSnake);

			snake_charmerflute.AddIngredient(ItemID.Rope, 999);
			snake_charmerflute.AddIngredient(ItemID.AntlionMandible, 5);
			snake_charmerflute.AddTile(TileID.Anvils);
			snake_charmerflute.Register();

			var ancient_chisel = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.AncientChisel);

			ancient_chisel.AddIngredient(ItemID.MiningPotion, 10);
			ancient_chisel.AddIngredient(ItemID.MoltenPickaxe, 1);
			ancient_chisel.AddIngredient(ItemID.AntlionMandible, 5);
			ancient_chisel.AddTile(TileID.Anvils);
			ancient_chisel.Register();

			var dunerider_boots = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.SandBoots);

			dunerider_boots.AddIngredient(ItemID.Feather, 6);
			dunerider_boots.AddIngredient(ItemID.SwiftnessPotion, 5);
			dunerider_boots.AddIngredient(ItemID.Silk, 20);
			dunerider_boots.AddIngredient(ItemID.SandBlock, 999);
			dunerider_boots.AddTile(TileID.TinkerersWorkbench);
			dunerider_boots.Register();

			var bast_statue = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CatBast);

			bast_statue.AddIngredient(ItemID.GardenGnome, 1);
			bast_statue.AddIngredient(ItemID.IronskinPotion, 5);
			bast_statue.AddIngredient(ItemID.AntlionMandible, 15);
			bast_statue.AddTile(TileID.Anvils);
			bast_statue.Register();

			var desert_minecart = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.DesertMinecart);

			desert_minecart.AddIngredient(ItemID.Minecart, 1);
			desert_minecart.AddIngredient(ItemID.SandBlock, 500);
			desert_minecart.AddIngredient(ItemID.AntlionMandible, 15);
			desert_minecart.AddTile(TileID.Anvils);
			desert_minecart.Register();

			var encumber_stone = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.EncumberingStone);

			encumber_stone.AddRecipeGroup("IronBar", 50);
			encumber_stone.AddIngredient(ItemID.Spike, 50);
			encumber_stone.AddTile(TileID.HeavyWorkBench);
			encumber_stone.Register();
		}
	}
}