using System;
using System.Collections.Generic;

namespace NetSimpleScheduler
{
    public static class SampleData
    {
        public static List<CustomerModel> Populate()
        {
            var customers = new List<CustomerModel>();

            customers.Add(new CustomerModel()
            {
                Id = Guid.NewGuid(),
                Name = "John",
                Email = "john@example.com",
                ScheduleDate = DateTime.Now.AddMinutes(1)
            });
            customers.Add(new CustomerModel()
            {
                Id = Guid.NewGuid(),
                Name = "Anna",
                Email = "anna@example.com",
                ScheduleDate = DateTime.Now.AddMinutes(2)
            });
            customers.Add(new CustomerModel()
            {
                Id = Guid.NewGuid(),
                Name = "Alex",
                Email = "alex@example.com",
                ScheduleDate = DateTime.Now.AddMinutes(3)
            });

            return customers;
        }
    }
}