using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args) {

            string cell1 = "A1";
            string cell2 = "C3";
            Console.WriteLine("First Cell = A1");
            Console.WriteLine("Second Cell = C3");

            bool result1 = CompareTwoCell(cell1, cell2);

            string cell3 = "A1";
            string cell4 = "H3";
            Console.WriteLine("First Cell = A1");
            Console.WriteLine("Second Cell = H3");

            bool result2 = CompareTwoCell(cell3, cell4);
            
            Console.WriteLine("First Result=" + result1);
            Console.WriteLine("Second Result=" + result2);
            Console.ReadLine();
        }
        
        public static bool CompareTwoCell(string cell1, string cell2)
        {
            int[] line = { 1, 2, 3, 4, 5, 6, 7, 8 };            
            string [] column ={ "A", "B", "C", "D", "E", "F", "G", "H"};           

            int cell1Index = Array.IndexOf(column, cell1.Substring(0,1))+1;
            int cell2Index = Array.IndexOf(column, cell2.Substring(0, 1))+1;

            int cell1Line = Array.IndexOf(line, cell1.Substring(1, 1)) + 1;
            int cell2Line = Array.IndexOf(line, cell2.Substring(1, 1)) + 1;
            
            int cell1Color = 0;
            int cell2Color = 0;

            for (int i = 0; i < line.Length; i++)            
                for (int j = 0; j < column.Length; j++)
                {
                    if(cell1Index == j)
                    {
                        if(cell1Line == i)                        
                            if ((cell1Index + i) % 2 == 0)
                                cell1Color = 0;   // Yellow..
                            else cell1Color = 1;   // Brown..                     
                    }
                    if (cell2Index == j)
                    {
                        if (cell2Line == i)                        
                            if ((cell2Index + i) % 2 == 0)   // mod two
                                cell2Color = 0;   
                            else cell2Color = 1;  
                    }                   
                }            
            return cell1Color == cell2Color ? true : false;            
        }       
    }
}
