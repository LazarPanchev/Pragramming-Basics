using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAKE
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int allPieces = cakeWidth * cakeLenght / 1 * 1;
            int piecesNeeded = 0;
            while (piecesNeeded <= cakeWidth * cakeLenght)
            {
                string pieces = Console.ReadLine();

                if (pieces == "STOP")
                {
                    break;
                }
                piecesNeeded += int.Parse(pieces);
                allPieces -= int.Parse(pieces);
                if (pieces.Equals("STOP"))
                {
                    break;
                }
            }
            if (piecesNeeded > cakeWidth * cakeLenght)
            {
                Console.WriteLine($"No more cake left! You need {piecesNeeded - cakeWidth * cakeLenght} pieces more.");
            }
            else
            {
                Console.WriteLine($"{allPieces} pieces are left.");
            }
        }
    }
}
