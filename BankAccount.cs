using System;

namespace BankEn

public class BankAccount
{
	private double _balance = 0;
    public BankAccount(double amount)
    {
        _balance = amount;
    }
	public void Deposit(double deposit)
    {
        _balance += deposit = amount;
    }
	public double GetBalance()
    {
		return _balance;
    }
	
}
