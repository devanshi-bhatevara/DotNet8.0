namespace DotNet8._0
{
    public class DefaultLambdaParameters
    {
        //can provide default values to lamba expressions
        public static void DefaultLambdaParametersDemo()
        {
            var demoLambdaMethod = (string username = "Default User") => Console.WriteLine($"Hi {username}");
            demoLambdaMethod();
            demoLambdaMethod("Demo user");
        }
    }
}
