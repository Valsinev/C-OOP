using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeAndTravel;

namespace TradeAndTravel
{
    public class ExtendedInteractionMenager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    return new Weapon(itemNameString, itemLocation);
                case "wood":
                    return new Wood(itemNameString, itemLocation);
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }
        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "mine":
                    return new Mine(locationName);
                case "forest":
                    return new Forest(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant":
                    return new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    this.HandleCraftingInteraction(actor, commandWords[2],commandWords[3]);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }
        private void HandleGatherInteraction(Person actor, string itemName)
        {
            if (actor.Location is IGatheringLocation)
            {
                var gatheringLocation = actor.Location as IGatheringLocation;
                if (actor.ListInventory().Any(i => i.ItemType == gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor,gatheringLocation.ProduceItem(itemName));
                }
            }
        }
        private void HandleCraftingInteraction(Person actor, string commandWords, string itemName)
        {
            switch (commandWords)
            {
                case "armor":
                    if (actor.ListInventory().Any(i => i.ItemType == ItemType.Iron))
                    {
                        this.AddToPerson(actor,new Armor(itemName));
                    }
                    break;
                case "weapon":
                    if (actor.ListInventory().Any(i => i.ItemType == ItemType.Iron) &&
                        actor.ListInventory().Any(i => i.ItemType == ItemType.Wood))
                    {
                        this.AddToPerson(actor,new Weapon(itemName));
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
