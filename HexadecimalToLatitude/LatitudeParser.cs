using System;
using System.Globalization;

namespace HexadecimalToLatitude
{
    public class LatitudeParser
    {
        public float HexadecimalLatitude { get; set; }

        public LatitudeParser(string hexadecimalLatitude)
        {
            HexadecimalLatitude = ConverteHexadecimalLatitude(hexadecimalLatitude);
        }

        private static float ConverteHexadecimalLatitude(string hexadecimalLatitude)
        {
            try
            {
                return Int32.Parse(hexadecimalLatitude, NumberStyles.HexNumber);
            }
            catch (InvalidCastException e)
            {
                throw new InvalidCastException(e.Message);
            }
        }

        public int GetGraus()
        {
            return (int)HexadecimalLatitude / (500 * 60 * 60);
        }

        public float GetMinutos()
        {
            return HexadecimalLatitude / (500 * 60) - GetGraus() * 60;
        }

        public string GetLatitude()
        {
            return string.Format("{0}°{1}'", GetGraus(), GetMinutos());
        }

        public override string ToString()
        {
            return GetLatitude();
        }
    }
}