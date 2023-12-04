using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HeadOffice : Handler
    {
        public override void HandleRequest(int amount)
        {
            if (amount > 50000)
            {
                Console.WriteLine($"{this.GetType().Name} handles the loan request for {amount:C}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(amount);
            }
            else
            {
                Console.WriteLine("Loan request cannot be handled.");
            }
        }
    }
}
