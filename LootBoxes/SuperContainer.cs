using System.Security.Cryptography;

namespace SCRework.LootBoxes
{
    public class SuperContainer
    {
        private static int guaranteedDropCounter = 0;
        private const int guaranteedDrop = 200;
        private static int nextDrop = RandomNumberGenerator.GetInt32(101);

        public static bool OpenMoreCoal()
        {
            nextDrop += 3;
            return nextDrop >= 100;
        }

        public static bool OpenTyl()
        {
            nextDrop += 9;
            return nextDrop >= 100;
        }

        public static void Reset()
        {
            nextDrop = RandomNumberGenerator.GetInt32(101);
        }

        public static (string lootType, int quantity) Open()
        {
            Reset();

            int x = RandomNumberGenerator.GetInt32(10000);
            if (x < 3 || guaranteedDropCounter == guaranteedDrop && x < 300)
            {
                guaranteedDropCounter = 0;
                return (LootType.Ship10, 1);
            }
            else if (x < 18 || guaranteedDropCounter == guaranteedDrop && x < 1800)
            {
                guaranteedDropCounter = 0;
                return (LootType.Ship9, 1);
            }
            else if (x < 100 || guaranteedDropCounter == guaranteedDrop)
            {
                guaranteedDropCounter = 0;
                return (LootType.Ship7, 1);
            }
            else if (x < 2600)
            {
                guaranteedDropCounter++;
                return (LootType.Flags, 50);
            }
            else if (x < 3260)
            {
                guaranteedDropCounter++;
                return (LootType.BlueBooster, 15);
            }
            else if (x < 4860)
            {
                guaranteedDropCounter++;
                return (LootType.GreenBooster, 25);
            }
            else if (x < 6860)
            {
                guaranteedDropCounter++;
                return (LootType.GreyBooster, 50);
            }
            else if (x < 7400)
            {
                guaranteedDropCounter++;
                return (LootType.PT, 7);
            }
            else if (x < 7900)
            {
                guaranteedDropCounter++;
                return (LootType.Ecxp, 75000);
            }
            else if (x < 8400)
            {
                guaranteedDropCounter++;
                return (LootType.Fxp, 25000);
            }
            else if (x < 8800)
            {
                guaranteedDropCounter++;
                return (LootType.Dubs, 1000);
            }
            else if (x < 8900)
            {
                guaranteedDropCounter++;
                return (LootType.RP, 1500);
            }
            else if (x < 9000)
            {
                guaranteedDropCounter++;
                return (LootType.Steel, 1500);
            }
            guaranteedDropCounter++;
            return (LootType.Coal, 7500);
        }
    }
}
