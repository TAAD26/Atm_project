﻿namespace Atm.Interfaces
{
    public interface IAccountRepository
    {
        string Transfer(string CustomerKey, string ToAccountNo, float amount);
    }
}
