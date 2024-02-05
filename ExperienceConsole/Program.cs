// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern;
using AbstractFactoryPattern.DBConnection;
using AbstractFactoryPattern.Publisher.Factories;
using ActiveRecord;
using AdapterGof;
using BridgeGof;
using BuilderPattern;
using ChainOfResponsibilityGof;
using Chess;
using CommandGof;
using Common;
using CompositeGof;
using DataMapper;
using DecaratorGof;
using ExperienceConsole;
using FacadeGof;
using FactoryPattern;
using FlyweightGof;
using InterpreterGof;
using IteratorGof;
using MediatorGof;
using MementoGof;
using ObserverGof;
using PrototaypePattern;
using ProxyGof;
using RowDataGateway;
using Singleton;
using StateGof;
using StrategyGof;
using System.Data.SqlClient;
using TableGateway;
using TemplateMethodGof;
using VisitorGof;


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

#region "Factory"
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

#region Builder
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

#region Prototype
PrototaypePattern.Product product = new PrototaypePattern.Product() { Code = "BMW", Description = "Alman arabası"};
PrototaypePattern.Product product1 = product.Clone() as PrototaypePattern.Product;// deep copy
PrototaypePattern.Product product2 = product.CloneImplement() as PrototaypePattern.Product;// deep copy ours
product1.Code = "Mercedes";
product2.Code = "TOGG";
product2.Description = "Türk arabası";
Console.WriteLine(product.Code + " "+ product.Description);
PrototaypePattern.Product product3 = product;// shallow copy both objects are changed 
product3.Code = "Renault";
product3.Description = "Fransız arabası";
Console.WriteLine(product1.Code + " " + product1.Description);
Console.WriteLine(product2.Code + " " + product2.Description);
Console.WriteLine(product3.Code + " " + product3.Description);
Console.WriteLine(product.Code + " " + product.Description);
#endregion

#region Adapter
Console.WriteLine("-------------------------------");
ILogger logger2 = new XLoggerAdapter();
logger2.Log ("My log is here");
Console.WriteLine("-------------------------------");
#endregion

#region Bridge
Console.WriteLine("-------------------------------");
Report report = new SalesReport(new DesktopFormat());
report.Display();

Report report2 = new SalesReport(new WebFormat());
report2.Display();

Report report3 = new PerformanceReport(new DesktopFormat());
report3.Display();

Report report4 = new PerformanceReport(new WebFormat());
report4.Display();
Console.WriteLine("-------------------------------");
#endregion

#region Composite
Console.WriteLine("-------------------------------");
Commander general = new Commander("Kemal", "General");
Commander albay = new Commander("Ali", "Albay");
general.AddSoldier(albay);
Commander yarbay = new Commander("Veli", "Yarbay");
albay.AddSoldier(yarbay);
Private private1 = new Private("Rüzgar","Er");
Private private2 = new Private("Ayşe","Er");
Private private3 = new Private("Ahmet","Er");
yarbay.AddSoldier(private1);
yarbay.AddSoldier(private2);
yarbay.AddSoldier(private3);

general.ExecuteOrder();
Console.WriteLine("-------------------------------");
#endregion

#region Decarator
Console.WriteLine("-------------------------------");
IDBHelper dBHelper = new DBHelper();
dBHelper.Get();
dBHelper.Save();
dBHelper.Update();
dBHelper.Delete();
Console.WriteLine("-------------------------------");
DBHelperDecarator decarator = new DBHelperDecarator(dBHelper);
decarator.Get();
decarator.Save();
decarator.Update();
decarator.Delete();
Console.WriteLine("-------------------------------");
LogDBHelperDecarator decarator2 = new LogDBHelperDecarator(dBHelper);
decarator2.Get();
decarator2.Save();
decarator2.Update();
decarator2.Delete();
Console.WriteLine("-------------------------------");
MailDBHelperDecarator decarator3 = new MailDBHelperDecarator(dBHelper);
decarator3.Get();
decarator3.Save();
decarator3.Update();
decarator3.Delete();
Console.WriteLine("-------------------------------");
SecurityDBHelperDecarator decarator4 = new SecurityDBHelperDecarator(dBHelper);
decarator4.Get();
decarator4.Save();
decarator4.Update();
decarator4.Delete();
#endregion

