using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class GoldChest : ModSystem
	{
		public override void AddRecipes()
		{
			var band_of_regen = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.BandofRegeneration);

			band_of_regen.AddIngredient(ItemID.LifeCrystal, 2);
			band_of_regen.AddIngredient(ItemID.Ruby, 5);
			band_of_regen.AddIngredient(ItemID.HealingPotion, 10);
			band_of_regen.AddTile(TileID.Anvils);
			band_of_regen.Register();

			var magic_mirror = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MagicMirror);

			magic_mirror.AddIngredient(ItemID.RecallPotion, 30);
			magic_mirror.AddIngredient(ItemID.ManaCrystal, 2);
			magic_mirror.AddRecipeGroup("geckqol:GPBar", 5);
			magic_mirror.AddTile(TileID.TinkerersWorkbench);
			magic_mirror.Register();

			var cloud_bottle = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.CloudinaBottle);

			cloud_bottle.AddIngredient(ItemID.Bottle, 1);
			cloud_bottle.AddRecipeGroup("geckqol:CloudBlocks", 200);
			cloud_bottle.AddTile(TileID.SkyMill);
			cloud_bottle.Register();

			var hermes_boots = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.HermesBoots);

			hermes_boots.AddIngredient(ItemID.Feather, 6);
			hermes_boots.AddIngredient(ItemID.SwiftnessPotion, 5);
			hermes_boots.AddIngredient(ItemID.Silk, 20);
			hermes_boots.AddTile(TileID.TinkerersWorkbench);
			hermes_boots.Register();

			var mace = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Mace);

			mace.AddRecipeGroup("IronBar", 20);
			mace.AddIngredient(ItemID.Wood, 10);
			mace.AddTile(TileID.HeavyWorkBench);
			mace.Register();

			var shoe_spikes = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.ShoeSpikes);

			shoe_spikes.AddRecipeGroup("IronBar", 15);
			shoe_spikes.AddIngredient(ItemID.Spike, 6);
			shoe_spikes.AddTile(TileID.TinkerersWorkbench);
			shoe_spikes.Register();

			var flare_gun = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.FlareGun);

			flare_gun.AddIngredient(ItemID.Amber, 3);
			flare_gun.AddIngredient(ItemID.Torch, 10);
			flare_gun.AddRecipeGroup("geckqol:GPBar", 5);
			flare_gun.AddTile(TileID.Anvils);
			flare_gun.Register();

			var extractinator = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.Extractinator);

			extractinator.AddRecipeGroup("IronBar", 20);
			extractinator.AddIngredient(ItemID.Wire, 10);
			extractinator.AddIngredient(ItemID.GlassKiln, 1);
			extractinator.AddTile(TileID.HeavyWorkBench);
			extractinator.Register();

			var lava_charm = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.LavaCharm);

			lava_charm.AddIngredient(ItemID.LavaBucket, 5);
			lava_charm.AddIngredient(ItemID.HellstoneBar, 25);
			lava_charm.AddTile(TileID.Hellforge);
			lava_charm.Register();

			var lucky_horseshoe = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.LavaCharm);

			lucky_horseshoe.AddRecipeGroup("geckqol:GPBar", 15);
			lucky_horseshoe.AddIngredient(ItemID.FeatherfallPotion, 5);
			lucky_horseshoe.AddTile(TileID.TinkerersWorkbench);
			lucky_horseshoe.Register();
		}
	}
}