using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class Director
    {
        public Hero BuildHero(IHeroBuilder builder)
        {
            return builder.SetName("Batman")
                          .SetHeight(1.85)
                          .SetBuild("Athletic")
                          .SetHairColor("Brunette")
                          .SetEyeColor("Brown")
                          .SetOutfit("Black Armor")
                          .AddInventoryItem("Sword")
                          .AddInventoryItem("Shield")
                          .AddGoodDeed("Saved Gotham City")
                          .AddGoodDeed("Defeated the Joker")
                          .Build();
        }

        public Enemy BuildEnemy(IEnemyBuilder builder)
        {
            return builder.SetName("Joker")
                          .SetHeight(1.75)
                          .SetBuild("Tall")
                          .SetHairColor("Purple")
                          .SetEyeColor("Green")
                          .SetOutfit("Clown Outfit")
                          .AddInventoryItem("Acid")
                          .AddInventoryItem("Knife")
                          .AddEvilAct("Killed civillians")
                          .AddEvilAct("Made the fire")
                          .Build();
        }
    }
}
