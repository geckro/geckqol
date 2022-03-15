using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class MobDrops : ModSystem
	{
		public override void AddRecipes()
		{
			var slime_staff = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.SlimeStaff);

			slime_staff.AddRecipeGroup("geckqol:SlimeBanners", 150);
			slime_staff.AddTile(TileID.Anvils);
			slime_staff.Register();

			var slime_staff_pink = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.SlimeStaff);

			slime_staff_pink.AddIngredient(ItemID.PinkyBanner, 2);
			slime_staff_pink.AddTile(TileID.Anvils);
			slime_staff_pink.Register();

			var ac_helmet = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.AncientCobaltHelmet);

			ac_helmet.AddRecipeGroup("geckqol:CobaltBanners", 4);
			ac_helmet.AddTile(TileID.Anvils);
			ac_helmet.Register();

			var ac_chest = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.AncientCobaltBreastplate);

			ac_chest.AddRecipeGroup("geckqol:CobaltBanners", 4);
			ac_chest.AddTile(TileID.Anvils);
			ac_chest.Register();

			var ac_pants = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.AncientCobaltLeggings);

			ac_pants.AddRecipeGroup("geckqol:CobaltBanners", 4);
			ac_pants.AddTile(TileID.Anvils);
			ac_pants.Register();

			var money_trough = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MoneyTrough);

			money_trough.AddIngredient(ItemID.PiggyBank, 8);
			money_trough.AddIngredient(ItemID.GiantHarpyFeather, 1);
			money_trough.AddTile(TileID.Anvils);
			money_trough.Register();

			var goldKey = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.GoldenKey);

			goldKey.AddRecipeGroup("geckqol:DungeonBanner", 1);
			goldKey.Register();

			var bone_wand = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.BoneWand);

			bone_wand.AddIngredient(ItemID.Bone, 200);
			bone_wand.AddIngredient(ItemID.HiveWand, 1);
			bone_wand.AddTile(TileID.BoneWelder);
			bone_wand.Register();

			var ancient_necro = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.AncientNecroHelmet);

			ancient_necro.AddIngredient(ItemID.Bone, 200);
			ancient_necro.AddIngredient(ItemID.Cobweb, 250);
			ancient_necro.AddIngredient(ItemID.NecroHelmet, 1);
			ancient_necro.AddTile(TileID.BoneWelder);
			ancient_necro.Register();

			var mandibleBlade = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.AntlionClaw);

			mandibleBlade.AddIngredient(ItemID.AntlionMandible, 45);
			mandibleBlade.AddRecipeGroup("geckqol:AntlionBanner", 1);
			mandibleBlade.AddTile(TileID.Anvils);
			mandibleBlade.Register();

		}
	}
}