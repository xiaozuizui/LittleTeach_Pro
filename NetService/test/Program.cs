using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceCore.Net;
using System.Threading;
using ServiceCore.Base;

namespace test
{
    class Program
    {
        static TeachNet tn;
        static string test;
        static void  Main(string[] args)
        {
            tn = new TeachNet("201585081", "19970401");

            GetInfo gt = new GetInfo();
            gt.Analysis();
            //Test();
            //Thread.Sleep(6000);


        }
        static async Task Test()
        {
            tn.Initialize();
            
            test =  await tn.ConnectAsync();
            SaveToDataBase sv = new SaveToDataBase(test);
            sv.SaveTodb();
           
        }

       


    }

    

}
