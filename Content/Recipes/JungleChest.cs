using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class JungleChest : ModSystem
	{
		public override void AddRecipes()
		{
			var feral_claws = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.FeralClaws);

			feral_claws.AddIngredient(ItemID.JungleSpores, 12);
			feral_claws.AddIngredient(ItemID.Stinger, 5);
			feral_claws.AddIngredient(ItemID.Vine, 2);
			feral_claws.AddTile(TileID.Anvils);
			feral_claws.Register();

			var anklet_wind = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.AnkletoftheWind);

			anklet_wind.AddIngredient(ItemID.Vine, 8);
			anklet_wind.AddIngredient(ItemID.LargeAmethyst, 1);
			anklet_wind.AddTile(TileID.Anvils);
			anklet_wind.Register();

			var staff_regrowth = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.StaffofRegrowth);

			staff_regrowth.AddIngredient(ItemID.GrassSeeds, 200);
			staff_regrowth.AddIngredient(ItemID.JungleSpores, 5);
			staff_regrowth.AddIngredient(ItemID.Vine, 3);
			staff_regrowth.AddTile(TileID.Anvils);
			staff_regrowth.Register();

			var boomstick = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Boomstick);

			boomstick.AddIngredient(ItemID.FlintlockPistol, 1);
			boomstick.AddIngredient(ItemID.HornetBanner, 1);
			boomstick.AddTile(TileID.Anvils);
			boomstick.Register();

			var flower_boots = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.FlowerBoots);

			flower_boots.AddRecipeGroup("geckqol:Boots", 1);
			flower_boots.AddIngredient(ItemID.GarlandHat, 5);
			flower_boots.AddIngredient(ItemID.Vine, 3);
			flower_boots.AddTile(TileID.Anvils);
			flower_boots.Register();

			var fiberglass_pole = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.FiberglassFishingPole);

			fiberglass_pole.AddIngredient(ItemID.Glass, 100);
			fiberglass_pole.AddIngredient(ItemID.Vine, 5);
			fiberglass_pole.AddIngredient(ItemID.ReinforcedFishingPole, 1);
			fiberglass_pole.AddTile(TileID.TinkerersWorkbench);
			fiberglass_pole.Register();

			var seaweed = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Seaweed);

			seaweed.AddIngredient(ItemID.FishingSeaweed, 3);
			seaweed.AddIngredient(ItemID.Vine, 3);
			seaweed.AddIngredient(ItemID.JungleSpores, 10);
			seaweed.AddTile(TileID.Anvils);
			seaweed.Register();

			var bee_minecart = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.BeeMinecart);

			bee_minecart.AddIngredient(ItemID.BeeWax, 15);
			bee_minecart.AddIngredient(ItemID.Minecart, 1);
			bee_minecart.AddTile(TileID.HoneyDispenser);
			bee_minecart.Register();

			var honey_dispenser = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.HoneyDispenser);

			honey_dispenser.AddIngredient(ItemID.BeeWax, 10);
			honey_dispenser.AddIngredient(ItemID.Furnace, 1);
			honey_dispenser.AddTile(TileID.HeavyWorkBench);
			honey_dispenser.Register();
		}
	}
}