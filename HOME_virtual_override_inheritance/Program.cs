﻿using System;

namespace HOME_virtual_override_inheritance         // dynamic polymorphism
{
    class Program
    {
        class University 
        {
            protected int UiD;
            protected string UName;

            virtual public void Info()
            {
                Console.WriteLine("University ID = " + UiD);
                Console.WriteLine("University Name = " + UName);
            }
        }

        class Department : University       //   inheritance for overriding method
        {
            protected int DiD;
            protected string DName;
            public Department(int UiD,string UName, int DiD, string DName) 
            {
                base.UiD = UiD;
                base.UName = UName;
                this.DiD = DiD;
                this.DName = DName;
            }

            override public void Info()         //  must to use inheritance for overriding method
            {
                base.Info();
                Console.WriteLine("Department ID = " + DiD);
                Console.WriteLine("Department Name = " + DName);
            }
        }


        static void Main(string[] args)
        {
                                            //       אין צורך לקרוא למחלקה כי היא לבד לא מממשת כלום 

            //University uni = new University();     
            //uni.Info();                               

                                         //     כי לא ניתן לזהות בלי  , UNIVERSITY  חייב לשלוח פרטי  DEPARTMENT  במחלקה 

            Department dp = new Department(433, "californy", 11, "rttsddfhdfhdhdghd");   //    UiD, UName, DiD , DName
            dp.Info();
            Console.ReadKey();
        }

    }
}