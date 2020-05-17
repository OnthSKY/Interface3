using System;
// Seneryo Sirketin verilerini hem sql server hemde oracle veri tabainina yazmak istiyoruz .
namespace Interface3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerDal(),
                new JavaServerDal(),
                new CServerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Update();
            }
        }
    }
}
