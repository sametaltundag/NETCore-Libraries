//using Solid.App.OCPBad;
//using Solid.App.OCPGood;
//using Solid.App.OCPGood2;
//using Solid.App.LSPBad;
//using Solid.App.DIPGoodAndBad;
//using Solid.App.LSPGood;
using Solid.App.DIPGoodAndBad;

/*
 * 
 * OCP Bad Way
SalaryCalculator salaryCalculator = new SalaryCalculator();

Console.WriteLine($"Low Salary: { salaryCalculator.Calculate(1000, SalaryType.Low)}");
Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(2000, SalaryType.Middle)}");
Console.WriteLine($"High Salary: {salaryCalculator.Calculate(3000, SalaryType.High)}");
*/

/*
// OCP Good Way
SalaryCalculator salaryCalculator = new SalaryCalculator();
Console.WriteLine($"Low Salary: {salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(1000, new MiddleSalaryCalculate())}");
Console.WriteLine($"High Salary: {salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");
Console.WriteLine($"Manager Salary: {salaryCalculator.Calculate(1000, new ManagerSalaryCalculate())}");


// OCP Good Way 2
SalaryCalculator salaryCalculator = new SalaryCalculator();
Console.WriteLine($"Low Salary: {salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(1000, new MiddleSalaryCalculate().Calculate)}");
Console.WriteLine($"High Salary: {salaryCalculator.Calculate(1000, new HighSalaryCalculate().Calculate)}");
Console.WriteLine($"Manager Salary: {salaryCalculator.Calculate(1000, new ManagerSalaryCalculate().Calculate)}");

Console.WriteLine($"Custom Salary: {salaryCalculator.Calculate(1000, x =>
{
    return x * 10;
} )}");


BasePhone phone = new IPhone();

phone.Call();
phone.TakePhoto();

phone = new Nokia3310();

phone.Call();
phone.TakePhoto();



BasePhone phone = new IPhone();

phone.Call();
((ITakePhoto)phone).TakePhoto();

phone = new Nokia3310();
phone.Call();
*/

var ProductService = new ProductService(new ProductRepositoryFromSqlServer());
ProductService.GetAll().ForEach(x => Console.WriteLine(x));