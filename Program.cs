using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_PrimitiveTypes_Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var expressShippingMethod = ShippingMethod.Express;
            var registeredShippingMethod = ShippingMethod.RegisteredAirMail;
            var regularShippingMethod = ShippingMethod.RegularAirMail;

            Console.WriteLine((int) expressShippingMethod);
            Console.WriteLine((int) registeredShippingMethod);
            Console.WriteLine((int) regularShippingMethod);

            var shippingMethodId = 1;
            var typeOfShipping = (ShippingMethod) shippingMethodId;
            Console.WriteLine(typeOfShipping);
            Console.WriteLine(expressShippingMethod.ToString());

            var registeredShippingMethodName = "RegisteredAirMail";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), registeredShippingMethodName);


        }
    }
}
