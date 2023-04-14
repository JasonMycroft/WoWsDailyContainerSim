using System.Security.Cryptography;

namespace SCRework.LootBoxes
{
    public class OldSuperContainer
    {
        private static int guaranteedDropCounter = 0;
        private const int guaranteedDrop = 165;
        private static double nextDrop = RandomNumberGenerator.GetInt32(101);

        public static bool OpenMoreCoal()
        {
            nextDrop += 1.5;
            return nextDrop >= 100;
        }

        public static bool OpenTyl()
        {
            nextDrop += 4.5;
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
            if (x < 5 || guaranteedDropCounter == guaranteedDrop && x < 333)
            {
                guaranteedDropCounter = 0;
                return (LootType.Ship10, 1);
            }
            else if (x < 25 || guaranteedDropCounter == guaranteedDrop && x < 1667)
            {
                guaranteedDropCounter = 0;
                return (LootType.Ship9, 1);
            }
            else if (x < 150 || guaranteedDropCounter == guaranteedDrop)
            {
                guaranteedDropCounter = 0;
                return (LootType.Ship7, 1);
            }
            else if (x < 200)
            {
                guaranteedDropCounter++;
                return (LootType.Dubs, 5000);
            }
            else if (x < 400)
            {
                guaranteedDropCounter++;
                return (LootType.Steel, 1500);
            }
            else if (x < 600)
            {
                guaranteedDropCounter++;
                return (LootType.PT, 30);
            }
            else if (x < 1400)
            {
                guaranteedDropCounter++;
                return (LootType.BlueBooster, 25);
            }
            else if (x < 3900)
            {
                guaranteedDropCounter++;
                return (LootType.Flags, 100);
            }
            else if (x < 4400)
            {
                guaranteedDropCounter++;
                return (LootType.Fxp, 50000);
            }
            else if (x < 7000)
            {
                guaranteedDropCounter++;
                return (LootType.GreenBooster, 50);
            }
            else if (x < 8000)
            {
                guaranteedDropCounter++;
                return (LootType.Coal, 15000);
            }
            else if (x < 9000)
            {
                guaranteedDropCounter++;
                return (LootType.Dubs, 1000);
            }
            guaranteedDropCounter++;
            return (LootType.PT, 7);
        }
    }
}
