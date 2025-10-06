namespace HelloWord.Interfaces
{
   interface IFuel // Interfaces can contain properties and methods, but not fields or constructors.
                    // An interface is a contract that a class can implement. Meanings that a class can agree to implement the members defined in the interface. 
                    // A class can implement multiple interfaces, but can only inherit from one base class.
                    // Interfaces are used to achieve polymorphism and to define common behavior for different classes.
                    // By convention, interface names start with the letter "I".
                    // Interfaces cannot be instantiated directly. They must be implemented by a class or struct.
                    // Members of an interface are public by default and cannot have access modifiers.
    {
        void Fuel(); // method signature, no body
    }
}
