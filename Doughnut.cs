using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiselenco_Ruxandra_Lab2
{
    class Doughnut
    {
        private DoughnutType mFlavor;
        private int mRaisedGlazed = 0;
        private int mRaisedSugar = 0;
        private int mFilledLemon = 0;
        private int mFilledChocolate = 0;
        private int mFilledVanilla = 0;
        private double Total = 0;
        private DoughnutType selectedDoughnut;
        public DoughnutType Flavor
        {
            get
            {
                return mFlavor;
            }
            set
            {
                mFlavor = value;
            }
        }
        private float mPrice;
        public float Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public Doughnut(DoughnutType aFlavor) // constructor
        {
            mFlavor = aFlavor;
        }
    }
    public enum DoughnutType
    {
        Glazed,
        Sugar,
        Lemon,
        Chocolate,
        Vanilla
    }
}
