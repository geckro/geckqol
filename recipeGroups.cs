using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace geckqol
{
	public class recipeGroups : ModSystem
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("Gold or Platinum Bar"), new int[] {
				ItemID.PlatinumBar,
				ItemID.GoldBar 
			});
            RecipeGroup.RegisterGroup("geckqol:GPBar", group);
			group = new RecipeGroup(() => Language.GetTextValue("Any Cloud Block"), new int[] {
				ItemID.Cloud,
				ItemID.RainCloud,
				ItemID.SnowCloudBlock
			});
            RecipeGroup.RegisterGroup("geckqol:CloudBlocks", group);
			group = new RecipeGroup(() => Language.GetTextValue("Any Evil Bar"), new int[] {
				ItemID.DemoniteBar,
				ItemID.CrimtaneBar
			});
            RecipeGroup.RegisterGroup("geckqol:EvilBar", group);
			group = new RecipeGroup(() => Language.GetTextValue("Hellbat or Lava Bat Banner"), new int[] {
				ItemID.HellbatBanner,
				ItemID.LavaBatBanner
			});
            RecipeGroup.RegisterGroup("geckqol:FireBat", group);
			group = new RecipeGroup(() => Language.GetTextValue("Gold or Platinum Sword"), new int[] {
				ItemID.GoldBroadsword,
				ItemID.PlatinumBroadsword
			});
            RecipeGroup.RegisterGroup("geckqol:GPSword", group);
			group = new RecipeGroup(() => Language.GetTextValue("Musket or Undertaker"), new int[] {
				ItemID.Musket,
				ItemID.TheUndertaker
			});
            RecipeGroup.RegisterGroup("geckqol:EvilGun", group);
			group = new RecipeGroup(() => Language.GetTextValue("Any Sprint Boots"), new int[] {
				ItemID.HermesBoots,
				ItemID.SandBoots,
				ItemID.SailfishBoots,
				ItemID.FlurryBoots
			});
            RecipeGroup.RegisterGroup("geckqol:Boots", group);
			group = new RecipeGroup(() => Language.GetTextValue("Any Normal Slime Banner"), new int[] {
				ItemID.SlimeBanner,
				ItemID.GreenSlimeBanner,
				ItemID.BlackSlimeBanner,
				ItemID.IceSlimeBanner,
				ItemID.IlluminantSlimeBanner,
				ItemID.JungleSlimeBanner,
				ItemID.MotherSlimeBanner,
				ItemID.PurpleSlimeBanner,
				ItemID.RedSlimeBanner,
				ItemID.SpikedIceSlimeBanner,
				ItemID.SpikedJungleSlimeBanner,
				ItemID.YellowSlimeBanner,
				ItemID.SandSlimeBanner,
				ItemID.SlimerBanner,
				ItemID.CorruptSlimeBanner,
				ItemID.ToxicSludgeBanner
			});
            RecipeGroup.RegisterGroup("geckqol:SlimeBanners", group);
			group = new RecipeGroup(() => Language.GetTextValue("Hornet or Man Eater banner"), new int[] {
				ItemID.HornetBanner,
				ItemID.ManEaterBanner
			});
            RecipeGroup.RegisterGroup("geckqol:CobaltBanners", group);
			group = new RecipeGroup(() => Language.GetTextValue("Any Dungeon Banner"), new int[] {
				ItemID.AngryBonesBanner,
				ItemID.SkeletonMageBanner,
				ItemID.CursedSkullBanner,
				ItemID.BlueArmoredBonesBanner,
				ItemID.RustyArmoredBonesBanner,
				ItemID.HellArmoredBonesBanner
			});
            RecipeGroup.RegisterGroup("geckqol:DungeonBanner", group);
			group = new RecipeGroup(() => Language.GetTextValue("Any Antlion Banner"), new int[] {
				ItemID.WalkingAntlionBanner,
				ItemID.FlyingAntlionBanner,
			});
            RecipeGroup.RegisterGroup("geckqol:AntlionBanner", group);
		}
	}
}