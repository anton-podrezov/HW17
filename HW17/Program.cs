using HW17;

ICalculatedAccount account1 = new SalaryAccount { Balance = 20000 };
ICalculatedAccount account2 = new SimpleAccount { Balance = 120000 };

Calculator.CalculateInterest(account1);
Calculator.CalculateInterest(account2);

Console.WriteLine("Процентная ставка зарплатного - " + account1.Interest);
Console.WriteLine("Процентная ставка обычного - " + account2.Interest);
