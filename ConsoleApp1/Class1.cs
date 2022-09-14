//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class StopWatch
//    {
//        public bool Flag { get; set; }
//        public TimeSpan Starts { get; set; } 
//        public TimeSpan Finish { get; set; }
//        public TimeSpan Result { get; set; }
  

//        public StopWatch()
//        {
//            Flag = false;
//        }

//        public void Start()
//        {
//            if(Flag == false)
//            {
//                this.Starts = new TimeSpan(DateTime.Now.Ticks);
//            }
//            else
//            {
//                Console.WriteLine("Error not twice");
//            }
//        }

//        public void Stop()
//        {
//            this.Finish = new TimeSpan(DateTime.Now.Ticks);
//        }

//        public void Calculate()
//        {
//            this.Result = this.Finish - this.Starts;
//        }
//    }
//}
