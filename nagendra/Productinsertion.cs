namespace Productdetails{
    public class Insertion{
        public void Productinsert(string productname,Double price,Int32 quantity){
          Console.WriteLine(productname);
          Console.WriteLine(price);
          Console.WriteLine(quantity);
          StreamWriter sw=new StreamWriter("product.txt");

        }
    }
}