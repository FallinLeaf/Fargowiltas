using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Fargowiltas.Items.Summons
{
    public class TruffleWorm2 : BaseSummon
    {
        public override string Texture => "Terraria/Images/Item_2673";

        public override int NPCType => NPCID.DukeFishron;

        public override string NPCName => FargoUtils.IsChinese() ? "猪龙鱼公爵" : "Duke Fishron";

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Truffly Worm");
            Tooltip.SetDefault("Summons Duke Fishron without fishing");
        }

        public override void AddRecipes()
        {
            CreateRecipe()
               .AddIngredient(ItemID.TruffleWorm)
               .AddTile(TileID.WorkBenches)
               .Register();
        }
    }
}