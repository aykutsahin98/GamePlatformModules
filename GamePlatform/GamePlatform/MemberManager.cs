using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform
{
    class MemberManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Güncellendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi.");
        }
    }
}