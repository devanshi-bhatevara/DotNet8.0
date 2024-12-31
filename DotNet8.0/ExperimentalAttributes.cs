using System.Diagnostics.CodeAnalysis;

namespace DotNet8._0
{
    public class ExperimentalAttributes
    {
        //attribute can be used on classes as well as methods
        [Experimental(diagnosticId: "d001")]
        public static void ExperimentalAttributeDemo()
        {
            Console.WriteLine("It is an experimental method not to used in actual implementation yet");
        }
        
        public static void NonExperimentalAttributeDemo()
        {
            Console.WriteLine("This method can be used");
        }
    }
}
