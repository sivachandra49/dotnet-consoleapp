namespace Productdetails
{
    public class Customer
    {
        public static void Viewproducts()
        {
            while (true)
            {
                Console.WriteLine("Choose one option \n 1:view product based on pid \n 2:view all products \n default:exit");
                var option = Console.ReadLine();
                int flag = 0;
                switch (option)
                {
                    case "1":
                        Viewproductbasedonpid();
                        break;
                    case "2":
                        Viewallproducts();
                        break;
                    default:
                        flag = 1;
                        break;

                }
                if (flag == 1)
                {
                    break;
                }
            }
        }
        static void Viewproductbasedonpid()
        {
            Console.WriteLine("please enter productid");
            var eneteredpid = Console.ReadLine();
            var alllines = File.ReadLines("product.txt").ToArray();
            var foundflag = 0;
            var count = 0;
            foreach (var item in alllines)
            {
                string newpid = item.Substring(5, item.Length - 5);
                if (item.Substring(0, 3) == "PID" && newpid == eneteredpid)
                {
                    Console.WriteLine("Product found....!");
                    Console.WriteLine(item);
                    foundflag = 1;
                    continue;
                }
                if (foundflag == 1 && count < 5)
                {
                    count++;
                    Console.WriteLine(item);
                }
            }
            if (foundflag == 0)
            {
                Console.WriteLine("No item is found with given product id");
            }
        }
        static void Viewallproducts()
        {
            var alllines = File.ReadLines("product.txt");
            foreach (var item in alllines)
            {
                Console.WriteLine(item);
            }
        }
    }
}