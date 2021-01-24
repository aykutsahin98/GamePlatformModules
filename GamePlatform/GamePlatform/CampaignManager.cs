using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform
{
    class CampaignManager
    {
        public void Add(CampaignServices campaign)
        { 
            Console.WriteLine("Kampanya Eklendi.");
        }

        public void Update (CampaignServices campaign)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }

        public void Delete(CampaignServices campaign)
        {
            Console.WriteLine("Kampanya Silindi.");
        }
    }
}
