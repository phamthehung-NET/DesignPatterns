using DesignPatterns.CreationPattern.AbtractFactory;
using DesignPatterns.CreationPattern.Builder;
using DesignPatterns.StructuralPattern.Adapter;
using DesignPatterns.CreationPattern.FactoryMethod;
using DesignPatterns.CreationPattern.Prototype;
using DesignPatterns.CreationPattern.Singleton;
using DesignPatterns.StructuralPattern.Bridge;

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
    .AddCPU("Intel I7 12700F")
    .AddRAM("32GB")
    .AddStorage("SSD Samsung 512GB Gen 4x4")
    .AddGPU("NVIDIA RTX 2060 Super")
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