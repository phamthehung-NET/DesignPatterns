using DesignPatterns.CreationPattern.AbtractFactory;
using DesignPatterns.CreationPattern.Builder;
using DesignPatterns.CreationPattern.FactoryMethod;
using DesignPatterns.CreationPattern.Prototype;
using DesignPatterns.CreationPattern.Singleton;
using DesignPatterns.StructuralPattern.Adapter;
using DesignPatterns.StructuralPattern.Bridge;
using DesignPatterns.StructuralPattern.Composite;
using DesignPatterns.StructuralPattern.Decorator;
using DesignPatterns.StructuralPattern.Facade;
using DesignPatterns.StructuralPattern.Flyweight;
using File = DesignPatterns.StructuralPattern.Composite.File;
using UserService = DesignPatterns.StructuralPattern.Decorator.UserService;

#region Singleton

Console.WriteLine("***Singleton***");

var database = Database.Instance;

Console.WriteLine(database.Name);

var userTable = database.Tables.FirstOrDefault(t => t.Name.Contains("User"));
var departmentTable = database.Tables.FirstOrDefault(t => t.Name.Contains("Department"));

var database2 = Database.Instance;

Console.WriteLine("Data in Description column of User table: " + userTable?.GetDataByColumn("Description"));

#endregion

#region FactoryMethod

Console.WriteLine();
Console.WriteLine("***FactoryMethod***");

StudentFactory studentFactory = new();
IPerson person = studentFactory.CreatePerson();
Console.WriteLine(person.GetPerson());

#endregion

#region AbstractFactory

Console.WriteLine();
Console.WriteLine("***AbstractFactory***");

var houseHoldClient = new Client(new HouseHoldFactory());
var officeClient = new Client(new OfficeFactory());

Console.WriteLine("---House Hold Items Action---");
houseHoldClient.GetAction();
Console.WriteLine("---Office Items Action---");
officeClient.GetAction();

#endregion

#region Builder

Console.WriteLine();
Console.WriteLine("***Builder***");

var computer = new ComputerBuilder()
    .AddCPU("Intel Core I7 12700F")
    .AddRAM("32GB 4x8GB corsair black")
    .AddStorage("SSD Samsung 512GB Gen 4x4")
    .AddGPU("Colorful BattleAx Nvidia RTX 2060 Super")
    .AddMotherBoard("Asus TUF B660M Plus Wifi D4")
    .AddPSU("Asus TUF gaming 650W 80 Plus Bronze")
    .AddCooler("Thermalright Frozen Warframe 240 RGB")
    .AddCase("Sama 3301 Mid Tower ATX + 6 infinity RGB fans")
    .Build();

Console.WriteLine(computer);

#endregion

#region Prototype

Console.WriteLine();
Console.WriteLine("***Prototype***");

ServiceConfig baseConfig = new()
{
    Url = "https://api.example.com",
    TimeOut = 30,
};
ServiceConfig clonedConfig = baseConfig.Clone();
clonedConfig.TimeOut = 35;

Console.WriteLine(baseConfig);
Console.WriteLine(clonedConfig);

#endregion

#region Adapter

Console.WriteLine();
Console.WriteLine("***Adapter***");

var xml = new XML();
var docx = new Docx();

var xmlAdapter = new XMLAdapter(xml);
var xmlFile = xmlAdapter.ReturnFile("xml_test");

//case 1
//current logic
var xmlReader = new XmlReader(xmlFile); // accept

//for new logic, don't accept xml file
var docxReader = new DocxReader(xmlFile); // reject

// -> convert xml to docx for new logic
var docxAdapter = new DocxAdapter(docx);

docxReader = new DocxReader(docxAdapter.ReturnFile(xmlFile.FileName)); // accept

//case 2
//combine new logic with current logic -> no bugs
List<IOutputFile> adpters = new() { xmlAdapter, docxAdapter };
foreach (var adapter in adpters)
{
    Console.WriteLine(adapter.ReturnFile(Path.GetFileNameWithoutExtension(xmlFile.FileName)).FileName);
}

#endregion

#region Bridge

Console.WriteLine();
Console.WriteLine("***Bridge***");

SamsungPhone s22 = new();
AndroidDevice androidDevice = new(s22);
IPhone ip14 = new();
IosDevice iosDevice = new(ip14);

androidDevice.MakeACall("01234456789");
androidDevice.OpenApp("Facebook");

iosDevice.MakeAFaceTime("0123456789");
iosDevice.OpenApp("YouTube");

#endregion

#region Composite

Console.WriteLine();
Console.WriteLine("***Composite***");

var rootFolder = new Folder("root");

var downloadFolder = new Folder("Download");
downloadFolder.Add(new Folder("Office 2019 pro crack"));
downloadFolder.Add(new Folder("Games"));
downloadFolder.Add(new File("virus.exe"));
downloadFolder.Add(new File("windows_activation_key.txt"));

File mp3 = new("Trình.mp3");

rootFolder.Add(downloadFolder);
rootFolder.Add(mp3);

rootFolder.Info();

#endregion

#region Decorator

Console.WriteLine();
Console.WriteLine("***Decorator***");

var userService = new UserService();

var validationService = new ValidationService(userService);

validationService.CreateUser(new User()
{
    Email = "johndoes@email.com",
    Password = "123456",
    Name = "John Doe",
});

// use DI in real project
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.Decorate<IUserService, ValidationService>();

#endregion

#region Facade

Console.WriteLine();
Console.WriteLine("***Facade***");

Order order = new()
{
    CustomerName = "John Doe",
    Price = 20000000,
    ProductName = "Laptop",
    Quantity = 1
};

IStorageService storageService = new StorageService();
DesignPatterns.StructuralPattern.Facade.IUserService uService = new DesignPatterns.StructuralPattern.Facade.UserService();
IOrderService orderService = new OrderService();

IOrderFacade orderFacade = new OrderFacade(storageService, uService, orderService);

orderFacade.PlaceOrder(order);

#endregion

#region Flyweight

Console.WriteLine();
Console.WriteLine("***Flyweight***");

IEnemy enemy = EnemyFactory.GetEnemy("Normal");

for (int i = 0; i < 10; i++)
{
    enemy.Display(new Random().Next(9000000, 10000000));
}

#endregion