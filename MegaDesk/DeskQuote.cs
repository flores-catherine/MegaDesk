using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        #region member variables
        //desk quote description
        private string CustomerName;
        private DateTime QuoteDate;
        private Desk Desk = new Desk();
        

        #endregion

        #region constants
        private const int PRICE_BASE = 200;
        private const int BASE_SURFACE_AREA_PRICE = 1;
        private const int PRICE_PER_DRAWER = 50;

        #endregion

        public DeskQuote(int width, int depth, int numberDrawers, string surfaceMaterial, int rushDays)
        {
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberDrawers = numberDrawers;
            Desk.SurfaceMaterial = surfaceMaterial;
            Desk.RushDays = rushDays;
        }

        //public int CalculateQuote()
        //{
        //    return PRICE_BASE + SurfaceAreaCost() + DrawerCost() + MaterialCost() + rushCost();
        //}

        //public int SurfaceAreaCost(int width, int depth, int BASE_SURFACE_AREA_PRICE)
        //{

        //}
    }
}
