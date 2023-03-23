decimal balance = 75.45M;
string balanceMessage = "The current balance is: $";
Console.WriteLine(balanceMessage + balance);
balance -= 40;
Console.WriteLine(balanceMessage + balance);
balance -= 5;
Console.WriteLine(balanceMessage + balance);

decimal bookPrice = 25;
Console.WriteLine(balance == bookPrice);
Console.WriteLine(balance != bookPrice);
Console.WriteLine(balance <= bookPrice);
Console.WriteLine(balance >= bookPrice);
Console.WriteLine(balance > bookPrice);
