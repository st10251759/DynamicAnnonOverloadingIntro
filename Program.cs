namespace DynamicAnonType_Overloading
{//Simple app to show how dynamic, anonymous type & operator overloading
    //Dynamic Type: uses keyword 'dynamic'
    //Syntax: dynamic variableName = value

    internal class Program
    {//Program Class
        static void Main(string[] args)
        {//Main
            //Declare a dynamic variable & assign a string value 'Hello'
            dynamic variable = "Hello";

            //output the above
            Console.WriteLine(variable);

            //change the value of the dynamic variable to an integer 5
            variable = 5;
            
            //output the above
            Console.WriteLine(variable);

            //Anonymous Types: these are immutable, properties are read-only
            //Syntax: var anonObject = new{Property1 = value1, Property2 = value2};
              

            //Declare an anonymous type ith properties Name & Age; assign values to it
            var person = new { Name = "Joe", Age = 30 };

            //output the value of the Name property of the anonymous type: Joe
            Console.WriteLine(person.Name);

            //output the value of the Name property of the anonymous type: 30
            Console.WriteLine(person.Age);

            //Operator Overloading : Define / redefine the behaviour of operators for user defined types
            //Syntax: public static returnType operator OperatorSymbol (parameter List) {methidbody}
            //Create two instances of the Point class with specified values for X & Y
            var point1 = new Point(1, 2);
            var point2 = new Point(2, 3);

            //Add the aboce 2 instances using overload + operator
            var result = point1 + point2;
            Console.WriteLine($"({result.X}, {result.Y})");  


        }//Main
    }//Program Class
}//namespace end
