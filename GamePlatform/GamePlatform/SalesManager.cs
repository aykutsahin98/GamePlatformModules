using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform
{
    class SalesManager
    {
        public void Sell(Customer customer, Sales sales, CampaignServices campaignServices)
        {
            Console.WriteLine("-----------------------------------");
            Console.Write("Satın Alınan Oyun ve Kampanya Bilgisi \n");
            Console.Write(customer.Ad+" "+customer.Soyad+"\n");
            Console.WriteLine(sales.SalesId);
            Console.Write("Ücret:" + sales.SalePrice + "\n");
            campaignServices.MakeCampaign();

        }

    }
}
