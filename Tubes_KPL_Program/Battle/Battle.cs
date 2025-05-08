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
        enum State {  playerTurn, enemyTurn, battleOver}

        public static void Start() {
            CharA player = new CharA();
            CharA mobs = new CharA();
            var inv = new INV<string>();
            State state = State.playerTurn;
            string[] screen = { "player Turn", "enemy Turn", "battle Over" };
            inv.AddItem("sword");
 

            while (state != State.battleOver) {
                Console.WriteLine(screen[(int)state]);
                Console.WriteLine("HP player: " + player.getHealth() + " || " + "HP musuh: " + mobs.getHealth());
                switch (state) {
                    case State.playerTurn:
                        if (state == State.playerTurn) {

                            inv.ShowInv();
                            Console.WriteLine("masukkan aksi: ");

                            string input = null;
                            bool check = false;
                            do
                            {
                                input = Console.ReadLine();
                                

                                if (input == "heal")
                                {
                                    Console.WriteLine("player berhasil diheal");
                                    player.setHealth(AttackCal.getHeal(player.getHealth(), input));
                                    Console.ReadKey();
                                    Console.Clear();
                                    check = true;
                                }
                                else if (inv.CheckItem(input) == false)
                                {
                                    Console.WriteLine($"{input} tidak ditemukan di inventory.");
                                    Console.WriteLine("masukkan aksi lagi!");
                                    Console.ReadKey();
                                    Console.Clear();
                                    check = false;

                                }
                            } while (!check);

                            if (input != null && check == true) {
                                Console.WriteLine("player melakukan serangan " + input);
                                mobs.setHealth(AttackCal.getDamage(mobs.getHealth(), input));
                                Console.ReadKey();
                                Console.Clear();
                            }

                            if (mobs.getHealth() <= 0)
                            {
                                Console.WriteLine("pertarungan selesai player menang");
                                Console.ReadKey();
                                Console.Clear();
                                state = State.battleOver;
                            }
                            else {
                                Console.ReadKey();
                                Console.Clear();
                                state = State.enemyTurn;
                            }
                        }
                        break;

                    case State.enemyTurn:
                        if (state == State.enemyTurn) {
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
