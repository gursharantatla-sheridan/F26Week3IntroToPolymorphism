namespace F26Week3IntroToPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BaseClass objBase;
            objBase = new BaseClass();
            objBase.Show();

            //DerivedClass objDerived = new DerivedClass();
            //objDerived.Show();

            objBase = new DerivedClass();
            objBase.Show();

            //objDerived = new BaseClass();



            //int x = 5;
            //Add(3, 4, out x);
            //Add(3, 4);
            //Add("hello", "world");

            //Add(4, 5);

            //Add(3, 4);

            //int[] a = { 3, 4, 5 };
            //PrintArray(a);
            ////PrintArray(2, 3, 4, 5, 6);
        }

        static void PrintArray(int[] arr)
        {
            // method body
        }

        //static void PrintArray(params int[] arr)
        //{
        //    // method body
        //}

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        //static void Add(int n1, int n2)
        //{
        //    // method body
        //}

        static string Add(string n1, string n2)
        {
            return n1 + n2;
        }

        static int Add(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        static void Add(int n1, int n2, out int n3)
        {
            n3 = n1 + n2;
        }

        
    }
}
