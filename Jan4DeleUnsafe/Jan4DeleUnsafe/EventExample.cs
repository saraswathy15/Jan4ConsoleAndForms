using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan4DeleUnsafe
{
    public class EventExample
    {//step1 
        public delegate string MyDel(string str);// declare delegate method
        public EventExample()
        {//step4
            this.MyFirstEvent += new MyDel(this.Welcome);
        }
        event MyDel MyFirstEvent;//assign it to event step2
        public string Welcome(string Name)
        {//step3
            return "Welcome     " + Name;
        }
        static void Main(string[] args)
        {//step 5 
            EventExample ee = new EventExample();
            string res = ee.MyFirstEvent("Charu");
            Console.WriteLine(res);
        }
    }
}
