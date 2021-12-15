using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace LINQ_Intersect_and_Except_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] IBM_grp = { "James", "Tc-12", "Lopatcho", "Ap-z02" };
            string[] Microsoft_grp = { "Bill", "James", "Anna", "Tc-12" };

            // Merge the two groups in One group .

            var Concat_grp = IBM_grp.Intersect(Microsoft_grp);

            // Intersect(); used for find the share items or duplicate items .
            // Except(); used for find items exist in grp1 & does not exist in grp2 .

            // Concat(); for Adding the grp to another and print the total data .
            // Distinct(); Do not show duplicate items .
            // Union(); place of using the Concat and Distinct Methods use the Union Method . var Concat_grp = IBM_grp.Union(Microsoft_grp);

            foreach (var item in Concat_grp)
                Console.WriteLine(item);
        }
    }
}
