using Common;

namespace Chess
{
    public class ChessGame : Game
    {
        public ChessGame(string gameName, bool hasBoard, short playerCount) 
            : base(gameName, hasBoard, playerCount)
        {
        }

        public override string AddBoard(short xsize, short ysize)
        {
            if (HasBoard)
            {
                board = new Board(xsize, ysize);
                return "Chess board added";
            }

            return string.Empty;
        }
        public override Player AddPlayer(string playerName, string color)
        {
            Player player = new Player(playerName, color);
            PlayerList.Add(player);
            Console.WriteLine(string.Format("Player added Player:{0} Name:{1} Color:{2}", PlayerList.Count, playerName, color));
            return player;
        }

        public override string GetGameName()
        {
            return GameName;
        }

        private void DrawGameBoard(Game game)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("   ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i.ToString() + "  ");
            }
            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i.ToString() + "  ");
                for (int y = 0; y < 8; y++)
                {
                    if(game.Board.StoneList[i.ToString() + y.ToString()]?.Color == PlayerColor.Black.GetKey())
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    switch (game.Board.StoneList[i.ToString() + y.ToString()]?.Name)
                    {
                        case "King":
                            Console.Write(".K.");
                            break;
                        case "Queen":
                            Console.Write(".Q.");
                            break;
                        case "Elephant":
                            Console.Write(".E.");
                            break;
                        case "Horse":
                            Console.Write(".H.");
                            break;
                        case "Castle":
                            Console.Write(".C.");
                            break;
                        case "Pawn":
                            Console.Write(".P.");
                            break;
                        default:
                            Console.Write("...");
                            break;
                    }
                    Console.Write("");
                }
                Console.WriteLine();
            }
        }

        public bool Play(Board board, Player player, Game game)
        {
            DrawGameBoard(game);
            bool selectedStone = false;
            string xLocation = string.Empty;
            string yLocation = string.Empty;
            while (!selectedStone)
            {
                Console.WriteLine("select x {0}", player.GamerName);
                xLocation = Console.ReadLine();

                Console.WriteLine("select y {0}", player.GamerName);
                yLocation = Console.ReadLine();

                if(game.Board.StoneList[xLocation + yLocation] != null &&
                   game.Board.StoneList[xLocation + yLocation].Player == player)
                {
                    selectedStone = true;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("stone selected");
                    Console.Clear();
                    DrawGameBoard(game);
                }
                else
                {
                    Console.WriteLine("Invalid selection!");
                }
            }

            Console.WriteLine("start first move x {0}", player.GamerName);
            short xLocationTo = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("start first move y {0}", player.GamerName);
            short yLocationTo = Convert.ToInt16(Console.ReadLine());

            Stone stone = game.Board.StoneList[xLocation + yLocation];
            while(!stone.MoveTo(game.Board, xLocationTo, yLocationTo, stone))
            {
                Console.WriteLine("Invalid move!");
                return false;
            }

            DrawGameBoard(game);
            return true;
        }
    }
}
