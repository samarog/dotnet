namespace HelloWord.Classes
{
    public enum EnumMonths // enums are essentially a way to give more friendly names to sets of numeric values.
                           // By default, the underlying type of each element in the enum is int, and the first enumerator has the value 0, 
                           // and the value of each successive enumerator is increased by 1.
                           // You can specify another integral numeric type by using a colon. For example: enum EnumMonths : byte
                           // You can also assign specific values to some or all of the enumerators. For example: January = 1, February = 2, etc.
                           // Enums improve code readability and maintainability by providing meaningful names for sets of related constants.
    {

        January,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July        // 6
    }
}

