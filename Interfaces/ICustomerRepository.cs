﻿namespace Atm.Interfaces
{
    public interface ICustomerRepository
    {
        string Login(string userId, string password);
    }
}
