using System;
using System.Collections.Generic;
using System.Text;
using Weekopdracht1.Business;
using Weekopdracht1.Data;
using Weekopdracht1.Data.Entities;

namespace Weekopdracht_Fase1_Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new();
            do
            {
                Console.Clear();
                program.MainMenu();
                Console.WriteLine("Druk op een toets om nog een telefoon te bekijken of druk op 'q' om af te sluiten");
            }
            while (Console.ReadKey(true).KeyChar != 'q');
        }

        public void MainMenu()
        {
            List<Phone> Phones = InitializeService.GetPhones();

            Console.WriteLine("Welkom, welke telefoon zou je informatie over willen? \n\n");

            foreach (Phone phone in Phones)
            {
                Console.WriteLine($"kies {phone.Id} voor de {phone.Merk}-{phone.PhoneType}");
            }

            if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out int keuze) && keuze > 0 && keuze <= Phones.Count)
            {
                Phone phone = Phones.Find(p => p.Id == keuze);
                Console.Clear();
                Console.WriteLine($"Merk: {phone.Merk}\tType: {phone.PhoneType}\tPrijs: {phone.Prijs}.-\nOmschrijving:\n{TextHelper.Sentence(phone.Omschrijving, 30)}");
                Console.ReadKey(true);
            }
        }

        
    }
}
