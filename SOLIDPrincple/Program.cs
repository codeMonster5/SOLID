using SOLIDPrincple.SOLID;
using SOLIDPrincple.SOLID.SingleResponsiblityPrinciple;
using System;

namespace SOLIDPrincple
{
    class Program
    {
        static void Main(string[] args)
        {
            //SRP
            //OpenAndClosedPrinciple.Validate obj1 = new OpenAndClosedPrinciple.Validate();
            //OpenAndClosedPrinciple.ISaveOrder[] saveOrder = new OpenAndClosedPrinciple.ISaveOrder[] {new OpenAndClosedPrinciple.SaveOrder(), new OpenAndClosedPrinciple.DBCacheOrder()};
            //OpenAndClosedPrinciple.SendNotifications sendNotifications =  new OpenAndClosedPrinciple.SendNotifications();
            //OpenAndClosedPrinciple.OrderProcessor obj = new OpenAndClosedPrinciple.OrderProcessor(obj1,saveOrder,sendNotifications);

            //obj.Process();
            Bird obj = new Bird();
            obj.Fly();
            OstrichBird bi = new OstrichBird();
            bi.Flying();
            Katbutar bi1 = new Katbutar();
            bi1.Fly();
            Console.WriteLine("");
        }
    }
}
