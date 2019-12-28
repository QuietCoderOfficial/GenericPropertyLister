using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    // This class will list properties of a type that we pass in as a generic parameter
    // <T> represents the type parameter of a generic class
    // In this particular example its important to note that we want to only accept reference types(class, interface etc.) as our type parameters, not value types(int, decimal etc.)
    // In order to set those restrictions, we need to state that T is a class
    // you may also specify that T inherits a specific class in similar way
    public class PropertyLister<T> where T: class
    {
        public IEnumerable<string> GetProperties()
        {
            // First lets retrieve a list of properties and then select their names

            var properties = typeof(T).GetProperties(); // Using reflection we retrieved a list of properties from type T
            return properties.Select(property => property.Name); // Using linq we retrieved a name from each property object
        }
    }
}