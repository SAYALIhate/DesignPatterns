using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern1
{
    internal class Singleton
    {
        //Declare private static field
        private static Singleton instance;

        private static IConnectionMultiplexer conn;
        private static IDatabase db;

        //private constructor
        private Singleton()
        {
            conn = ConnectionMultiplexer.Connect("localhost");
        }

        // GetInstance method which will be accessed from the outside scope
        // will return instance always when invoked
        // if first time call create instance
        // else return  already created

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // an business logic method that needed
        public IDatabase getDatabaseObject()
        {
            return conn.GetDatabase();
        }
    }
}

