class Program
{
    //create a method, where we can put our modifier 'PARAMS'
    static void Foo(params object[] parameters)
    {
        string message = "Data type {0}, value {1}";

        //extract each element into a separate variable
        foreach (var item in parameters)
        {
            Console.WriteLine(message, item.GetType(), item);
        }
    }

    static void Main(string[] args)
    {
        Foo("love", 10, 'i', 5, 45f, false);
    }
}
//output
//Data type System.String, value love
//Data type System.Int32, value 10
//Data type System.Char, value i
//Data type System.Int32, value 5
//Data type System.Single, value 45
//Data type System.Boolean, value False