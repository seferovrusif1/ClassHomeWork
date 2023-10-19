using Class_HomeWork;

namespace Class_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write User Name");         // Taskda istenilen username pasword fieldi ve login logout methoduna numune
            string userName = Console.ReadLine();         // 
            Console.WriteLine("Write password");
            string password = Console.ReadLine();
            User x000 = new User(userName, password);
            string status = "in";
            while (status == "in" || status == "out")
            {
                Console.WriteLine("Type 'in' to Login\nType 'out' to Logout ");
                status = Console.ReadLine();

                if (status == "in")
                {
                    x000.Login();
                }
                else if (status == "out")
                {
                    x000.Logout();
                }

            }









            ////// taskin daha murekkeb versiyasi
            //////3 ayri obyekt var her birine ayri username pasword qoyuruq login ederken pasword username objectid yoxlanilir
           //////logout ederken ise objectid ni duz yazmaqimiz kifayetdir
           //////sintaksisi bildiyim qederiyle yazmaqa calisdiqim ucun kod tekrari olur bezen





            //Console.WriteLine("Write User Name + Enter + Write password for 3 users");   
            //User x000 = new User(Console.ReadLine(), Console.ReadLine());
            //User x001 = new User(Console.ReadLine(), Console.ReadLine());
            //User x002 = new User(Console.ReadLine(), Console.ReadLine());

            //string objectId;
            //string userName;
            //string password;
            //string status = "in";
            //bool loginInfo = false;

            //while (status == "in" || status == "out")
            //{
            //    Console.WriteLine("Type 'in' to Login\nType 'out' to Logout ");
            //    status = Console.ReadLine();

            //    if (status == "in" && loginInfo == false)
            //    {
            //        Console.WriteLine("Write User Name");
            //        userName = Console.ReadLine();
            //        Console.WriteLine("Write password");
            //        password = Console.ReadLine();
            //        Console.WriteLine("Write Object ID(0-1-2 ci id lerde obyekt var)");
            //        objectId = Console.ReadLine();
            //        switch (objectId)
            //        {
            //            case "0":
            //                if (x000.UserName == userName && x000.Pasword == password)
            //                {
            //                    x000.Login();
            //                    loginInfo = true;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Wrong info");
            //                }
            //                break;
            //            case "1":
            //                if (x001.UserName == userName && x001.Pasword == password)
            //                {
            //                    x001.Login();
            //                    loginInfo = true;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Wrong info");
            //                }
            //                break;
            //            case "2":
            //                if (x002.UserName == userName && x002.Pasword == password)
            //                {
            //                    x002.Login();
            //                    loginInfo = true;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Wrong info");
            //                }
            //                break;
            //        }
            //    }
            //    else if (status == "in" && loginInfo == true)
            //    {
            //        Console.WriteLine("istifadəçi öncədən hesaba daxil olub");
            //    }
            //    else if (status == "out")
            //    {
            //        Console.WriteLine("Write Object ID");
            //        objectId = Console.ReadLine();
            //        switch (objectId)
            //        {
            //            case "0":
            //                x000.Logout();
            //                loginInfo = false;
            //                break;
            //            case "1":
            //                x001.Logout();
            //                loginInfo = false;
            //                break;
            //            case "2":
            //                x002.Logout();
            //                loginInfo = false;
            //                break;
            //        }
            //    }
            //}
        }
    }
}


