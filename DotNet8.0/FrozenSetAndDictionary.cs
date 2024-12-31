using System.Collections.Frozen;

namespace DotNet8._0
{
    public class FrozenSetAndDictionary
    {
        public static void FrozenSetAndDictionaryDemo()
        {
            //Immutable is like string 
            //so frozen is introduced
            //takes more creation time but less access and iteration time

            FrozenSet<int> fs = Enumerable.Range(0,10).ToFrozenSet();

            FrozenDictionary<int, int> fd = Enumerable.Range(0, 10).ToFrozenDictionary(key => key);

            

        }
    }
}
