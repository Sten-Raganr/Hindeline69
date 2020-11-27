using System;

namespace Hindeline69
{
    class Program
    {
        class cat
        {
            string name;
            string color;
            double hungry;

            public cat(string _color,string _name)
            {
                name = _name;
                color = _color;
                hungry = 0;

            }
            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public void ChangeName(string newName)
            {
                name = newName;
            }
            public double Hungry
            {
                get { return hungry; }
            }

            public void Changecolor(string newcolor)
            {
                color = newcolor;
            }
            public void Sleeping ()
            {
                hungry += 0.2;
            } 
            public void CatDetails()
            {
                Console.WriteLine($"Name:{name}\nColor:{color}\ncat hunger:{ hungry}.");
            }

        }
        static void Main(string[] args)
        {
            cat newcat = new cat("black","miisu");
            newcat.CatDetails();
            Console.WriteLine("if u want change name or color Type(.)");
            string userinput = Console.ReadLine();

            if (userinput == ".")
            {
                Console.Write("New name:");
                string newcatname= Console.ReadLine();
                newcat.ChangeName(newcatname);
                Console.Write("New Color:");
                string Newcatcolor = Console.ReadLine();
                newcat.Changecolor(Newcatcolor);
                
            }
            else
            {
                Console.WriteLine("okey we keep name:miisu and color:black");

            }
            newcat.CatDetails();
            Console.WriteLine("cat went to sleeps");
            while(newcat.Hungry != 1)
            {
                newcat.Sleeping();
            }
            newcat.CatDetails();
            Console.WriteLine("cat wakes up and says: moew");

        }
    }
}
