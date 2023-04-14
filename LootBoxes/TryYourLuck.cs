using System.Security.Cryptography;

namespace SCRework.LootBoxes
{
    public static class TryYourLuck
    {
        public static (string lootType, int quantity) Open()
        {
            int x = RandomNumberGenerator.GetInt32(200);
            if (x < 2)
                return (LootType.Port, 1);
            else if (x < 3)
                return (LootType.Credits, 75000);
            else if (x < 15)
                return (LootType.Camo, 2);
            else if (x < 105)
                return (LootType.Flags, 6);
            else if (x < 145)
                return (LootType.GreyBooster, 6);
            else if (x < 165)
                return (LootType.Coal, 900);
            return (LootType.Fxp, 750);
        }
    }
}
