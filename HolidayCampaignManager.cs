using InterfaceDemo;
using System;
using System.Collections.Generic;

class HolidayCampaignManager : ICampaignService
{
    int sayac = 1;
    public void Add(List<Campaign> campaigns)
    {
        // Yeni holiday campaign tanımlandı
        Campaign campaign = new Campaign();
        // Yeni holiday campaign bilgileri alındı
        Console.WriteLine(sayac + ". Holiday Campaign ID:");
        campaign.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(sayac + ". Holiday Campaign Name:");
        campaign.Name = Console.ReadLine();
        Console.WriteLine(sayac + ". Holiday Campaign Details:");
        campaign.CampaignDetails = Console.ReadLine();
        Console.WriteLine(sayac + ". Holiday Campaign Discount Rate:");
        campaign.DiscountRate = double.Parse(Console.ReadLine());
        // Campaigns listesine yeni campaing i ekledik
        campaigns.Add(campaign);
        Console.WriteLine("\n");
        sayac++;
    }
    public double CalculateDiscount(Campaign campaign, Game game)
    {
        double discountAmount = (game.GamePrice * campaign.DiscountRate) / 100;
        return discountAmount;
    }

    public void List(List<Campaign> campaigns)
    {
        Console.WriteLine("\n______________________________________________\n\t\t~~~~ HOLIDAY CAMPAIGNS LIST ~~~~\n");
        int i = 1;
        foreach (var campaign in campaigns)
        {
            Console.WriteLine(i + ". Holiday Campaigns ID:\t" + campaign.Id);
            Console.WriteLine(i + ". Holiday Campaigns Name:\t" + campaign.Name);
            Console.WriteLine(i + ". Holiday Campaigns Details:\t" + campaign.CampaignDetails);
            Console.WriteLine(i + ". Holiday Campaigns Discount Rate:\t" + campaign.DiscountRate + "\n");
            i++;
        }
    }

    public void Remove(List<Campaign> campaigns, int id)
    {
        for (var i = 0; i < campaigns.Count; i++)
        {
            Campaign campaign = campaigns[i];
            if (campaign.Id == id)
            {
                campaigns.RemoveAt(i);
                Console.WriteLine("Campaign with id number " + id + " has been removed from the list.\n");
            }
            else
            {
                Console.WriteLine("There are no holiday campaigns with the entered id value.\n");
            }
        }
    }

    public void Update(List<Campaign> campaigns, int id)
    {
        for (var i = 0; i < campaigns.Count; i++)
        {
            Campaign campaign = campaigns[i];
            if (campaign.Id == id)
            {
                Console.WriteLine("Holiday campaigns information updated.\n");
            }
            else
            {
                Console.WriteLine("There are no holiday campaigns with the entered id value.\n");
            }


        }
    }
}
