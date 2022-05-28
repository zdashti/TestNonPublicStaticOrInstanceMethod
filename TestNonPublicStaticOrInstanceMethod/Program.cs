namespace TestNonPublicStaticOrInstanceMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            var resultPrivateMethodWithReturnType =
                CallNonPublicStaticOrInstanceMethodHelper.InvokePrivateMethodWithReturnType<SomeClass, Task>
                 (new SomeClass(), "SomePrivateTaskAsync", new object[] { "book", "cook" }, new Type[] { typeof(string), typeof(string) });
            Console.WriteLine(resultPrivateMethodWithReturnType);
            Console.WriteLine();

            var resultSomePrivateTask =
                CallNonPublicStaticOrInstanceMethodHelper.InvokePrivateMethodWithReturnType<SomeClass, Task>
                    (new SomeClass(), "SomePrivateTask", new object[] { "book", "cook" }, new Type[] { typeof(string), typeof(string) });
            Console.WriteLine(resultSomePrivateTask);
            Console.WriteLine();

            var resultSomePrivateMethod =
                CallNonPublicStaticOrInstanceMethodHelper.InvokePrivateMethodWithReturnType<SomeClass, string>
                    (new SomeClass(), "SomePrivateMethod", new object[] { "book", "cook" }, new Type[] { typeof(string), typeof(string) });
            Console.WriteLine(resultSomePrivateMethod);
            Console.WriteLine();

            var resultSomePrivateStaticMethod =
                CallNonPublicStaticOrInstanceMethodHelper.InvokePrivateMethodWithReturnType<SomeClass, string>
                    (new SomeClass(), "SomePrivateStaticMethod", new object[] { "book", "cook" }, new Type[] { typeof(string), typeof(string) });
            Console.WriteLine(resultSomePrivateStaticMethod);

            Console.ReadLine();
        }
    }
}