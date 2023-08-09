// See https://aka.ms/new-console-template for more information
using Chess;
using Common;
using ExperienceConsole;

#region "Chess"
const short xsize = 8, ysize = 8;
ChessGame game = new ChessGame("Chess", true, 2);
Console.WriteLine(game.AddBoard(xsize, ysize));
Player player1 = game.AddPlayer("Kemal", PlayerColor.White.GetKey());
Player player2 = game.AddPlayer("Merve", PlayerColor.Black.GetKey());
Console.WriteLine(" ...................................");
Console.WriteLine(" ...................................");
Console.WriteLine(" ............." + game.GetGameName() + " Started.........");
Console.WriteLine(" ...................................");
Console.WriteLine(" ...................................");

game.Board.SetStoneList(0, 0, new Castle(PlayerColor.White.GetKey(), StoneName.Castle.GetKey(), 0, 0, player1));
game.Board.SetStoneList(0, 1, new Horse(PlayerColor.White.GetKey(), StoneName.Horse.GetKey(), 0, 1, player1));
game.Board.SetStoneList(0, 2, new Elephant(PlayerColor.White.GetKey(), StoneName.Elephant.GetKey(), 0, 2, player1));
game.Board.SetStoneList(0, 3, new King(PlayerColor.White.GetKey(), StoneName.King.GetKey(), 0, 3, player1));
game.Board.SetStoneList(0, 4, new Queen(PlayerColor.White.GetKey(), StoneName.Queen.GetKey(), 0, 4, player1));
game.Board.SetStoneList(0, 5, new Elephant(PlayerColor.White.GetKey(), StoneName.Elephant.GetKey(), 0, 5, player1));
game.Board.SetStoneList(0, 6, new Horse(PlayerColor.White.GetKey(), StoneName.Horse.GetKey(), 0, 6, player1));
game.Board.SetStoneList(0, 7, new Castle(PlayerColor.White.GetKey(), StoneName.Castle.GetKey(), 0, 7, player1));

for (short i = 0; i < 8; i++)
{
    game.Board.SetStoneList(1, i, new Pawn(PlayerColor.White.GetKey(), StoneName.Pawn.GetKey(), 1, i, true, player1));
}

game.Board.SetStoneList(7, 0, new Castle(PlayerColor.Black.GetKey(), StoneName.Castle.GetKey(), 7, 0, player2));
game.Board.SetStoneList(7, 1, new Horse(PlayerColor.Black.GetKey(), StoneName.Horse.GetKey(), 7, 1, player2));
game.Board.SetStoneList(7, 2, new Elephant(PlayerColor.Black.GetKey(), StoneName.Elephant.GetKey(), 7, 2, player2));
game.Board.SetStoneList(7, 3, new King(PlayerColor.Black.GetKey(), StoneName.King.GetKey(), 7, 3, player2));
game.Board.SetStoneList(7, 4, new Queen(PlayerColor.Black.GetKey(), StoneName.Queen.GetKey(), 7, 4, player2));
game.Board.SetStoneList(7, 5, new Elephant(PlayerColor.Black.GetKey(), StoneName.Elephant.GetKey(), 7, 5, player2));
game.Board.SetStoneList(7, 6, new Horse(PlayerColor.Black.GetKey(), StoneName.Horse.GetKey(), 7, 6, player2));
game.Board.SetStoneList(7, 7, new Castle(PlayerColor.Black.GetKey(), StoneName.Castle.GetKey(), 7, 7, player2));

for (short i = 0; i < 8; i++)
{
    game.Board.SetStoneList(6, i, new Pawn(PlayerColor.Black.GetKey(), StoneName.Pawn.GetKey(), 6, i, true, player2));
}



while (game.Board.StoneList.Select(x => x.Value).ToList().Where(x => x != null).Select(x => x.Color).Count(x => x == PlayerColor.White.GetKey()) > 0 ||
       game.Board.StoneList.Select(x => x.Value).ToList().Where(x => x != null).Select(x => x.Color).Count(x => x == PlayerColor.Black.GetKey()) > 0)
{
    while (game.Play(game.Board, player1, game))
    {
        while (!game.Play(game.Board, player2, game))
        {

        }
    }
}



#endregion