using Terraria.ModLoader;

namespace Fargowiltas.Items.Summons.SwarmSummons.Energizers
{
    public class EnergizerSkele : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boney Energizer");
            Tooltip.SetDefault("Formed after using 10 Skull Chain Necklaces\n'Reminds you of a cow'");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.rare = 1;
            Item.value = 100000;
        }
    }
}