#region Facade
Console.WriteLine("-------------------------------");
HotelSearcherFacade hotelSearcherFacade = new HotelSearcherFacade();
hotelSearcherFacade.SearchHotel("My tckn");
Console.WriteLine("-------------------------------");
#endregion

#region FlyWeight
Console.WriteLine("-------------------------------");
SoldierType[] soldierTypeList =
{
    SoldierType.Private,SoldierType.Private,SoldierType.Private,SoldierType.Private,SoldierType.Private,
    SoldierType.Sergeant,SoldierType.Sergeant,
    SoldierType.Commander
};

string[] nameList = { "Ali", "Veli", "Ahmet", "Hasan", "Hüseyin", "Kemal", "Özgür", "Naci" };
Random rnd = new Random();
SoldierFactory soldierFactory = new SoldierFactory();
int X = 0, Y = 0, randomCount = 0;
foreach (var soldierType in soldierTypeList)
{
    SoldierFlyweight soldier = soldierFactory.GetSoldier(soldierType);
    X += 5;
    Y += 10;
    soldier.XLocation = X;
    soldier.YLocation = Y;
    randomCount = rnd.Next(soldierTypeList.Length);
    soldier.Name = nameList[randomCount];
    soldier.MoveTo(X, Y, soldier.Name);
}
Console.WriteLine("-------------------------------");
#endregion

#region Proxy
Console.WriteLine("-------------------------------");
ICommandExecutor commandExecutor = new CommandExecutorProxy("admin", "admin");
commandExecutor.RunCommand("select * from");
commandExecutor.RunCommand("alter table");

commandExecutor = new CommandExecutorProxy("ali", "123");
commandExecutor.RunCommand("select * from");
commandExecutor.RunCommand("alter table");
Console.WriteLine("-------------------------------");
#endregion

#region Chain Of Responsibility
Console.WriteLine("-------------------------------");
Withdraw withdraw1 = new Withdraw("1", 900, "TL");
Withdraw withdraw2 = new Withdraw("1", 1900, "TL");
Withdraw withdraw3 = new Withdraw("1", 7900, "TL");
Withdraw withdraw4 = new Withdraw("1", 79000, "TL");
Worker director = new Director();
Worker gmy = new AsistantGeneralManager();
Worker gm = new GeneralManager();
director.SetNextApprover(gmy);
gmy.SetNextApprover(gm);

director.Execute(withdraw1);
Console.WriteLine("-------------------------------");
director.Execute(withdraw2);
Console.WriteLine("-------------------------------"); 
director.Execute(withdraw3);
Console.WriteLine("-------------------------------"); 
director.Execute(withdraw4);
Console.WriteLine("-------------------------------");
#endregion

#region Command
Console.WriteLine("-------------------------------");
ReceiverBank bank1 = new ReceiverBank("AktifBank");
ReceiverBank bank2 = new ReceiverBank("Teb");

ReceiverSupplier supplier1 = new ReceiverSupplier(1, "Paycore");
ReceiverSupplier supplier2 = new ReceiverSupplier(2, "BankSoft");

ICommand command1 = new BankAddCommand(bank1);
ICommand command2 = new BankDeleteCommand(bank2);
ICommand command3 = new EnableSupplierCommand(supplier1);
ICommand command4 = new DisableSupplierCommand(supplier2);

CommandManager commandManager = new CommandManager();
commandManager._commands.Enqueue(command1);
commandManager._commands.Enqueue(command2);
commandManager._commands.Enqueue(command3);
commandManager._commands.Enqueue(command4);
commandManager.ExecuteAll();
Console.WriteLine("-------------------------------");
#endregion

#region Interpreter
Console.WriteLine("-------------------------------");
//MDCLXVI = (M = 1000) + (D = 500) + (C = 100) + (L = 50) + (X = 10) - (I = 1) = 1664
ExpressionRunner runner = new ExpressionRunner();
Context context = new Context() { Formula = "MDCLXVI"};
runner.RunExpression(context);
context = new Context() { Formula = "MDCLXIV" };
runner.RunExpression(context);
context = new Context() { Formula = "MCCCCLIII" };
runner.RunExpression(context);
Console.WriteLine("-------------------------------");
#endregion

#region Strategy
Console.WriteLine("-------------------------------");
DateTime startTime = DateTime.Now;
List<int> list = new List<int> { 0, 7, 3, 10, 8, 5, 6 };
Sorter sorter = new Sorter(new BubleSort());
sorter.Sort(list);
DateTime endTime = DateTime.Now;
Console.WriteLine($"BubleSort elapsed time: {endTime.Millisecond - startTime.Millisecond}");

