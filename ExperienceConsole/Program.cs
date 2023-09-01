// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern;
using AbstractFactoryPattern.DBConnection;
using AbstractFactoryPattern.Publisher.Factories;
using BuilderPattern;
using Chess;
using Common;
using ExperienceConsole;
using FactoryPattern;
using Singleton;
using System.Data.SqlClient;


#region "Chess"
/*
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


*/
#endregion


#region Singleton

MySingleton mySingleton1 = MySingleton.GetMySingletonObj(); 
MySingleton mySingleton2 = MySingleton.GetMySingletonObj();

if(mySingleton1.GetHashCode == mySingleton2.GetHashCode)
{
    Console.WriteLine("objeler aynı.");
}  
Logger logger = Logger.GetInstance();
logger.Info("deneme");
logger.Error("deneme err");

#endregion


#region "Factory GOF"
PaymentFactory paymentFactory = new PaymentFactory();
IPayment payment = paymentFactory.DoPayment("CreditCard");
payment.DoPayment();
payment.DoSomeOtherJobs();

payment = paymentFactory.DoPayment("Eft");
payment.DoPayment();
payment.DoSomeOtherJobs();

payment = paymentFactory.DoPayment("AtDoor");
payment.DoPayment();
payment.DoSomeOtherJobs();
#endregion

#region Abstract Factory
OracleFactory oracleFactory = new OracleFactory();
PostgresqlFactory postgresqlFactory = new PostgresqlFactory();
Factory factory = new Factory(oracleFactory);
factory.Start("select * from oracle");

factory = new Factory(postgresqlFactory);
factory.Start("select * from postgres");

FactoryGeneric<OracleFactory> factoryGenericOracle = new FactoryGeneric<OracleFactory>();
factoryGenericOracle.Start("insert into oracle");


FactoryGeneric<PostgresqlFactory> factoryGenericPostgresql = new FactoryGeneric<PostgresqlFactory>();
factoryGenericPostgresql.Start("insert into postgresql");





Publisher<FacebookTextPublisherFactory> publisher1 = new Publisher<FacebookTextPublisherFactory>("text");
publisher1.Publish();


Publisher<FacebookVideoPublisherFactory> publisher2 = new Publisher<FacebookVideoPublisherFactory>("video");
publisher2.Publish();


Publisher<TwitterVideoPublisherFactory> publisher3 = new Publisher<TwitterVideoPublisherFactory>("video");
publisher3.Publish();
#endregion


#region Builder GOF
CarProducer carProducer = new CarProducer();
CarBuilder carBuilder = new MercedesBuilder();
carProducer.Produce(carBuilder, "CLA", GearType.Manuel.GetKey(), 6001);
Console.WriteLine(carBuilder.Car.ToString());

carProducer.Produce(carBuilder, "Vito", GearType.Automatic.GetKey(), 90000);
Console.WriteLine(carBuilder.Car.ToString());

carBuilder = new BmwBuilder();
carProducer.Produce(carBuilder, "X5", GearType.Automatic.GetKey(), 0);
Console.WriteLine(carBuilder.Car.ToString());

carBuilder = new TOGGBuilder();
carProducer.Produce(carBuilder, "T10X", GearType.Electric.GetKey(), 0);
Console.WriteLine(carBuilder.Car.ToString());
#endregion

