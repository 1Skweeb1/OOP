using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public interface IFigure
    {
        double Area { get; }
        public string GetInfo();
        double this[int index] { get; }
    }
}
