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

            Console.WriteLine("6. Czy postać strzela z broni automatycznej(np. Karabin, Uzi, Pistolet maszynowy) T/N?");
            answer = Console.ReadLine();
            if (answer == "T" || answer == "t")
            {
                Console.WriteLine("Postać strzelająca z broni automatycznej ma możliwość wyboru strzelania za pomocą:");
                Console.WriteLine("\t- Pełna seria: Brak możliwości użycia celownika i celowania.");
                Console.WriteLine("\t\t- Podziel maksymalną szybkostrzelność broni przez ilość celów do których zamierzasz strzelać");
                Console.WriteLine("\t\t- Każde 10 pocisków przypadające na cel na bezpośredni,bliski dystans dodaje +1 do ataku");
                Console.WriteLine("\t\t- Każde 10 pocisków przypadające na cel na średni,daleki,ekstremalny dystans odejmuję -1 do ataku");
                Console.WriteLine("\t\t- Dla każdego celu oddzielnie przeprowadzić test czy został trafiony (Punkt 8)");
                Console.WriteLine("\t\t- Na każdy punkt powyżej testu ataku z broni dystansowej (Punkt 8) pocisk trafia przeciwnika i należy osobno za nie policzyć obrażenia.");
                Console.WriteLine("\t\t- np. test ma trudność 14 wynik testu ataku z broni dystansowej wyniósł 16 czyli tego przeciwnika trafiają 2 kule. Dla każdej kuli liczymy osobno obrażenia.");
                //TODO: Opisać możliwość strzelania serią 3 pociskową.
            }


            Console.Write("7.Rzuć 1K10 aby ustalić miejsce trafienia. Czy postać chce strzelić w konkretne miejsce na ciele przeciwnika T/N?");
            answer = Console.ReadLine();
            if (answer == "T" || answer == "t")
            {
                Console.WriteLine("Jeśli postać chce strzelić w konkretne miejsce w ciele przeciwnika dostaje modyfikator -4 do trafienia");
            }

            Console.Write("8.Czy postać atakuję bronią dystansową T/N?");
            answer = Console.ReadLine();
            if (answer == "T" || answer == "t")
            {
                Console.WriteLine("Należy rzucić 1K10 + REFLEKS + umiejętność posługiwania się bronią + modyfikatory");
                Console.WriteLine("Jeśli na kostce wypadnie 10 rzuć nią jeszcze raz i wynik dodaj do poprzedniego");
                Console.WriteLine("Jeśli na kostce wypadnie 1 strzał jest nie udany. Rzuć ponownie 1k10 i odczytaj rezultat");

                Console.WriteLine("Czy rzut zakończył się krytyczną porażką T/N?");
                answer = Console.ReadLine();
                if (answer == "T" || answer == "t")
                {
                    Console.WriteLine("Zależnie od wyniku rzutu 1k10 wydarza się:");
                    Console.WriteLine("\t1-4\tTym razem to nie pech po prostu zwaliłeś");
                    Console.WriteLine("\t5\tUpuściłeś broń");
                    Console.WriteLine("\t6\tBroń wypaliła i uderzyła w coś bez szwanku");
                    Console.WriteLine("\t7\tBroń zacieła się lub utknęła w ziemi. Aby ją odblokować poświęć jedną turę");
                    Console.WriteLine("\t8\tUdało Ci się zranić samego siebie. Wylosuj lokację i zadaj obrażenia jak przy odległości bezpośredniej");
                    Console.WriteLine("\t9-10\tUdało Ci się zranić członka drużyny. Wylosuj lokację trafienia i zadaj jej obrażenia.");
                }

                Console.WriteLine("Kontynuować? T/N?");
                answer = Console.ReadLine();
                if (answer == "T" || answer == "t")
                {
                    Console.WriteLine("Maksymalne zasięgi broni:");
                    Console.WriteLine("\t-Pistolet\t\t50m");
                    Console.WriteLine("\t-Pistolet Maszynowy\t150m");
                    Console.WriteLine("\t-Śrutówki\t\t50m");
                    Console.WriteLine("\t-Karabiny\t\t400m");
                    Console.WriteLine("\t-Rzut czymś w kogoś\t10 x Budowa ciała postaci wynik jest podawany w metrach");
                    Console.WriteLine("Odległości od przeciwnika dzielimy na:");
                    Console.WriteLine("\t-Bezpośrednia:\t\tBroń znajduję się bardzo blisko od celu lub jest z nim w fizycznym kontakcie.");
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
            }

            Console.Write("9.Czy postać atakuję bronią białą T/N?");
            if (answer == "T" || answer == "t")
            {
                Console.WriteLine("Należy rzucić 1K10 + REFLEKS + umiejętność posługiwania się bronią + modyfikatory");
                Console.WriteLine("Maksymalne zasięgi broni:");
                Console.WriteLine("\t-Pistolet\t\t50m");
            }


            Console.Write("X.Czy pworócić do menu? Odpowiedź przecząca rozpocznie sekwencje od początku T/N?");
            //if (answer == "T" || answer == "t")
            // {

            // }
            Console.ReadLine();           
        }
    }
}

