using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace littlemm.teach.Base
{
    public struct Section
    {
        public uint start { get; set; }
        public uint end { get; set; }
        public uint wk { get; set; }
        public uint jc { get; set; }
        public uint number { get; set; }
        public string room { get; set; }
    }

    public class DATA_Student
    {
        public string Name { get; set; }

        public string Id { get; set; }

        // public List<Class> Classes { get; set; }
        public List<DATA_Class> Classes { get; set; }

    }

    public class APP_Student
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public List<APP_Class> N_Classes { get; set; }

    }

    public class DATA_Class
    {
        // private bool IsClass { get; set; }
        public string id { get; set; }
        public string ClassName { get; set; }
        public int section { get; set; }

        public string ClassInfo { get; set; }
        public string Teacher { get; set; }

        //private uint 
    }

    public class APP_Class
    {
        int section;
        public string id { get; set; }
        public string ClassName { get; set; }
        public string Teacher { get; set; }

        public Section[] ClassSection;

        public APP_Class(int s)
        {
            section = s;
            ClassSection = new Section[s];
        }

    }
}
