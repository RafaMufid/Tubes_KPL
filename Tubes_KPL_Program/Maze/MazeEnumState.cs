using System;

namespace MazeEnumState
{
    class Program
    {
        // Definisikan semua state sebagai enum
        enum State { Maze, A, B, C, D, E, F, G, H, I }

        static void Main()
        {
            State currentState = State.Maze;
            string input;

            Console.WriteLine("Selamat datang di Maze Automata (pakai enum state)!");
            Console.WriteLine("Perintah: go, up, down, left, right");
            Console.WriteLine("Capai state 'I' untuk menang!");

            while (true)
            {
                Console.WriteLine($"\nKamu sekarang di: {currentState}");

                if (currentState == State.I)
                {
                    Console.WriteLine("Selamat, kamu berhasil keluar dari maze!");
                    break;
                }

                Console.Write("Arahkan (go/up/down/left/right): ");
                input = Console.ReadLine();

                currentState = NextState(currentState, input);
            }
        }

        static State NextState(State currentState, string input)
        {
            switch (currentState)
            {
                case State.Maze:
                    if (input == "go") return State.D;
                    break;

                case State.D:
                    if (input == "right") return State.E;
                    else if (input == "up") return DeadEnd(State.A);
                    break;

                case State.E:
                    if (input == "left") return State.D;
                    else if (input == "right") return DeadEnd(State.F);
                    else if (input == "up") return State.B;
                    else if (input == "down") return State.H;
                    break;

                case State.H:
                    if (input == "right") return State.I;
                    break;

                case State.B:
                    if (input == "right") return DeadEnd(State.C);
                    break;

                // Semua state jalan buntu
                case State.A:
                case State.C:
                case State.F:
                case State.G:
                    return DeadEnd(currentState);

                default:
                    Console.WriteLine("Arah tidak valid dari sini.");
                    break;
            }

            Console.WriteLine("Tidak bisa ke arah itu dari sini.");
            return currentState;
        }

        static State DeadEnd(State state)
        {
            Console.WriteLine($"Kamu masuk ke {state}. Jalan buntu! Kembali ke Maze.");
            return State.Maze;
        }
    }
}