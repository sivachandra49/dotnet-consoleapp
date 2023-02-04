namespace Productdetails{
    public class program{
        public static void Main(){
            Console.WriteLine("WELCOME ..........");
            while(true){
                Console.WriteLine("Choose one option\n 1:Customer \n 2:Admin \n 3:Exit");
                string? option=Console.ReadLine();
                int flag=0;
                switch(option){
                    case "1":
                    Console.WriteLine("Welcome Customer......");
                    Customer.Viewproducts();
                    break;
                    case "2":
                    Console.WriteLine("Welcome Admin.......");
                    Admin.Addproduct();
                    break;
                    case "3":
                    Console.WriteLine("Thank You");
                    flag=1;
                    break;
                    default:
                    Console.WriteLine("CHOOSE VALID INPUT");
                    break;
                }
                if(flag==1){
                    break;
                }
            }
        }
    }
}