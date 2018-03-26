using System;
using System.Collections.Generic;

namespace Version_2_C
{
    
    sealed class clsNameComparer : IComparer<clsWork>
    {
        public static readonly clsNameComparer Instance = new clsNameComparer();

        private clsNameComparer(){}
        public int Compare(clsWork x, clsWork y)
        {
            //string lcNameX = x.Name;
            //string lcNameY = y.Name;

            //return lcNameX.CompareTo(lcNameY);
            return x.Name.CompareTo(y.Name);
        }
    }
}
