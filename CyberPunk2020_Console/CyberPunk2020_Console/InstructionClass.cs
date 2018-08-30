using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPunk2020_Console
{
    class InstructionClass
    {
        public static void FightingInCyberpunk()
        {
            string answer;
            Console.WriteLine("OTO SPIS KROKÓW JAKIE NALEŻY PRZEPROWADZI W CZASIE WALKI");
            Console.WriteLine("1. Rzut na percepcje 1K10 + REFLEKS + ZMYSŁ WALKI");
            Console.WriteLine("2. Czy ktoś decyduję się na wyciągnięcie broni jeszcze przed rozpoczęciem jego akcji T/N?");
            answer = Console.ReadLine();
            if (answer == "T" || answer == "t")
            {
                Console.WriteLine("Ta postać dodaje sobie +3 do inicjatywy i -3 do trafienia");
            }

            Console.WriteLine("3. Postać której jest właśnie czas akcji może wykonać następujące czynności:");
            Console.WriteLine("\t-Przemieszczanie się na odległość określoną przez twą szybkość (szybkość x3 w metrach)");
            Console.WriteLine("\t-Atak bronią białą, atak wręcz lub użycie broni palnej (aż do maksymalnej szybkostrzelności)");
            Console.WriteLine("\t-Unik(Sprawia, że trudniej Cię trafić; tylko przy walce wręcz i bronią białą)");
            Console.WriteLine("\t-Zasłona (Skierowanie ataku w inną stronę)");
            Console.WriteLine("\t-Uniknięcie chwytu lub pułapki");
            Console.WriteLine("\t-Celowanie (+1 do trafienia za każdą kolejną rundę celowania - do maksymalnie 3 rund)");
            Console.WriteLine("\t-Przeładowanie lub zmiania broni");
            Console.WriteLine("\t-Wsiadanie lub wysiadanie z pojazdu");
            Console.WriteLine("\t-Naprawa lub udzielienie pierwszej pomocy");
            Console.WriteLine("\t-Wykonanie czynności nie związanej z walką");


            Console.WriteLine("4. Czy postać chce wykonać więcej niż jedną akcję T/N?");
            answer = Console.ReadLine();
            if (answer == "T" || answer == "t")
            {
                Console.WriteLine("Ta postać do każdej dodatkowej akcji dodaje modyfikator -3 np. druga akcja -3, trzecia -6, czwarta -9 itd.");
            }

            Console.WriteLine("5. Czy postać chce użyć dwóch broni jednocześnie T/N?");
            answer = Console.ReadLine();
            if (answer == "T" || answer == "t")
            {
                Console.WriteLine("Ta postać do trafienia z obydwu broni otrzymuję modyfikator -3");
            }

            Console.Write("6.Rzuć 1K10 aby ustalić miejsce trafienia. Czy postać chce strzelić w konkretne miejsce na ciele przeciwnika T/N?");
            answer = Console.ReadLine();
            if (answer == "T" || answer == "t")
            {
                Console.WriteLine("Jeśli postać chce strzelić w konkretne miejsce w ciele przeciwnika dostaje modyfikator -4 do trafienia");
            }

            Console.Write("7.Czy postać atakuję bronią dystansową T/N?");
            answer = Console.ReadLine();
            if (answer == "T" || answer == "t")
            {
                Console.WriteLine("Należy rzucić 1K10 + REFLEKS + umiejętność posługiwania się bronią + modyfikatory");
                Console.WriteLine("Maksymalne zasięgi broni:");
                Console.WriteLine("\t-Pistolet\t\t50m");
                Console.WriteLine("\t-Pistolet Maszynowy\t150m");
                Console.WriteLine("\t-Śrutówki\t\t50m");
                Console.WriteLine("\t-Karabiny\t\t400m");
                Console.WriteLine("\t-Rzut czymś w kogoś\t10 x Budowa ciała postaci wynik jest podawany w metrach");
                Console.WriteLine("Odległości od przeciwnika dzielimy na:");
                Console.WriteLine("\t-Bezpośredna:\t\tBroń znajduję się bardzo blisko od celu lub jest z nim w fizycznym kontakcie.");
                Console.WriteLine("\t-Bliska:\t\tBroń atakuję z 1/4 podanego zasięgu");
                Console.WriteLine("\t-Średnia:\t\tBroń atakuję z 1/2 podanego zasięgu");
                Console.WriteLine("\t-Daleki:\t\tBroń atakuję z zasięgu podanego w jej opisie");
                Console.WriteLine("\t-Ekstremalna:\t\tBroń atakuję z odległości dwa razy większej niż podany zasięg");
                Console.WriteLine("Zależnie od odległości z jakiej postać strzela wynik musi być większy niż:");
                Console.WriteLine("\t-Bezpośredna:\t\t10");
                Console.WriteLine("\t-Bliska:\t\t14");
                Console.WriteLine("\t-Średnia:\t\t20");
                Console.WriteLine("\t-Daleki:\t\t25");
                Console.WriteLine("\t-Ekstremalna:\t\t30");
                Console.WriteLine("Jeśli wynik rzutu jest większy niż trudność testu postać trafia przeciwnika");
            }
            Console.Write("8.Czy postać atakuję bronią białą T/N?");

            Console.Write("X.Czy pworócić do menu? Odpowiedź przecząca rozpocznie sekwencje od początku T/N?");
            //if (answer == "T" || answer == "t")
            // {

            // }
            Console.ReadLine();           
        }
    }
}

