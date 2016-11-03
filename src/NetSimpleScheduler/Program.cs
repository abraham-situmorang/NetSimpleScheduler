using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NetSimpleScheduler
{
    class Program
    {
        private static List<CustomerModel> ListCustomer = SampleData.Populate();
        private static bool isProgress = false;

        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now + ": NetSimpleScheduler running services...");

            //realtime check duration 1mins
            Timer t = new Timer(TimerCallback, null, 0, 60000 * 1);
            Console.ReadLine();
        }

        private static void TimerCallback(Object o)
        {
            try
            {
                if (isProgress) return;
                    isProgress = true;

                var getCustomers = ListCustomer.Where(x => !x.IsSent &&
                                    x.ScheduleDate <= DateTime.Now)
                                    .ToList();

                foreach (var item in getCustomers)
                {
                    new SendEmail().Send("Subject", "Hello " + item.Name, item.Email);
                    item.IsSent = true;
                }

                GC.Collect();
                isProgress = false;
            }
            catch (Exception ex)
            {
                isProgress = false;
                Console.WriteLine(ex.Message);
            }
        }
    }
}