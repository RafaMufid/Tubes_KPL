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
            CharA player = new CharA();
            Charmons mobs = new Charmons();
            INV inv = new INV();
            State state = State.playerTurn;
            string[] screen = { "player Turn", "enemy Turn", "battle Over" };


            while (state != State.battleOver)
            {
                Console.WriteLine(screen[(int)state]);
                Console.WriteLine("HP player: " + player.getHealth() + " || " + "HP musuh: " + mobs.getHealthmons());
                switch (state)
                {
                    case State.playerTurn:
                        if (state == State.playerTurn)
                        {

                            await inv.showINV();

                            int input = -1;
                            bool check = false;
                            do
                            {
                                Console.WriteLine("Masukkan nomor pilihan (angka):");
                                input = Convert.ToInt32(Console.ReadLine());

                                if (input != -1)
                                {
                                    var weapon = await inv.GetWeapon(input);
                                    mobs.setHealthmons(AttackCal.getDamage(mobs.getHealthmons(), weapon ));
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
                                else
                                {
                                    Console.WriteLine("Input tidak valid, masukkan angka yang sesuai.");
                                }
                            } while (input == -1);
                        }
                        break;

                    case State.enemyTurn:
                        if (state == State.enemyTurn)
                        {
                            player.setHealth(AttackCal.enemyDMG(player.getHealth()));
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