startTime = DateTime.Now;
list = new List<int> { 0, 7, 3, 10, 8, 5, 6 };
sorter = new Sorter(new QuickSort());
sorter.Sort(list);
endTime = DateTime.Now;
Console.WriteLine($"QuickSort elapsed time: {endTime.Millisecond - startTime.Millisecond}");

startTime = DateTime.Now;
list = new List<int> { 0, 7, 3, 10, 8, 5, 6 };
sorter = new Sorter(new InsertionSort());
sorter.Sort(list);
endTime = DateTime.Now;
Console.WriteLine($"InsertionSort elapsed time: {endTime.Millisecond - startTime.Millisecond}");

Console.WriteLine("-------------------------------");
#endregion

#region Iterator
Console.WriteLine("-------------------------------");
ProductCollection productCollection = new ProductCollection();
productCollection[0] = new IteratorGof.Product { Id = 1, Name = "Kredi Kartı", Price = 100 };
productCollection[0] = new IteratorGof.Product { Id = 2, Name = "Debit", Price = 80 };
productCollection[0] = new IteratorGof.Product { Id = 3, Name = "Prepaid", Price = 50 };
productCollection[0] = new IteratorGof.Product { Id = 4, Name = "Virtual", Price = 20 };
ProductIterator productIterator = new ProductIterator(productCollection);
productIterator._stepSize = 2;
 
for (IteratorGof.Product productIterator1 = productIterator.First();
    productIterator.IsContinue;
    productIterator1 = productIterator.MoveNext())
{
    Console.WriteLine(productIterator1.ToString());
}

ProductList productList = new ProductList();
productList[0] = new IteratorGof.Product { Id = 1, Name = "Kredi Kartı", Price = 100 };
productList[0] = new IteratorGof.Product { Id = 2, Name = "Debit", Price = 80 };
productList[0] = new IteratorGof.Product { Id = 3, Name = "Prepaid", Price = 50 };
productList[0] = new IteratorGof.Product { Id = 4, Name = "Virtual", Price = 20 };

foreach (var productIterator2 in productList)
{
    Console.WriteLine(productIterator2.ToString());
}

Console.WriteLine("-------------------------------");
#endregion

#region Template Report
Console.WriteLine("-------------------------------");
GameReporter gameReporter = new XmlReport();
gameReporter.WriteSummary();
Console.WriteLine();

gameReporter = new JsonReport();
gameReporter.WriteSummary();
Console.WriteLine();

gameReporter = new HtmlReport();
gameReporter.WriteSummary();
Console.WriteLine("-------------------------------");
#endregion

#region Observer
Console.WriteLine("-------------------------------");
FatherObserver fatherObserver = new();
MotherObserver motherObserver = new();
TeacherObserver teacherObserver = new();
Student student = new Student("Özgür", 1, 2, true);
student.AddObserver(fatherObserver);
student.AddObserver(motherObserver);
student.AddObserver(teacherObserver);
student.IsStudentExistsOnLesson = false;
Console.WriteLine("-------------------------------");
#endregion

#region Memento
Console.WriteLine("-------------------------------");
Part part = new();
part.PartName = "1.Bölüm";
part.PartProgress = 60;
Console.WriteLine($"Kullanıcı {part.PartName} {part.PartProgress} tamamladı.");
PartManager partManager = new();
partManager.PartOldCheckPoint = part.Save();
Console.WriteLine("Oyun kaydedildi.");
part.PartProgress = 0;
Console.WriteLine("Oyuncu öldü yeniden yüklenecek.");
part.LoadPart(partManager.PartOldCheckPoint);
Console.WriteLine("Oyun yeniden yüklendi.");
Console.WriteLine($"Kullanıcı {part.PartName} {part.PartProgress} seviyesinden yeniden başlıyor.");
Console.WriteLine("-------------------------------");
#endregion

