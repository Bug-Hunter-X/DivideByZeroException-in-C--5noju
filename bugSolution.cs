public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        int y = 0;
        int z = 0;
        try
        {
            z = x / y;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"DivideByZeroException caught: {ex.Message}");
            // Handle the exception appropriately, e.g., set a default value
            z = int.MaxValue; 
        }
        Console.WriteLine(z); // Output: 2147483647
    }
}