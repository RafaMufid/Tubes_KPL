using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes_KPL_Libraries.Attribute;



namespace Tubes_KPL_Program.Battle
{
    class Battle
    {
        enum State { playerTurn, enemyTurn, battleOver }

        public static async Task Start()
        {
            charactersAtribute player = new charactersAtribute();
            Charmons mobs = new Charmons();
            inventory inv = new inventory();
            State state = State.playerTurn;
            string[] screen = { "Player", "Musuh", "battle Over" };


            while (state != State.battleOver)
            {
                Console.Clear();
                Console.WriteLine( "turn : " + screen[(int)state]);
                Console.WriteLine("HP player: " + player.getHealth() + " || " + "HP musuh: " + mobs.getHealthmons());
                switch (state)
                {
                    case State.playerTurn:
                        if (state == State.playerTurn)
                        {

                            await inv.showItems();

                            string input;
                            bool check = false;
                            do
                            {
                                Console.WriteLine("Masukkan nama senjata:");
                                input = Console.ReadLine();

                                if (input != "exit")
                                {
                                    var weapon = await inv.GetWeaponDamage(input);
                                    if (weapon == -1)
                                    {
                                        Console.WriteLine("input tidak valid");
                                        input = null;
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    mobs.setHealthmons(calculateAttack.getDamage(mobs.getHealthmons(), weapon));
                                    Console.ReadKey();
                                    Console.Clear();
                                    if (mobs.getHealthmons() <= 0)
                                    {
                                        Console.WriteLine("Pertarungan selesai, player menang");
                                        Console.ReadKey();
                                        Console.Clear();
                                        state = State.battleOver;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Giliran musuh menyerang");
                                        Console.ReadKey();
                                        Console.Clear();
                                        state = State.enemyTurn;
                                    }
                                }
                                else if (input == "exit")
                                {
                                    Console.WriteLine("keluar dari battle");
                                    Console.ReadKey();
                                    Console.Clear();
                                    state = State.battleOver;
                                    break;
                                }
                            } while (input == null);
                        }
                        break;

                    case State.enemyTurn:
                        if (state == State.enemyTurn)
                        {
                            player.setHealth(calculateAttack.enemyDMG(player.getHealth()));
                            Console.ReadKey();
                            Console.Clear();
                            if (player.getHealth() <= 0)
                            {
                                Console.WriteLine("pertarungan selesai player kalah");
                                Console.ReadKey();
                                Console.Clear();
                                state = State.battleOver;

                            }
                            else
                            {
                                Console.WriteLine("giliran player menyerang");
                                Console.ReadKey();
                                Console.Clear();
                                state = State.playerTurn;
                            }
                        }
                        break;
                }
            }
        }
    }
}