#region Mediator
Console.WriteLine("-------------------------------");
SabihaGokcenAirControl airportControl = new();
TurkishAirlines turkishAirlines = new() { _airportControl = airportControl, _fligthNumber = "TK01", _from = "Antalya", _way = "25,50" };
airportControl.Register(turkishAirlines);
PegasusAirlines pegasusAirlines = new() { _airportControl = airportControl, _fligthNumber = "PC01", _from = "İzmir", _way = "25,50" };
airportControl.Register(pegasusAirlines);
KatarAirlines katarAirlines = new() { _airportControl = airportControl, _fligthNumber = "KT01", _from = "Katar", _way = "35,50" };
airportControl.Register(katarAirlines);

katarAirlines.RequestWay(katarAirlines._way);
pegasusAirlines.RequestWay(pegasusAirlines._way);
turkishAirlines.RequestWay(turkishAirlines._way);
Console.WriteLine("-------------------------------");
#endregion

#region State
Console.WriteLine("-------------------------------");
Asistant asistant = new();
asistant.Answer();
asistant.ChangeMod(new Away());
asistant.Answer();
asistant.ChangeMod(new Close());
asistant.Answer();
Console.WriteLine("-------------------------------");
#endregion

#region Visitor
Console.WriteLine("-------------------------------");
PlainText plainText = new();
BoldText boldText = new();
HyperLink hyperLink = new();
plainText.Text = "experience is this";
boldText.Text = "bold text";
hyperLink.Text = "www.google.com";
Visitor visitor = new HtmlVisitor();
plainText.Accept(visitor);
boldText.Accept(visitor);
hyperLink.Accept(visitor);
Console.WriteLine(visitor.Output);
Console.WriteLine("-------------------------------");
#endregion

#region DataLayer
#region ActiveRecord
Console.WriteLine("-------------------------------");
CustomerActiveRecord customer2 = new();
customer2.Country = "Türkiye";
customer2.FirstName = "Kemal";
customer2.LastName = "Özkesen";
customer2.BirthDate = new DateTime(1989, 07, 05);
int customerId = customer2.AddCustomer();

CustomerActiveRecord customerGet2 = new();
customerGet2.Id = customer2.Id;
customerGet2.GetCustomerByBusinessRule();
customerGet2.GetCustomerByOtherBusinessRule();

CustomerActiveRecord customerUpdate2 = new();
customerUpdate2.Country = "Türkiye";
customerUpdate2.FirstName = "Kemal";
customerUpdate2.LastName = "Özkesen";
customerUpdate2.BirthDate = new DateTime(1989, 07, 05);
customerUpdate2.UpdateCustomer();

CustomerActiveRecord customerDelete2 = new();
customerDelete2.Id = customerId;
customerDelete2.RemoveCustomer();

Console.WriteLine("-------------------------------");
#endregion

#region DataMapper
Console.WriteLine("-------------------------------");
Customer customer3 = new();  
customer3.Country = "Türkiye";
customer3.FirstName = "Kemal";
customer3.LastName = "Özkesen";
customer3.BirthDate = new DateTime(1989, 07, 05);
CustomerDataMapper customerDataMapper = new();
customerDataMapper.Insert(customer3);
customer3.Country = "USA";
customerDataMapper.Update(customer3);
customerDataMapper.GetAll();
customerDataMapper.GetById(1);
customerDataMapper.Delete(customer3);
Console.WriteLine("-------------------------------");
#endregion

#region TableGateway
Console.WriteLine("-------------------------------");
CustomerGateway customerGateway = new();
customerGateway.GetCustomerByFirstName("Ahmet");
customerGateway.AddCustomer("Ahmet", "Yılmaz", new DateTime(2023,1,1),"Türkiye");
customerGateway.UpdateCustomer("Ahmet", "Yılmaz", new DateTime(2023,1,1),"Almanya");
customerGateway.RemoveCustomer(1);
Console.WriteLine("-------------------------------");
#endregion

#region RowDataGateway
Console.WriteLine("-------------------------------");
RowDataGatewayCustomer customer = new();
customer.Country = "Türkiye";
customer.FirstName = "Kemal";
customer.LastName = "Özkesen";
customer.BirthDate = new DateTime(1989, 7, 5);
int id = customer.AddCustomer();

RowDataGatewayCustomer customerGet = new();
customerGet.Id = id;
customerGet.GetCustomerById();

RowDataGatewayCustomer customerUpdate = new();
customerUpdate.Country = "Belçika";
customerUpdate.UpdateCustomer();

RowDataGatewayCustomer customerDelete = new();
customerDelete.Id = id;
customerDelete.RemoveCustomer();
Console.WriteLine("-------------------------------");
#endregion
#endregion