using System.Reflection;

namespace TestNonPublicStaticOrInstanceMethod
{
    public static class CallNonPublicStaticOrInstanceMethodHelper
    {
        public static TResult? InvokePrivateMethodWithReturnType<TClass, TResult>(TClass testObject, string methodName, object[] parameters, Type[]? methodParamTypes = null)
        {
            if (testObject == null)
                throw new Exception("TestObject was null.");

            //shows that we want the non public, static, or instance methods.
            const BindingFlags flags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance;

            //gets the method, but we need the methodParamTypes so that we don't accidentally get an ambiguous method with different params.
            var methodInfo = methodParamTypes != null ?
                testObject.GetType().GetMethod(methodName, flags, null, methodParamTypes, null) :
                testObject.GetType().GetMethod(methodName, flags);
            if (methodInfo == null)
                throw new Exception("Unable to find method.");

            //invokes our method on our object with the parameters.
            var result = methodInfo.Invoke(testObject, parameters);

            //if it is a task, it won't resolve without forcing it to resolve, which means we won't get our exceptions.
            if (result is Task task)
                task.GetAwaiter().GetResult();

            return (TResult?)result;
        }
    }
}
