using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TemporaryProduct : scroll
    {
        public DateTime StartSelling
        { get; set; }
        public DateTime EndSelling
        { get; set; }
        public TemporaryProduct(int scrollID,string scrollName, double scrollStrength, 
            DateTime StartSelling, DateTime EndSelling) : 
            base (scrollID, scrollName, scrollStrength)
        {
            this.StartSelling = StartSelling;
            this.EndSelling = EndSelling;
        }
        public override void info()
        {
            base.info();
            Console.WriteLine("Дата поступления в продажу: {0}", StartSelling);
            Console.WriteLine("Дата конца продажи: {0}", EndSelling);
        }

            
    }
}
