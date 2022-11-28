/*proxy
 */

using DesignPatterns.Proxy;

var youtube = new ProxyYoutubeService(new YoutubeService());
youtube.GetVideo(234);
youtube.GetVideo(234);
youtube.GetVideo(234);
youtube.GetVideo(54);


/*decorator
var pizzaBase = new SmallPizza();
var smallPizzaWithHam = new HamPizzaDecorator(pizzaBase);
var smallHamAndCheesse = new CheessePizzaDecorator(smallPizzaWithHam);
Console.WriteLine($"price base pizza {pizzaBase.CalculatePrice()} and with addons " +
                  $"{smallHamAndCheesse.CalculatePrice()}");

var doubleCheeseAndHam = new SalamiPizzaDecorator(smallHamAndCheesse);
Console.WriteLine($"price base pizza {pizzaBase.CalculatePrice()} and with addons " +
                  $"{smallHamAndCheesse.CalculatePrice()}");
 */


/*scan facade
var ScanFacade = new ScanFacade();
ScanFacade.Scan("http://hithub.com");
*/

/*adaper
// DesignPatterns.Adapter.INotificationSender notyficationSender = new DesignPatterns.Adapter.SmsSenderAdapter();
// notyficationSender.SendNotification(1, new Notyfication(){Body = "Thi is body sstirng", Title = "ABC Nagłowek"});
adapter*/
    
/*State
var context = new Context();
//context.EjectCard();
context.InsertCard();
context.InsertPin(1234);
context.InsertPin(3333);
context.WithdrawCash(500);
Console.WriteLine($"this is anvalible cash = {context.AnvalibleCash}");
context.WithdrawCash(500); 
 */

// /*templatemethod
// var pdfGenerator = new PdfGenerator();
// pdfGenerator.GenerateReport();
//
// var excelGenerator = new ExcelGenerator();
// excelGenerator.GenerateReport();
// */

/* Chain of responsibility
var requestContext = new RequestContext()
{
    Request = new Request()
    {
        EntityID = 101,
        UserID = 13,
        UserRole = "Admin"
    },
    Response = new Response()
};
ejected
var resultHandler = new ResultHandler(null);
var validationHandler = new ValidationHandler(resultHandler);
var authorizationHandler = new AuthoryzationHandler(validationHandler);


authorizationHandler.Handle(requestContext);

if(requestContext.Response.Message != null)
    Console.WriteLine(requestContext.Response.Message);
else
{
    Console.WriteLine(requestContext.Response.Data);
}
 */
/*mediator
Button button = new Button();
CheckBox checkBox = new CheckBox();

RegisterClientView registerClientView = new RegisterClientView(checkBox, button);
/*
 
/* observer
Publisher publisher = new Publisher();
var sub1 = new Subscribler("sub1");
var sub2 = new Subscribler("sub2");
var sub3 = new Subscribler("sub3");
publisher.Subscrible(sub1);
publisher.Subscrible(sub2);
publisher.UnSubscrible(sub3);

publisher.Notify("XYX A!!!!!!");

/*
 
 

/*strategy
var bike = new BikeStrategy();
var car = new CarStrategy();

var map = new Map(bike);
var mapcar = new Map(car);

map.CreateRout(new Cordinate(), new Cordinate());
mapcar.CreateRout(new Cordinate(),new Cordinate());

*/

/* singleton
var config = Configuration.GetInstance();
var config2 = Configuration.GetInstance();


bool equal = ReferenceEquals(config, config2);

Console.WriteLine(equal);

*/

Console.WriteLine();

/* Prototype
var c1 = new Circle()
{
    X = 1,
    Y = 1,
    Radius = 1,
    Border = new Border()
    {
        Color = "red",
        Size = "2px"
    }
};

Circle c2 = (Circle)c1.Clone();

bool refereceequals = ReferenceEquals(c1, c2);
Console.WriteLine($"Checking reference status is {refereceequals}");

bool deepreference = ReferenceEquals(c1.Border, c2.Border);
Console.WriteLine($"Checking reference status is {deepreference}");


c1.Border.Color = "black";
Console.WriteLine($"Checking reference status is {c2.Border.Color}");

Console.WriteLine();

*/

/* factory
// var app = new Application(new MacFactory());
// app.RenderUI();
//
// var windowapp = new Application(new WindowsFactory());
// windowapp.RenderUI();
*/
    
    
    
// var builder = new InvoiceBuilder();
// builder.SetDate(new DateTime(2000,1,1));
// builder.SetVendee("XXXX");
// builder.SetVendor("YYYY");
// builder.AddNote("Some note");
// builder.SetInvoiceNumber("12345");
// builder.SetLineItems(new []{"xxxxx1", "yyyyy2", "zzzzzz3"});
// Invoice invoice = builder.Build();


// var invoice = new Invoice(
//     new[]
//     {
//         new LineItem() { Name = "AAAA", Price = 200, Tax = 23 },
//         new LineItem() {Name = "BBBBB",Price = 300, Tax = 8},
//         new LineItem() {Name = "CCC", Price = 500, Tax = 5}
//     }, "1234567", "tITLE");
//
// var logger = new InvoiceLogger(invoice);
// logger.Display();
//
// var wordInvoiceSaver = new WordInvoiceSaver();
// wordInvoiceSaver.Save(invoice);
//
//
//
//
//
// var ser = new AuthenticationManager(new SmsNotyficationSender());
// ser.AuthenticateUser(new User(){Login = "aa", Email = "bb", Password = "bb"}, "aa","bb");
//
// EmailSender email = new EmailSender();
// email.SendEmail("hello", "helloodosadosdoasodoasd", "dsd@o.2pl");
//
//
//
// Console.WriteLine(GetBankAccount().Balance);
// GetBankAccount().MakeWithdraw(2000);
//
// static BankAccount GetBankAccount()
// {
//     var bank = new CompanyAccount();
//     return bank;
// }
//
//  static IPrinter GetPrinter()
// {
//     return new Hp();
// }