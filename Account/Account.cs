namespace Account;

public class Account
{
    private float _balance;
    public string Owner { get; }

    public float Balance
    {
        get { return _balance; }
        set
        {
            if (value >= 0)
            {
                _balance = value;
            }
        }
    }

    public Account(float balance, string owner)
    {
        this._balance = balance;
        this.Owner = owner;
    }
    public void Show()
    {
        Console.WriteLine($"The balance for {Owner} is {_balance}.");
    }
    public void Deposit(float depositAmount)
    {
        _balance += depositAmount;
    }
    public float GetBalance()
    {
        return _balance;
    }
    public bool Withdraw(float withdrawAmount)
    {
        if (_balance - withdrawAmount >= 0)
        {
            _balance -= withdrawAmount;
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool Transfer(Account toAccount, float transferAmount)
    {
        if (Withdraw(transferAmount))
        {
            toAccount.Deposit(transferAmount);
            return true;
        }
        else
        {
            return false;
        }
    }
}