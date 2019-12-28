using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Today we are going to get familiar with generics in c#
            // We will start by creating a generic class and then look into how to use it

            // Create an instance of Propertylister and pass type Car as type parameter
            var carPropertyLister = new PropertyLister<Car>();
            
            // now we can retrieve a list of properties for type Car and display them in console

            var propertyNames = carPropertyLister.GetProperties();
            foreach(var propertyName in propertyNames)
            {
                Console.WriteLine(propertyName);
            }

            // As you can see in the console, properties of the type Car were listed
            // Similarly we can create another type and reuse PropertyLister to list its properties

            var driverPropertyLister = new PropertyLister<Driver>();
            var driverPropertyNames = driverPropertyLister.GetProperties();

            Console.WriteLine("---");

            foreach(var propertyName in driverPropertyNames)
            {
                Console.WriteLine(propertyName);
            }

            // Generics help us reuse code, in the next video we will look into real world application of generics and build a restful api client
            // Stay tuned!

            // all of the code that was written in this video can be found in github.com/QuietCodeOfficial
        }
    }
}
