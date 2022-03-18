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
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{obj}   ");
                Console.ResetColor();
            }
            Console.WriteLine("\n\nDealerens kort:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{dealer.Kort.Peek()}\n\n");
            Console.ResetColor();
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

                    Console.Write($"Du fik ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{sumafkort(player.Kort)}");
                    Console.ResetColor();
                    Console.Write(" og har derfor tabt! Dealeren vinder og stillingen er nu:");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{player.Navn}: {player.Antalpoint} og Dealer: {dealer.Antalpoint}");
                    Console.ResetColor();

                    emptyStack(player.Kort, spilDeck);
                    emptyStack(dealer.Kort, spilDeck);

                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nDu trækker to nye kort!\n");
                    Console.ResetColor();

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
                        Console.WriteLine($"Dealerens kort:");
                        foreach (Card card in dealer.Kort)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write($"{card}   ");
                            Console.ResetColor();
                        }

                        Console.Write($"\n\nDealer har lige nu en sum af: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"{sumafkort(dealer.Kort)}");
                        Console.ResetColor();
                        Console.Write(" og trækker derfor et kort til!\n");
                        dealer.Kort.Push(spilDeck.getCard());
                        Thread.Sleep(1000);
                    }

                if (sumafkort(dealer.Kort) > 21)
                {
                    player.Antalpoint++;

                    Console.Write($"\nDealer fik ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"{sumafkort(dealer.Kort)} ");
                    Console.ResetColor();
                    Console.Write($"og har derfor tabt! {player.Navn} vinder og stillingen er nu:\n");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{player.Navn}: {player.Antalpoint} og Dealer: {dealer.Antalpoint}");
                    Console.ResetColor();

                    emptyStack(player.Kort, spilDeck);
                    emptyStack(dealer.Kort, spilDeck);

                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("\nDu trækker to nye kort!\n");
                    Console.ResetColor();

                    Blackjack(player, dealer, spilDeck);

                }

                foreach (Card card in dealer.Kort)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write($"{card}   ");
                    Console.ResetColor();
                }
                Console.Write($"\n\nDealer vælger stand på en sum af: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{sumafkort(dealer.Kort)}\n");
                Console.ResetColor();

                if (sumafkort(player.Kort) > sumafkort(dealer.Kort))
                {
                    Console.Write($"{player.Navn} vinder med en hånd på ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"{sumafkort(player.Kort)}");
                    Console.ResetColor();
                    Console.Write(" over dealerens ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"{sumafkort(dealer.Kort)}");
                    Console.ResetColor();
                    Console.Write("\n\nStillingen er nu:\n");


                    player.Antalpoint++;
                    emptyStack(player.Kort, spilDeck);
                    emptyStack(dealer.Kort, spilDeck);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{player.Navn}: {player.Antalpoint} og Dealer: {dealer.Antalpoint}\n");
                    Console.ResetColor();

                    spilVidere(player, dealer, spilDeck);

                } else if (sumafkort(dealer.Kort) > sumafkort(player.Kort))
                {
                    Console.Write($"Dealeren vinder med en hånd på ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"{sumafkort(dealer.Kort)}");
                    Console.ResetColor();
                    Console.Write($" over {player.Navn}s ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"{sumafkort(player.Kort)}");
                    Console.ResetColor();
                    Console.Write("\n\nStillingen er nu:\n");


                    dealer.Antalpoint++;
                    emptyStack(player.Kort, spilDeck);
                    emptyStack(dealer.Kort, spilDeck);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{player.Navn}: {player.Antalpoint} og Dealer: {dealer.Antalpoint}\n");
                    Console.ResetColor();

                    spilVidere(player, dealer, spilDeck);

                } else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\nUAFGJORT! Spillet fortsætter\n");
                    Console.ResetColor();

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
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nVil du spille videre? (Ja / Nej)");
                Console.ResetColor();
                string svar = Console.ReadLine();

                if (svar.ToLower() == "ja")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\nNyt Spil!\n");
                    Console.ResetColor();
                    emptyStack(player.Kort, spilDeck);
                    emptyStack(dealer.Kort, spilDeck);

                    Blackjack(player, dealer, spilDeck);
                }
            }
        }
    }
}