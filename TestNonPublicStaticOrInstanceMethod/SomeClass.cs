namespace TestNonPublicStaticOrInstanceMethod
{
    public class SomeClass
    {
        private readonly string _welcome;
        public SomeClass()
        {
            _welcome = "Welcome";
        }
        private async Task SomePrivateTaskAsync(string firstName, string lastNme)
        {
            await Task.Run(() => Console.WriteLine($"{_welcome} {firstName} {lastNme}! I'm {nameof(SomePrivateTaskAsync)}"));
        }
        private Task SomePrivateTask(string firstName, string lastNme)
        {
            Console.WriteLine($"{_welcome} {firstName} {lastNme}! I'm {nameof(SomePrivateTask)}");
            return Task.CompletedTask;
        }
        private string SomePrivateMethod(string firstName, string lastNme)
        {
            return $"{_welcome} {firstName} {lastNme}! I'm {nameof(SomePrivateMethod)}";
        }
        private static string SomePrivateStaticMethod(string firstName, string lastNme)
        {
            return $"{firstName} {lastNme}! I'm {nameof(SomePrivateStaticMethod)}";
        }
    }
}
