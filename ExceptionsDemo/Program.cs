namespace ExceptionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=10, b=0, result = 0;
            int[] arr = { 10, 0 };
            try
            {
                result = a / arr[1];
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
            }
            catch (IndexOutOfRangeException ir)
            {
                Console.WriteLine(ir.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("result:"+result);
            Console.WriteLine("Program Executed Successfull!");
        }
    }
}
