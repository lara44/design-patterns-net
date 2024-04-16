﻿using pattern_adapter.Interfaces;

namespace pattern_adapter.Services
{
    public class DaviplataMethod : IPaymentMethod
    {
        public void Pay(decimal value)
        {
            Console.WriteLine($"Pagando {value:C} en daviplata");
        }
    }
}
