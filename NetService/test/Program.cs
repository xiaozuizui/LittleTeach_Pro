using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceCore.Net;
using System.Threading;

namespace test
{
    class Program
    {
        static TeachNet tn;
        static string test;
        static void  Main(string[] args)
        {
            tn = new TeachNet("201585081", "19970401");


            Test();
            Thread.Sleep(3000);


        }
        static async Task Test()
        {
            tn.Initialize();
            
            test =  await tn.ConnectAsync();
           
        }

       


    }

    

}
