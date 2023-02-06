using System.Data.SqlTypes;

namespace FinalProjectCSharp2
{
    public class Singelton<T> 
    {
        private static Singelton<T> instance;

        public static Singelton<T> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singelton<T>();
                }

                return instance;
            }
        }

        public Singelton()
        {

        }
    }
}
