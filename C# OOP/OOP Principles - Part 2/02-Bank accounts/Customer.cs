
namespace Bank_accounts
{
   public class Customer
    {
        public string Name { get; set; }
       public Customer(string name)
       {
           this.Name = name;
       }

       public override string ToString()
       {
           return string.Empty + this.Name;
       }
    }
}
