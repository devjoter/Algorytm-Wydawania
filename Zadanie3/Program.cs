//Napisać program pozwalający na implementację algorytmu wydawania.
//Program ma umożliwić wprowadzenie kwoty jaka należy wydać, oraz pokazać na ekranie nominały banknotów do wydania.
//Należy przyjąć że wydajemy następujące banknoty 200, 100, 50, 20, 10.
//Na początku należy sprawdzić czy kwota wprowadzona przez użytkownika może być wydana za pomocą nominałów jakie mamy do dyspozycji.

using System;


namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int i;//definicja zmiennej pomocniczej, ktora bedziemy uzywac do inkrementacji w petli
            double[] nominaly = { 200, 100, 50, 20, 10 };//definicja i inicjalizacja tablicy z wartosciami nominalow

            Console.Write("Podaj kwotę do wypłaty: ");//wyswietlenie informacji
                      
            if (!double.TryParse(Console.ReadLine(), out double reszta))//Jeśli odczytana kwota nie jest liczbą wyswietli info, jesli jest tworze zmienna reszta i przesylam parametrem out
            {
                Console.WriteLine("Podano nieprawidłową kwotę! Nacisnji dowolny klawisz");
                Console.ReadKey(true);

            }
            
            i = 0;//inicjalizacja zmiennej i
                
            while ((reszta > 0) && (reszta % 10 == 0))//sprawdzenie czy kwota wprowadzona przez uzytkownika moze byc wydana za pomoca wartosci nominalow w tablicy
            {
                if (reszta >= nominaly[i])//iteracja po tablicy nominaly i wyszukanie najwiekszego nominalu nie wiekszego od zadanej kwoty 
                {
                    int liczbaNominalow = (int)(reszta / nominaly[i]);//zapisanie liczby najwiekszych mozliwych nominalow w zmiennej 
                    reszta -= nominaly[i] * liczbaNominalow; //Odjęcie wypłaconych środków od kwoty i nadpisanie zmiennej reszta aby moc kontynuowac algorytm az do wyrazenia bez reszty

                    Console.WriteLine("Wypłacono: " + liczbaNominalow + " x " + nominaly[i] + " PLN");//wyswietlenie informacji 
    
                }

                i++;
            }
            if (reszta % 10 != 0)//jesli podna kwota nie moze byc wydana istniejacymi nominalami
            {
                Console.WriteLine("Nie mozna wydac reszty dysponujac zadanymi nominalami. Nacisnji dowolny klawisz");
            }

            Console.ReadKey(true);
        }
    }
}



