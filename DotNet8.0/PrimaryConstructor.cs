namespace DotNet8._0
{
    public class PrimaryConstructor(int id, string email, int age)
    {
        //readonly properties whose values would be received from ctor
        public int id => id;
        public string email => email;
        public int age => age;

        //we can create multiple ctors but we need to use this to always call the primary ctor

        public PrimaryConstructor(int id, string email) : this(id,email, 0) { }
        public PrimaryConstructor() : this(0,string.Empty) { }

    }
}
