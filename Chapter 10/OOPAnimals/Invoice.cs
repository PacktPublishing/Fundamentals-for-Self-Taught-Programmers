public class Invoice

{

    private int _invoiceId; public Animal Pet { get; }
    public string OwnerName { get; }
    public double Balance { get; private set; }
    private string DefaultPaymentMethod { get; }
    public int InvoiceId
    {
        get { return _invoiceId; }
    }

    public Invoice(Animal pet, int invoiceID)
    {
        //Private code that validates invoice ID 
        //If invoice exists in database...  
        //it sets each property. 
        _invoiceId = invoiceID;

    }

    public void MakePayment(double paymentAmount)
    {

        bool transactionSuccessful = Calculate(paymentAmount);

        if (transactionSuccessful)
        {
            UpdateBalance(paymentAmount);
        }
    }
    private bool Calculate(double amount)
    {
        //Code that makes some calculations...

        //Code sets success variable to true or false 
        bool success = true;
        return success;
    }

    private bool Calculate(int amount)
    {
        //Code that makes some calculations...

        //Code sets success variable to true or false 
        bool success = true;
        return success;
    }

    private void UpdateBalance(double amount)
    {
        Balance = Balance + amount;
    }
}