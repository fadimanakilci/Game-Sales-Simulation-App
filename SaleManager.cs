using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class SaleManager
    {
        public void Sales(Gamer gamer, List<Game> games, List<ICampaignService> campaignManager, List<Campaign> campaigns)
        {
            Console.WriteLine("\n______________________________________________\n\t\t~~~~ GAME PRICE LIST ~~~~\n");
            foreach (var campaignM in campaignManager)
            {
                foreach (var campaign in campaigns)
                {
                    foreach (var game in games)
                    {
                        double discountAmount = campaignM.CalculateDiscount(campaign, game);
                        double price = game.GamePrice - discountAmount;
                        Console.WriteLine(campaign.Name + "\t->\t" + game.GameName + "\t->\t" + price);
                    }
                }
                
                Console.WriteLine("\n");
                break;
            }
        }
    }
}
