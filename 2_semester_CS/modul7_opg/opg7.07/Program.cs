using System;
using System.Collections;
using System.Collections.Generic;


namespace _7._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvem skal spille spillet - Indtast navn:");
            string navn = Console.ReadLine();

            Console.WriteLine();

            Deck_of_Cards dæk = new Deck_of_Cards();
            Person Dealer = new Person("Dealer", 0, new Stack<Card>());
            Person Spiller = new Person(navn, 0, new Stack<Card>());

            Blackjack(Spiller, Dealer, dæk);

        }
        public static void Blackjack(Person navnpåspiller, Person dealer, Deck_of_Cards spilerdæk)
        {
           
            for (int i = 0; i < 2; i++)
            {
                dealer.Kort.Push(spilerdæk.getCard());
                navnpåspiller.Kort.Push(spilerdæk.getCard());
            }

            viskort(navnpåspiller.Kort, navnpåspiller.Navn, spilerdæk);

            standhit(navnpåspiller, dealer, spilerdæk);

            


        }
        public static void viskort(Stack<Card> dæk, string navn, Deck_of_Cards spilerdæk)
        {
            Console.WriteLine($"{navn}s kort lige nu: (sum: {sumafkort(dæk)} )");

            foreach (Card obj in dæk)
                Console.Write($"{obj}   ");

            Console.WriteLine();
            Console.WriteLine();

        }

        public static int sumafkort(Stack<Card> dæk)
        {
            int sum = 0;

            Card[] array = dæk.ToArray();

            for (int i = dæk.Count-1; i >= 0; i--)
            {

                if (array[i].Rank > 10)
                {
                    if (array[i].Rank == 14 && sum <= 10)
                    {
                        sum += 11;
                    } else if (array[i].Rank == 14 && sum > 10)
                    {
                        sum += 1;
                    } else
                    {
                        sum += 10; 
                    }
                } else
                {
                    sum += array[i].Rank;

                }

            }

            Stack<Card> stack = new Stack<Card>(array);
            
            dæk = stack;

            return sum;
        }


        public static void standhit(Person navnpåspiller, Person dealer, Deck_of_Cards spilerdæk)
        {
            Console.WriteLine("Stand eller Hit?");

            string svar = Console.ReadLine();

            if (svar.ToLower() == "hit")
            {
                Console.WriteLine();

                navnpåspiller.Kort.Push(spilerdæk.getCard());

                viskort(navnpåspiller.Kort, navnpåspiller.Navn, spilerdæk);

                if (sumafkort(navnpåspiller.Kort) > 21)
                {
                    dealer.Antalpoint++;

                    Console.WriteLine($"Du fik {sumafkort(navnpåspiller.Kort)} og har derfor tabt! Dealeren vinder og stillingen er nu:");
                    Console.WriteLine();
                    Console.WriteLine($"{navnpåspiller.Navn}: {navnpåspiller.Antalpoint} og Dealer: {dealer.Antalpoint}");

                    emptyStack(navnpåspiller.Kort, spilerdæk);
                    emptyStack(dealer.Kort, spilerdæk);


                    Console.WriteLine();
                    Console.WriteLine("Du trækker to nye kort!");

                    Blackjack(navnpåspiller, dealer, spilerdæk);

                }
                else {
                    standhit(navnpåspiller, dealer, spilerdæk);
                }


            }
            else if (svar.ToLower() == "stand")
            {
                Console.WriteLine();

                for (int i = sumafkort(dealer.Kort); i < 17; i=sumafkort(dealer.Kort))
                    {
                        Console.WriteLine($"Dealer har lige nu en sum af: {sumafkort(dealer.Kort)} og trækker derfor et kort til!");
                        dealer.Kort.Push(spilerdæk.getCard());
                    }
                  
                Console.WriteLine();

                // Ændre dealer point her
                Console.WriteLine($"Dealer vælger stand på en sum af: {sumafkort(dealer.Kort)}");

                Console.WriteLine();


                if (sumafkort(navnpåspiller.Kort) > sumafkort(dealer.Kort))
                {
                    Console.WriteLine($"{navnpåspiller.Navn} vinder med en hånd på {sumafkort(navnpåspiller.Kort)} over dealerens {sumafkort(dealer.Kort)}!");
                    Console.WriteLine($"Stillingen er nu:");
                    navnpåspiller.Antalpoint++;
                    emptyStack(navnpåspiller.Kort, spilerdæk);
                    emptyStack(dealer.Kort, spilerdæk);
                    Console.WriteLine();
                    Console.WriteLine($"{navnpåspiller.Navn}: {navnpåspiller.Antalpoint} og Dealer: {dealer.Antalpoint}");

                    spilVidere(navnpåspiller, dealer, spilerdæk);

                } else if (sumafkort(dealer.Kort) > sumafkort(navnpåspiller.Kort))
                {
                    Console.WriteLine($"Dealeren vinder med en hånd på {sumafkort(dealer.Kort)} over {navnpåspiller.Navn}s {sumafkort(navnpåspiller.Kort)}!");
                    Console.WriteLine($"Stillingen er nu:");
                    dealer.Antalpoint++;
                    emptyStack(navnpåspiller.Kort, spilerdæk);
                    emptyStack(dealer.Kort, spilerdæk);
                    Console.WriteLine();
                    Console.WriteLine($"{navnpåspiller.Navn}: {navnpåspiller.Antalpoint} og Dealer: {dealer.Antalpoint}");

                    spilVidere(navnpåspiller, dealer, spilerdæk);

                } else
                {
                    Console.WriteLine("UAFGJORT! Spillet fortsætter");

                    emptyStack(navnpåspiller.Kort, spilerdæk);
                    emptyStack(dealer.Kort, spilerdæk);

                    spilVidere(navnpåspiller, dealer, spilerdæk);

                }

            }
            else
            {
                Console.WriteLine("Du skal skrive enten Stand eller Hit for at spille videre, prøv igen:");

                standhit(navnpåspiller, dealer, spilerdæk);
            }
        }

        public static Stack<Card> emptyStack(Stack<Card> dæk, Deck_of_Cards spildæk)
        {
            int antal = dæk.Count;
            for (int i = 0; i < antal; i++)
            {
                spildæk.addCard(dæk.Pop());
            }

            return dæk;
        }

        public static void spilVidere(Person spiller, Person dealer, Deck_of_Cards spilerdæk)
        {
            if (spiller.Antalpoint == 10)
            {
                Console.WriteLine("Du har vundet med 10 point!");
            }
            else if (dealer.Antalpoint == 10)
            {
                Console.WriteLine("Dealeren har vundet med 10 point, og du har tabt...");

            } else
            {
                Console.WriteLine("Vil du spille videre? (Ja / Nej)");
                string svar = Console.ReadLine();

                if (svar.ToLower() == "ja")
                {
                    emptyStack(spiller.Kort, spilerdæk);
                    emptyStack(dealer.Kort, spilerdæk);

                    Blackjack(spiller, dealer, spilerdæk);
                }
            }
        }



    }
}

