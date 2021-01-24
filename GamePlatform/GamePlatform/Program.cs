using System;

namespace GamePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            Member m1 = new Member()
            {
                Id = 1,
                Ad = "Aykut",
                Soyad = "Şahin",
                DogumTarihi = "23.07.1998",
                MusteriNo = "22892",
                TcNo = "528023614577"
            };

            Sales sales = new Sales();
            sales.SalesId = 1;
            sales.Sellby = DateTime.Now;
            sales.SalePrice = 350;

            CampaignServices halfDicountCampaign = new HalfDiscountCampaign(); // Kampanya Bilgisini Seçtik

            MemberManager memberManager = new MemberManager();
            memberManager.Add(m1); // Müşteri Ekle

            CampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(halfDicountCampaign);

            halfDicountCampaign.MakeCampaign(); // Kampanya Oluştur

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(m1, sales, halfDicountCampaign);

            Record record = new Record();
            record.RecordId = 1;
            record.RecordDate = DateTime.Now;
            record.VerificationStatus = true;
            Console.Write("Kayıt Bilgisi: ");
            RecordManager recordManager = new RecordManager();
            Verification verificationService = new E_DevletVerification();
            recordManager.Register(record, verificationService);
        }
    }
}
