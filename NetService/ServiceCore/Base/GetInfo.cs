using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceCore.Model;
using Microsoft.EntityFrameworkCore;

namespace ServiceCore.Base
{
    class GetInfo
    {
        //public Student student;
        DATA_Student stu;

        List<DATA_Class> Classes;

        public List<APP_Class> N_Classes;

        public GetInfo()
        {
            N_Classes = new List<APP_Class>();
            using (var db = new DB())
            {
               stu = db.Students.Include(stud => stud.Classes).First();
            }

            //Classes = stu.Classes;
        }

        public void Analysis()
        {
            DATA_Class[] cl = Classes.ToArray();
            for (int x = 0; x < cl.Length; x++)
            {
                APP_Class n_cl = new APP_Class(cl[x].section);


                n_cl.ClassName = cl[x].ClassName;
                n_cl.id = cl[x].id;
                n_cl.Teacher = cl[x].Teacher;


                char[] info;
                if (cl[x].ClassInfo != null)
                    info = cl[x].ClassInfo.ToCharArray();
                else
                {
                    N_Classes.Add(n_cl);
                    continue;
                }

                int section = cl[x].section;
                //Section[] s = new Section[section];
                int k1 = 0;
                int k2 = 0;
                for (int i = 0; i < section; i++)
                {
                    int m, n;

                    m = cl[x].ClassInfo.IndexOf("-", k1);
                    n = cl[x].ClassInfo.IndexOf("#", k1);

                    if (m != -1 && m < n)
                    {
                        k2 = m;
                        n_cl.ClassSection[i].start = Convert.ToUInt16(new String(info, k1, k2 - k1));
                        k1 = k2 + 1;
                        k2 = cl[x].ClassInfo.IndexOf("#", k2 + 1);
                        n_cl.ClassSection[i].end = Convert.ToUInt16(new String(info, k1, k2 - k1 - 2));
                    }
                    else
                    {
                        n_cl.ClassSection[i].start = n_cl.ClassSection[i].end = Convert.ToUInt16(new String(info, k1, n - k1 - 2));
                        k2 = n;
                    }

                    k1 = k2 + 1;
                    k2 = cl[x].ClassInfo.IndexOf("#", k2 + 1);
                    n_cl.ClassSection[i].wk = Convert.ToUInt16(new String(info, k1, k2 - k1));
                    k1 = k2 + 1;
                    k2 = cl[x].ClassInfo.IndexOf("#", k2 + 1);
                    n_cl.ClassSection[i].jc = Convert.ToUInt16(new String(info, k1, k2 - k1));
                    k1 = k2 + 1;
                    k2 = cl[x].ClassInfo.IndexOf("#", k2 + 1);
                    n_cl.ClassSection[i].number = Convert.ToUInt16(new String(info, k1, k2 - k1));
                    k1 = k2 + 1;
                    k2 = cl[x].ClassInfo.IndexOf("#", k2 + 1);
                    n_cl.ClassSection[i].room = new String(info, k1, k2 - k1);
                    k1 = k2 + 1;
                    k2 = cl[x].ClassInfo.IndexOf("#", k2 + 1);
                    n_cl.ClassSection[i].room += new String(info, k1, k2 - k1);
                    k1 = k2 + 1;
                    k2 = cl[x].ClassInfo.IndexOf("#", k2 + 1);
                    n_cl.ClassSection[i].room += new String(info, k1, k2 - k1);

                    k1 = k2 + 1;
                }

                N_Classes.Add(n_cl);
            }

            //App.stu.Id = stu.Id;
            //App.stu.Name = stu.Name;
            //App.stu.N_Classes = N_Classes;
        }

    }
}
