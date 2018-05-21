using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            DateTime Start = new DateTime(2018, 1, 20);
            DateTime End = new DateTime(2018, 2, 20);
            scroll scroll1 = new scroll(1, "пиво", 10);
            //product product1 = new product(1, "Балтика", scroll1, 0.5, 70, "Балтика продакшн");
            //product1.info();
            List<TemporaryProduct> listproduct = new List<TemporaryProduct>();
            listproduct.Add(new TemporaryProduct(1, "Балтика", scroll1, 0.5,"Балтика продакшн", 70,  Start, End));
            foreach(TemporaryProduct ff in listproduct)
            {
                ff.info();
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
        
    }
}
