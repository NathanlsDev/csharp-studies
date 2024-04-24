using Calculator.Services;

CalculatorImp calc = new CalculatorImp();
int num1 = 5;
int num2 = 15;

Console.WriteLine($"{num1} + {num2} = {calc.Sum(num1, num2)}");

