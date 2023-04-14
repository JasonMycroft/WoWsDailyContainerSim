using System.Security.Cryptography;

namespace SCRework.LootBoxes
{
    public static class MoreCoal
    {
        public static List<(string lootType, int quantity)> Open(){
            var contents = new List<(string lootType, int quantity)>() { (LootType.Coal, 400) };

            int x = RandomNumberGenerator.GetInt32(100);
            if (x < 5)
                contents.Add((LootType.Coal, 400));
            else if(x < 20)
                contents.Add((LootType.Credits, 50000));
            else
                contents.Add((LootType.GreyBooster, 3));

            x = RandomNumberGenerator.GetInt32(100);
            if (x < 25)
                contents.Add((LootType.Coal, 400));
            else if (x < 60)
                contents.Add((LootType.Ecxp, 1500));
            else
                contents.Add((LootType.Fxp, 500));

            return contents;
        }
    }
}
