//available previously for built-in types
using MyConsole = System.Console;

//now also available for tuples, pointers, arrays etc except nullables
using Doctor = (int id, string name);

namespace DotNet8._0
{
    public class AliasAnyTypes
    {
        public static void AliasAnyTypesDemo()
        {
            //earlier
            MyConsole.WriteLine("Test console");

            //new
            Doctor doctor1 = new (1,"doctor1");

            MyConsole.WriteLine("Details: "+ doctor1);

        }

        //can be passed as a parameter in methods too
        public static void AliasAnyTypesDemo2(Doctor doctor)
        {
            MyConsole.WriteLine("Details: " + doctor);

        }

    }
}
