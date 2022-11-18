decimal balance = 75.45M; 
decimal groceries = 40.00M; 
decimal tea = 5.00M; 
string balanceMessage = "The current balance is: $";

PrintBalance();
CalculateNewBalance(groceries);
PrintBalance();
CalculateNewBalance(tea);
PrintBalance();

decimal bookPrice = 25;
bool canAffordBook = VerifyAffordable(bookPrice);

if (canAffordBook)
{
    Console.WriteLine("You can afford to buy the book!");
    CalculateNewBalance(bookPrice);
}
else
{
    Console.WriteLine("You can't afford the book!");
}

PrintBalance();


void PrintBalance()
{
    Console.WriteLine(balanceMessage + balance);
}

void CalculateNewBalance(decimal expense)
{
    balance -= expense;
}

bool VerifyAffordable(decimal cost)
{
    bool canAfford = balance > cost;

    return canAfford;
}

for (int i = 1; i <= 10; i++) {
     Console.WriteLine(i);
}

int j = 1;
while (j <= 10)
{     
    Console.WriteLine(j);
    j++;
}