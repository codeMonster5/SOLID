using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrincple.SOLID
{
    public interface ISaveOrder
    {
        void SaveOrder();
    }

    public interface IDeleteOrder
    {
        void DeleteOrder();
    }

    public interface IUpdateOrder
    {
        void UpdateOrder();
    }

    public class OrderSave : ISaveOrder,IUpdateOrder, IDeleteOrder
    {
        public void DeleteOrder()
        {
            throw new NotImplementedException();
        }

        public void SaveOrder()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }

    public class dbCacheOrder : ISaveOrder
    {
        public void SaveOrder()
        {
            throw new NotImplementedException();
        }
    }
}
