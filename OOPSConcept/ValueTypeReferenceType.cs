using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    /* Points to Remember
     * https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/data-types/value-types-and-reference-types
     * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value-types
     * Value Types :
     *      1. A data type is a value type if it holds the data within its own memory allocation.
     *      2. Below all are Value types
     *              i. All numeric data types
     *              ii. Boolean, Char, and Date
     *              iii. Enumerations, since their underlying type is always SByte, Short, Integer, Long, Byte, UShort, UInteger, or ULong
     *              iv. All structures, even if their members are reference types
     *                      Every structure is a value type, even if it contains reference type members. 
     *                      For this reason, value types such as Char and Integer are implemented by .NET Framework structures
     *       3. Each value type has an implicit default constructor that initializes the default value of that type.
     *       4. value type cannot contain the null value.
     *       5. However, the nullable types feature does allow for value types to be assigned to null
     *       
     * Reference Types :
     *       1. A reference type contains a pointer to another memory location that holds the data.
     *       2. Reference types include the following:
     *              i. String
                    ii. All arrays, even if their elements are value types
                    iii. Class types, such as Form
     *       3. A class is a reference type. For this reason, reference types such as Object and String are supported by .NET Framework classes.
     *          Note that every array is a reference type, even if its members are value types.

Delegates
     */
    class ValueTypeReferenceType
    {

        
    }
}
