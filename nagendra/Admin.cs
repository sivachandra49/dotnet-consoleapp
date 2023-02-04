using System.Text.RegularExpressions;
namespace Productdetails
{
    public class Admin
    {
        public static void Addproduct()
        {
            while (true)
            {
                Console.WriteLine("Choose one option\n 1:Add a product\n 2:Delete a product \n 3:Exit");
                string? option = Console.ReadLine();
                int flag = 0;
                switch (option)
                {
                    case "1":
                        Console.WriteLine("please add a product");
                        Newproduct();
                        break;
                    case "2":
                        Console.WriteLine("please delete a product");
                        Deleteproduct();
                        break;
                    case "3":
                        Console.WriteLine("Thank You");
                        flag = 1;
                        break;
                    default:
                        Console.WriteLine("CHOOSE VALID INPUT");
                        break;
                }
                if (flag == 1)
                {
                    break;
                }
            }
        }
            public static void Newproduct()
            {
                //product id will be automatically inserted
                string? productname = Methodtogetproductname();
                Console.WriteLine(productname);
                double price=methodtogetprice();
                Console.WriteLine(price);
                int quantity=methodtogetquantity();
                Console.WriteLine(quantity);
                int rating=methodtogetrating();
                var insertion=new Insertion();
                insertion.Productinsert(productname,price,quantity,rating);
            }
            public static void Deleteproduct()
            {

            }

            public static string Methodtogetproductname()
            {
                var regex=new Regex(@"^[0-9A-Za-z]+$");
                Console.WriteLine("Please enter valid product name");
                string? productname=Console.ReadLine();
                try{
                if(regex.IsMatch(productname)){
                    return productname;
                }
                else{
                    throw new ItemNameInvalidException();
                }
                }
                catch(ItemNameInvalidException e){
                     string pname=e.MyException();
                     return pname;
                }
            }
            public static double methodtogetprice(){
                Console.WriteLine("please enter valid price name");
                try{
                    double price=Convert.ToDouble(Console.ReadLine());
                    if(price<0){
                        throw new PriceNegativeException();
                    }
                    else{
                        return price;
                    }
                }
                catch(PriceNegativeException e){
                    double productprice=e.MyException();
                    return productprice;
                }
                catch{
                    Console.WriteLine("price should be a number");
                    return methodtogetprice();
                }
            }
            public static Int32 methodtogetquantity(){
                Console.WriteLine("please enter valid quantity");
                try{
                    int quantity=Convert.ToInt32(Console.ReadLine());
                    if(quantity<0){
                        throw new QuantityNegativeException();
                    }
                    else{
                        return quantity;
                    }
                }
                catch(QuantityNegativeException e){
                    int quant=e.MyException();
                    return quant;
                }
                catch{
                    Console.WriteLine("quantity should be a number");
                    return methodtogetquantity();
                }
            }

            public static Int32 methodtogetrating(){
                Console.WriteLine("please enter valid rating");
                try{
                    int rating=Convert.ToInt32(Console.ReadLine());
                    if(rating<=0 || rating>5){
                        return methodtogetrating();
                    }
                    else{
                        return rating;
                    }
                }
                catch{
                    Console.WriteLine("quantity should be a number");
                    return methodtogetrating();
                }
            }
        
    }
}