using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webuilder.Helpers
{
    internal static class ComponentErrorHelper
    {
        const int LOVER_GRID_OR_WIDTH = 1;

        const int UPPER_GRID = 12;

        static public void CheckGrid(int grid)
        {
            CheckOutOfRange(grid, LOVER_GRID_OR_WIDTH, UPPER_GRID, 
                            $"Value of grid component out of range ({LOVER_GRID_OR_WIDTH},{UPPER_GRID})!");
        }

        static public void CheckWidth(int width, int grid)
        {
            CheckOutOfRange(width, LOVER_GRID_OR_WIDTH, grid,
                            $"Value of width component out of range ({LOVER_GRID_OR_WIDTH}, grid = {UPPER_GRID})!");
        }

        static public void CheckForNull(object item, string itemName)
        {
            if (item == null)
            {
                throw new ArgumentNullException(itemName);
            }
        }

        static void CheckOutOfRange(int value, int lower, int upper, string massage)
        {
            if (value < lower || value > upper)
            {

                throw new ArgumentOutOfRangeException(nameof(value), value, massage);
            }
        }
    }
}
