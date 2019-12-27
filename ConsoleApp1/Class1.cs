using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MyClass
    {
        private delegate void LogHandler(string message);

        private event LogHandler Log;

        public void process()
        {
            OnLog("process started");
            OnLog("process ended");
        }

        protected void OnLog(String message)
        {
            Log?.Invoke(message);
        }

        public void subscribeLog(Action<string> listener)
        {
            Log += new LogHandler(listener);
            
        }
    }


    public class Test
    {
        
        public static  void listener(String msh)
        {
            Console.WriteLine("test " + msh);
        }
        public static void Main2(String[] args)
        {
            var myClass = new MyClass();

            myClass.subscribeLog(listener);
         
            myClass.process();
        }
    }
}
