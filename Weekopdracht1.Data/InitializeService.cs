using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weekopdracht1.Data.Entities;

namespace Weekopdracht1.Data
{
    public class InitializeService
    {
        public static List<Phone> GetPhones()
        {
            return new List<Phone>
            {
                new Phone
                {
                    Id = 1,
                    Merk = "Huawei",
                    PhoneType = "P30",
                    Omschrijving = "6.47\" FHD+ (2340x1080) OLED, Kirin 980 Octa-Core (2x Cortex-A76 2.6GHz + 2x Cortex-A76 1.92GHz + 4x Cortex-A55 1.8GHz), 8GB RAM, 128GB ROM, 40+20+8+TOF/32MP, Dual SIM, 4200mAh, Android 9.0 + EMUI 9.1",
                    Prijs = 697
                },
                new Phone
                {
                    Id = 2,
                    Merk = "Samsung",
                    PhoneType = "Galaxy A52",
                    Omschrijving = "64 megapixel camera, 4k videokwaliteit6.5 inch AMOLED scherm128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)Water-en stofbestendig (IP67)",
                    Prijs = 399
                },
                new Phone
                {
                    Id = 3,
                    Merk = "Apple",
                    PhoneType = "IPhone 11",
                    Omschrijving = "Met de dubbele camera schiet je in elke situatie een perfecte foto of videoDe krachtige A13-chipset zorgt voor razendsnelle prestatiesMet Face ID hoef je enkel en alleen naar je toestel te kijken om te ontgrendelenHet toestel heeft een lange accuduur dankzij een energiezuinige processor",
                    Prijs = 619
                },
                new Phone
                {
                    Id = 4,
                    Merk = "Google",
                    PhoneType = "Pixel 4a",
                    Omschrijving = "12.2 megapixel camera, 4k videokwaliteit5.81 inch OLED scherm128 GB opslaggeheugen3140 mAh accucapaciteit",
                    Prijs = 411
                },
                new Phone
                {
                    Id = 5,
                    Merk = "Xiaomi",
                    PhoneType = "Redmi Note 10 Pro",
                    Omschrijving = "108 megapixel camera, 4k videokwaliteit6.67 inch AMOLED scherm128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)Water-en stofbestendig (IP53)",
                    Prijs = 298
                },
            };
        }
    }
}
