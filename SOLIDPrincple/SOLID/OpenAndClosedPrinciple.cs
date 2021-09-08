using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrincple.SOLID.SingleResponsiblityPrinciple
{
    public class OpenAndClosedPrinciple
    {
        public class OrderProcessor
        {
            // ready only property
            public readonly Validate validate;

            public readonly ISaveOrder[] saveOrder;
            public readonly SendNotifications sendNotifications;
            // validation

            // save the order

            // send the notifications

            public OrderProcessor()
            {
            }

            public OrderProcessor(Validate validate, ISaveOrder[] saveOrder, SendNotifications sendNotifications)
            {
                this.validate = validate;
                this.sendNotifications = sendNotifications;

                this.saveOrder = saveOrder;
                
            }

            // Process the order
            public void Process()
            {
                this.validate.ValidationCheck("Validation Processes");

                foreach (var item in saveOrder)
                {
                    item.SaveOrder(null);
                }
            }
        }

        // Validate
        public class Validate
        {
          

            public void ValidationCheck(string obj)
            {
                Console.WriteLine(obj);
            }
        }

        // Save the Order

        // Open and Closed Principle

        public interface ISaveOrder
        {
           public void SaveOrder(string obj);
        }

        // this class open for extension but closed for modification
        public class SaveOrder: ISaveOrder
        {
            
            public SaveOrder()
            {

            }

            void ISaveOrder.SaveOrder(string obj)
            {
                Console.WriteLine("Iorder");
            }
        }


        // cache order class

        public class DBCacheOrder : ISaveOrder
        {
            public DBCacheOrder()
            {
            }

            public void Name()
            {
                Console.WriteLine("IorderDbMani");
            }
            public void SaveOrder(string obj)
            {
                Console.WriteLine("IorderDb");
            }
        }

        // Send the Notifications

        public class SendNotifications
        {
        
        }
    }
}
