using System;

namespace SOLIDPrincple.SOLID.SingleResponsiblityPrinciple
{
    public class OrderProcessor
    {
        // ready only property
        public readonly Validate validate;

        public readonly SaveOrder saveOrder;
        public readonly SendNotifications sendNotifications;
        // validation

        // save the order

        // send the notifications

        public OrderProcessor()
        {
        }

        public OrderProcessor(Validate validate, SaveOrder saveOrder, SendNotifications sendNotifications)
        {
            this.validate = validate;
            this.sendNotifications = sendNotifications;
            this.saveOrder = saveOrder;
        }

        // Process the order
        public void Process()
        {
            this.validate.ValidationCheck("Validation Processes");
        }
    }

    // Validate
    public class Validate
    {
        public Validate()
        {
        }

        public Validate(string obj)
        {
            Console.WriteLine(obj);
        }

        public void ValidationCheck(string obj)
        {
            Console.WriteLine(obj);
        }
    }

    // Save the Order

    public class SaveOrder
    {
        public SaveOrder()
        {
        }

        public SaveOrder(string obj)
        {
            Console.WriteLine(obj);
        }
    }

    // Send the Notifications

    public class SendNotifications
    {
        private SendNotifications()
        {
        }

        public SendNotifications(string Obj)
        {
            Console.WriteLine(Obj);
        }
    }


}