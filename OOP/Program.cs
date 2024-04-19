using OOP.Models;

CheckingAccount anyBank = new CheckingAccount(4587, 450.00M);

anyBank.CheckBalance();
anyBank.Withdraw(200);
anyBank.CheckBalance();

// Person person = new Person();

// person.Name = "Derp";
// person.Age = 20;

// person.Salutations();