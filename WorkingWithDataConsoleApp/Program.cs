using System;
using System.Collections.Generic;
using ContainerLibrary.Classes;
using DataLibrary.Classes;

List<CustomerEntity> customerEntities = Operations.ReadCustomers();

foreach (var customerEntity in customerEntities)
{
    Console.WriteLine($"{customerEntity.Display} ");
}

Console.ReadLine();