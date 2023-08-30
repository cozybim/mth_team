using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MLU01_Library
{
    public class Rectangular
    {
        #region Properties
        private double _Width, _Height;

        public double Width { get => _Width; set => _Width = value; }
        public double Height { get => _Height; set => _Height = value; }

        #endregion

        public string _WriteLineRectangular()
        {
            string _RectanProfile = null;

            if (_Width != 0 && _Height != 0) 
            {
                _Width = Math.Abs(_Width);
                _Height = Math.Abs(_Height);
                if (_Width < _Height)
                {
                   double _Width1 = _Height;
                   double _Height1 = _Width;
                    _RectanProfile = string.Format("Rectangular profile width*height = {0}*{1} ", _Width1, _Height1);
                }
                else
                {
                    _RectanProfile = string.Format("Rectangular profile width*height = {0}*{1} ", _Width, _Height);
                }
            }
            else
            {
                _RectanProfile = "The width and height doesn't equal 0";
            }
            return _RectanProfile;
        }

        public bool _CheckTypeOfInputIsDouble(string _Input)
        {
            bool _Result = true;
            if (_Input != null)
            {
                try
                {
                    double _ConvertInput = Convert.ToDouble(_Input);
                }
                catch
                {
                    _Result = false;
                }
            }

            return _Result;
        }
    }
}
