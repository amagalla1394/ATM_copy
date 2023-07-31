using System;
public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;            
        this.lastName = lastName;
        this.balance = balance;
    }

    public string getNum()
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public string getFirstName()
    {
        return firstName;
    }
    public string getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }

    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }
    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    //Main method for running the ATM
    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());  //TryCatch can later be added here
            currentUser.setBalance(deposit);                    //Balance should display current + added
            Console.WriteLine("Thank you for your deposit. Your new balance is: " +  currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //check to make sure user has enough money
            if (currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("Insufficient balance: ");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Your transaction is complete. Thank you :");
            }
        }
    }

}