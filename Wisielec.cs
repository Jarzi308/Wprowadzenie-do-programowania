using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szubienica
{
    static class Wisielec
    {
        public static void gra()
        {
            while (true)
            {
                string[] powieszony =
                {
                    "  _________",
                    "  |   |   |",
                    "  |   O   |",
                    "  |  /|\\  |",
                    "  |   |   |",
                    "  |  / \\  |",
                    " /|\\     /|\\",
                    "/ | \\   / | \\"
                }; //Stworzenie tablicy błędów gracza powieszony[]
                string[] words =
                {
                    "telefon",
                    "komputer",
                    "rewolwer",
                    "autostrada",
                    "programowanie",
                    "huragan",
                    "kompresja",
                    "kasztan",
                    "helikopter",
                    "kamper",
                    "butelka",
                    "kaskader",
                    "laptop",
                    "komputer",
                    "myszka",
                    "telefon",
                    "pilot",
                    "koniunkcja",
                    "operator",
                    "stolik",
                    "wyrewolwerowany",
                    "pastuch",
                    "owca",
                    "paluszki",
                    "krakersy",
                    "serwis",
                    "mieszkanie",
                    "balon",
                    "obiad",
                    "karygodny",
                    "krokodyl",
                    "autostrada",
                    "policja",
                    "konfident",
                    "bachor",
                    "kataklizm",
                    "wariatka",
                    "kontakt"
                }; //stworzenie tablicy słów words[]
                Random rand = new Random(); // zadeklarowanie zmiennej losującej
                string word; // zadeklarowanie zmiennej word
                int wordsLen = words.Length; // zmienna okreslajaca ilosc elementów tablicy słów words[]
                int random = rand.Next(wordsLen); // zmienna okreaslajaca losowa liczbe z zakresu ilosci elementów tablicy słów words[]
                word = words[random];  // losowanie słowa dla zmiennej word z tablicy słów words[]
                int wordLen = word.Length; // zmienna okreslajaca ilosc znaków zmiennej word
                char[] userWord = new char[wordLen]; //tablica wyswietlajaca aktualny stan gry
                for (int i = 0; i < wordLen; i++) //wypelnienie stanu gry samymi kreskami
                {
                    userWord[i] = '-';
                }
                int errCount = powieszony.Length; // zmienna okreslajaca maksymalna ilosc błędów gracza tj. liczbę elementów tablicy powieszony[]
                int err = 0; // zmienna określająca bieżącą ilość popełnionych błędów
                char[] errChars = new char[errCount]; // tablica przechowująca podane błędne litery
                bool game = true; // zmienna okreslajaca czy gracz ukończył grę
                for (int i = 0; i < errCount; i++) // Pętla rysująca wisielca z tablicy powieszony[]
                {
                    Console.WriteLine(powieszony[i]);
                }
                Console.WriteLine("\nNie daj się powiesić!\n");
                while (game) // pętla wykonująca się dopóki gracz nie ukończy gry
                {
                    for (int i = 0; i < err; i++) // pętla rysująca wisielca w zależności od ilości popełnionych błędów
                    {
                        Console.WriteLine(powieszony[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine(userWord); // komenda wyswietlająca aktualny stan gry
                    Console.WriteLine();
                    Console.Write("Podane błędne litery: ");
                    Console.Write(errChars); // komenda wyświetlająca podane błędne litery
                    Console.WriteLine("Pozostało prób: {0}", errCount - err); // komenda wyswietlajaca pozostałą ilość prób
                    Console.WriteLine("\nPodaj literę: ");
                    string s = Console.ReadLine(); // komenda umozliwiajaca wprowadzenie znaków
                    char c;
                    if (s.Length > 0) // warunek ktory sprawdza czy wprowadziliśmy jakąkolwiek wartość
                        c = s.ElementAt(0); // zmienna przypisująca pierwszą literę wprowadzonego ciągu znaków
                    else // jeżeli gracz nie wprowadził żadnej wartości, pętla while(game) rozpocznie się od początku
                        continue;
                    bool charFound = false; // zmienna przechowująca informacje o tym czy wprowadzona litera znajduje się w wylosowanym słowie
                    bool win = false; // zmienna przechowująca dane o tym czy gracz wygrał
                    for (int i = 0; i < wordLen; i++) // pętla śledząca słowo w poszukiwaniu podanej litery
                    {
                        if (c == word.ElementAt(i)) // jeżeli wprowadzona litera znajduje się w słowie...
                        {
                            userWord[i] = c; // ...zastąp kreskę wprowadzoną literą
                            charFound = true; // Litera znajduje się w wylosowanym słowie, więc ustaw charFound na true
                        }
                    }
                    bool errCharFound = false; // zmienna przechowująća dane na temat błędnej litery
                    if (!charFound) // jeżeli nie znaleziono litery w wylosowanym słowie...
                    {
                        err += 1; // ...zwiększ ilość bieżących błędów o 1
                        for (int i = 0; i < errChars.Length; i++) //Pętla sprawdzająca czy podana litera znajduje się aktualnie w tablicy błędnych liter errChars[]
                        {
                            if (errChars[i] == c)
                            {
                                errCharFound = true; // jeżeli tak, wyjdź z pętli
                                break;
                            }
                        }
                        if (!errCharFound) // jeżeli nie...
                        {
                            for (int i = 0; i < errChars.Length; i++)
                            {
                                if (errChars[i] == 0) // ...sprawdź czy komórka o indeksie i jest pusta i...
                                {
                                    errChars[i] = c; // ... jeżeli tak jest dodaj do niej błędną literę
                                    break;
                                }

                            }
                        }
                    }
                    for (int i = 0; i < wordLen; i++) // pętla sprawdzająca czy gracz odgadł słowo
                    {
                        if (userWord[i] == '-')
                        {
                            win = false;
                            break;
                        }
                        win = true;
                    }
                    if (err == errCount) // jeżeli gracz popełnił maksymalną liczbę błędów przegrywa
                    {
                        Console.WriteLine("Zostałeś pokonany przez słowo: {0}!\n", word);
                        Console.WriteLine("\nZgadłeś słowo {0}!", word);
                        Console.WriteLine("Naciśnij 1 aby zagrać jeszcze raz");
                        Console.WriteLine("Naciśni 2 albo ESC aby wyjść");
                        Console.WriteLine("Naciśni 3 aby wrócić do menu");
                        game = false;
                        ConsoleKeyInfo klawiatura = Console.ReadKey();
                        switch (klawiatura.Key)

                        {


                            case ConsoleKey.D1:
                                Console.Clear(); Wisielec.gra(); break;
                            case ConsoleKey.D3:
                                Console.Clear(); Menu.startMenu(); break;
                            case ConsoleKey.Escape:
                            case ConsoleKey.D2:
                                Environment.Exit(0); break;
                            default: break;



                        }
                    }
                    if (win) // jeżeli gracz odgadł słowo wygrywa
                    {
                        Console.WriteLine("\nZgadłeś słowo {0}!", word);
                        Console.WriteLine("Naciśnij 1 aby zagrać jeszcze raz");
                        Console.WriteLine("Naciśni 2 albo ESC aby wyjść");
                        Console.WriteLine("Naciśni 3 aby wrócić do menu");
                        
                        game = false;
                        ConsoleKeyInfo klawiatura = Console.ReadKey();
                        switch (klawiatura.Key) 
                        {


                            case ConsoleKey.D1:
                                Console.Clear(); Wisielec.gra(); break;
                            case ConsoleKey.D3:
                                Console.Clear(); Menu.startMenu(); break;
                            case ConsoleKey.Escape:
                            case ConsoleKey.D2:
                                Environment.Exit(0); break;
                            default: break;



                        }
                        

                    }
                }
            }
        }
    }
}