using SCRework;
using SCRework.LootBoxes;

Config config = new Config().Instance;

// setup loot collection
var rewards = new Dictionary<string, long>();
var oldRewards = new Dictionary<string, long>();
foreach (var lootType in typeof(LootType)
    .GetFields()
    .Where(f => f.FieldType == typeof(string))
    .ToList())
{
    var type = lootType?.GetValue(null)?.ToString();
    if (!string.IsNullOrEmpty(type))
    {
        rewards.TryAdd(type, 0);
        oldRewards.TryAdd(type, 0);
    }
}

// collect loot
int trials = 0;
while (trials++ < config.Trials)
{
    int crates = (int)(config.Years * 365 * config.DailyCrates);
    while (crates-- > 0)
    {
        bool isSC = config.Tyl ? SuperContainer.OpenTyl() : SuperContainer.OpenMoreCoal();
        if (isSC)
        {
            var drop = SuperContainer.Open();
            rewards[drop.lootType] = rewards[drop.lootType] + drop.quantity;
        }
        else
        {
            if (config.Tyl)
            {
                var drop = TryYourLuck.Open();
                rewards[drop.lootType] = rewards[drop.lootType] + drop.quantity;
            }
            else
            {
                var drops = MoreCoal.Open();
                foreach (var drop in drops)
                    rewards[drop.lootType] = rewards[drop.lootType] + drop.quantity;
            }
        }

        isSC = config.Tyl ? OldSuperContainer.OpenTyl() : OldSuperContainer.OpenMoreCoal();
        if (isSC)
        {
            var drop = OldSuperContainer.Open();
            oldRewards[drop.lootType] = oldRewards[drop.lootType] + drop.quantity;
        }
        else
        {
            if (config.Tyl)
            {
                var drop = TryYourLuck.Open();
                oldRewards[drop.lootType] = oldRewards[drop.lootType] + drop.quantity;
            }
            else
            {
                var drops = MoreCoal.Open();
                foreach (var drop in drops)
                    oldRewards[drop.lootType] = oldRewards[drop.lootType] + drop.quantity;
            }
        }
    }

    // bonus
    for (int i = 0; i < config.AnniversaryContainers + config.MonthlyContainers + config.BirthdayContainers; i++)
    {
        var drop = OldSuperContainer.Open();
        oldRewards[drop.lootType] = oldRewards[drop.lootType] + drop.quantity;
    }

    for (int i = 0; i < config.AnniversaryContainers + config.MonthlyContainers * 2 + config.BirthdayContainers; i++)
    {
        var drop = SuperContainer.Open();
        rewards[drop.lootType] = rewards[drop.lootType] + drop.quantity;
    }
}

// average results and display
Console.WriteLine(config.Format, "Item", "Change", "Old System", "New System");
foreach (var key in rewards.Keys)
{
    rewards[key] = rewards[key] / config.Trials;
    oldRewards[key] = oldRewards[key] / config.Trials;

    Console.WriteLine(config.Format,
        $"{key}:",
        $"{(rewards[key] - oldRewards[key]):+###,###;-###,###;0}",
        $"{oldRewards[key]:n0}",
        $"{rewards[key]:n0}");
}
