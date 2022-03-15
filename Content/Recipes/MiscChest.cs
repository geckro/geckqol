using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol.Content.Recipes
{
	public class MiscChest : ModSystem
	{
		public override void AddRecipes()
		{
			var shroom_cart = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.ShroomMinecart);

			shroom_cart.AddIngredient(ItemID.GlowingMushroom, 200);
			shroom_cart.AddIngredient(ItemID.Minecart, 1);
			shroom_cart.AddTile(TileID.Anvils);
			shroom_cart.Register();

			var mushroom_hat = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MushroomHat);

			mushroom_hat.AddIngredient(ItemID.GlowingMushroom, 50);
			mushroom_hat.AddIngredient(ItemID.Mushroom, 25);
			mushroom_hat.AddIngredient(ItemID.BlackThread, 3);
			mushroom_hat.AddTile(TileID.Anvils);
			mushroom_hat.Register();

			var mushroom_chest = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MushroomVest);

			mushroom_chest.AddIngredient(ItemID.GlowingMushroom, 50);
			mushroom_chest.AddIngredient(ItemID.BlackThread, 3);
			mushroom_chest.AddTile(TileID.Anvils);
			mushroom_chest.Register();

			var mushroom_pants = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.MushroomPants);

			mushroom_pants.AddIngredient(ItemID.GlowingMushroom, 50);
			mushroom_pants.AddIngredient(ItemID.BlackThread, 3);
			mushroom_pants.AddTile(TileID.Anvils);
			mushroom_pants.Register();

			var web_slinger = ModContent.GetInstance<geckqol>().CreateRecipe(ItemID.WebSlinger);

			web_slinger.AddIngredient(ItemID.Cobweb, 250);
			web_slinger.AddIngredient(ItemID.GrapplingHook, 1);
			web_slinger.AddTile(TileID.Anvils);
			web_slinger.Register();

		}
	}
}