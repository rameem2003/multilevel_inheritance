using System;

namespace multilevel_inheritance
{
    class grand_father
    {
        public string grand_fa_name = "Abul Hossain.";
    }

    class father: grand_father
    {
        public string father_name = "A N M Mudassir Hossain.";
    }


    class me : father
    {
        public string my_name = "Mahmood Hassan Rameem.";
    }


    class app
    {
        public static void Main()
        {
            me obj = new me();

            Console.WriteLine("Grand father name is: " + obj.grand_fa_name);
            Console.WriteLine("Father name is: " + obj.father_name);
            Console.WriteLine("My name is: " + obj.my_name + " Thank you");
        }
    }
}