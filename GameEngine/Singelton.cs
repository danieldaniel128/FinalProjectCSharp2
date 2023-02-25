using System.Data.SqlTypes;

namespace FinalProjectCSharp2
{
    /// <summary>
    /// This singelton is used to create a one instance for specific objects
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
