
using InterfaceDemo;
using System.Collections.Generic;

interface ICampaignService
{
    void Add(List<Campaign> campaigns);
    void List(List<Campaign> campaigns);
    void Update(List<Campaign> campaigns, int id);
    void Remove(List<Campaign> campaigns, int id);
    double CalculateDiscount(Campaign campaign, Game game);
}
