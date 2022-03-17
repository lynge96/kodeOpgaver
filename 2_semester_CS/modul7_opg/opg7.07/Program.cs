using System;
using System.Collections;
using System.Collections.Generic;


namespace _7._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Hvem skal spille spillet - Indtast navn:");
            Console.ResetColor();

            string navn = Console.ReadLine();

            Deck_of_Cards deck = new Deck_of_Cards();
            Person Dealer = new Person("Dealer", 0, new Stack<Card>());
            Person Spiller = new Person(navn, 0, new Stack<Card>());

            Blackjack(Spiller, Dealer, deck);
        }

        public static void Blackjack(Person player, Person dealer, Deck_of_Cards spilDeck)
        {
            for (int i = 0; i < 2; i++)
            {
                player.Kort.Push(spilDeck.getCard());
            }
            dealer.Kort.Push(spilDeck.getCard());

            viskort(player.Kort, player.Navn, spilDeck, dealer);

            standhit(player, dealer, spilDeck);
        }

        public static void viskort(Stack<Card> deck, string navn, Deck_of_Cards spilDeck, Person dealer)
        {
            Console.Write($"\n{navn}s kort: ");
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.Write($"(Sum: {sumafkort(deck)})\n");
            Console.ResetColor();

            foreach (Card obj in deck)
            {
                Console.Write($"{obj}   ");
            }
            Console.WriteLine("\n\nDealerens kort:");
            Console.Write($"{dealer.Kort.Peek()}\n\n");
        }

        public static int sumafkort(Stack<Card> deck)
        {
            int sum = 0;

            Card[] array = deck.ToArray();

            for (int i = deck.Count-1; i >= 0; i--)
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
            
            deck = stack;

            return sum;
        }


        public static void standhit(Person player, Person dealer, Deck_of_Cards spilDeck)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Stand eller Hit?");
            Console.ResetColor();

            string svar = Console.ReadLine();

            if (svar.ToLower() == "hit")
            {
                Console.WriteLine();

                player.Kort.Push(spilDeck.getCard());

                viskort(player.Kort, player.Navn, spilDeck, dealer);

                if (sumafkort(player.Kort) > 21)
                {
                    dealer.Antalpoint++;

                    Console.WriteLine($"Du fik {sumafkort(player.Kort)} og har derfor tabt! Dealeren vinder og stillingen er nu:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{player.Navn}: {player.Antalpoint} og Dealer: {dealer.Antalpoint}");
                    Console.ResetColor();

                    emptyStack(player.Kort, spilDeck);
                    emptyStack(dealer.Kort, spilDeck);

                    Console.WriteLine("\nDu trækker to nye kort!\n");

                    Blackjack(player, dealer, spilDeck);

                }
                else {
                    standhit(player, dealer, spilDeck);
                }


            }
            else if (svar.ToLower() == "stand")
            {
                Console.WriteLine();
                for (int i = sumafkort(dealer.Kort); i < 17; i = sumafkort(dealer.Kort))
                    {
                        Console.WriteLine($"Dealerens kort:" +
                            $"\n{dealer.Kort.Peek()}\n");

                        Console.WriteLine($"Dealer har lige nu en sum af: {sumafkort(dealer.Kort)} og trækker derfor et kort til!\n");
                        dealer.Kort.Push(spilDeck.getCard());
                    }
                  
                // Ændre dealer point her
                Console.WriteLine($"Dealer vælger stand på en sum af: {sumafkort(dealer.Kort)}\n");

                if (sumafkort(player.Kort) > sumafkort(dealer.Kort))
                {
                    Console.WriteLine($"{player.Navn} vinder med en hånd på {sumafkort(player.Kort)} over dealerens {sumafkort(dealer.Kort)}!" +
                        $"\n\nStillingen er nu:");
                    player.Antalpoint++;
                    emptyStack(player.Kort, spilDeck);
                    emptyStack(dealer.Kort, spilDeck);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{player.Navn}: {player.Antalpoint} og Dealer: {dealer.Antalpoint}\n");
                    Console.ResetColor();

                    spilVidere(player, dealer, spilDeck);

                } else if (sumafkort(dealer.Kort) > sumafkort(player.Kort))
                {
                    Console.WriteLine($"Dealeren vinder med en hånd på {sumafkort(dealer.Kort)} over {player.Navn}s {sumafkort(player.Kort)}!" +
                        $"\n\nStillingen er nu:");
                    dealer.Antalpoint++;
                    emptyStack(player.Kort, spilDeck);
                    emptyStack(dealer.Kort, spilDeck);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{player.Navn}: {player.Antalpoint} og Dealer: {dealer.Antalpoint}\n");
                    Console.ResetColor();

                    spilVidere(player, dealer, spilDeck);

                } else
                {
                    Console.WriteLine("UAFGJORT! Spillet fortsætter");

                    emptyStack(player.Kort, spilDeck);
                    emptyStack(dealer.Kort, spilDeck);

                    spilVidere(player, dealer, spilDeck);

                }

            }
            else
            {
                Console.WriteLine("Du skal skrive enten Stand eller Hit for at spille videre, prøv igen:");

                standhit(player, dealer, spilDeck);
            }
        }

        public static Stack<Card> emptyStack(Stack<Card> deck, Deck_of_Cards spilDeck)
        {
            int antal = deck.Count;
            for (int i = 0; i < antal; i++)
            {
                spilDeck.addCard(deck.Pop());
            }

            return deck;
        }

        public static void spilVidere(Person player, Person dealer, Deck_of_Cards spilDeck)
        {
            if (player.Antalpoint == 10)
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
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\nNyt Spil!");
                    Console.ResetColor();
                    emptyStack(player.Kort, spilDeck);
                    emptyStack(dealer.Kort, spilDeck);

                    Blackjack(player, dealer, spilDeck);
                }
            }
        }
    }
}