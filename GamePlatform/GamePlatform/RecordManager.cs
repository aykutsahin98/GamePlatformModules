using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform
{
    class RecordManager
    {
        public void Register(Record record, Verification verificationService)
        {
            Console.WriteLine("Kayıtlı");
            verificationService.CheckInformation();
        }

        public void Update(RecordManager record)
        {
            Console.WriteLine("Kayıtlar Güncellendi");
        }

        public void Delete(RecordManager record)
        {
            Console.WriteLine("Kayıtlar Silindi");
        }
    }
}
