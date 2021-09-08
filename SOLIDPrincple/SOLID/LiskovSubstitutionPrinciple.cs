using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrincple.SOLID
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("not Fly");
        }
    }

    public class FlyingBird : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Flying");
        }
    }

    public class Katbutar: FlyingBird
    {
        public  Katbutar()
        {
            this.Fly();
        }
    }

    public class OstrichBird :Bird
    {
        public void Flying()
        {
            base.Fly();
        }
    }
}
