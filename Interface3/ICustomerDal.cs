using System;
using System.Collections.Generic;
using System.Text;

namespace Interface3
{
    interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();
    }

    class SqlServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class JavaServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Java Added");
        }

        public void Delete()
        {
            Console.WriteLine("Java Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Java Updated");
        }
    }
    class CServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("C# Added");
        }

        public void Delete()
        {
            Console.WriteLine("C# Deleted");
        }

        public void Update()
        {
            Console.WriteLine("C# Updated");
        }
    }
}
