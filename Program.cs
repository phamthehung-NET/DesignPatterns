using DesignPatterns.CreationPattern.AbtractFactory;
using DesignPatterns.CreationPattern.FactoryMethod;
using DesignPatterns.CreationPattern.Singleton;

#region Singleton
var database = Database.GetDatabaseInstance();

Console.WriteLine(database.Name);

var userTable = database.Tables.FirstOrDefault(t => t.Name.Contains("User"));
var departmentTable = database.Tables.FirstOrDefault(t => t.Name.Contains("Department"));

var database2 = Database.GetDatabaseInstance();

Console.WriteLine(userTable.GetDataByColumn("Description"));
#endregion

#region FactoryMethod
var person = PersonFactory.CreatePerson(PersonType.Teacher);
Console.WriteLine(person.GetPerson());
#endregion

#region AbstractFactory
var houseHoldClient = new Client(new HouseHoldFactory());
var officeClient = new Client(new OfficeFactory());

Console.WriteLine("---House Hold Items Action---");
houseHoldClient.GetAction();
Console.WriteLine("---Office Items Action---");
officeClient.GetAction();
#endregion

