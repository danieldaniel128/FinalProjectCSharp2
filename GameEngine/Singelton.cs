using System.Data.SqlTypes;

namespace FinalProjectCSharp2
{
    public abstract class Singelton<T> where T : new()
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }
    }
}
