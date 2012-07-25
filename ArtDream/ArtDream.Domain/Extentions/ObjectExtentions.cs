using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtDream.Domain.Extentions
{
    public static class ObjectExtentions
    {

        public static int? ToInt32(this object obj)
        {
            if (obj == null)
            {
                return null;
            }
            try
            {
                return Convert.ToInt32(obj);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int ToInt32(this object obj, int defaultValue)
        {
            if (obj == null)
            {
                return defaultValue;
            }
            try
            {
                return Convert.ToInt32(obj);
            }
            catch (Exception ex)
            {
                return defaultValue;
            }
        }

        public static int? ToInt16(this object obj)
        {
            if (obj == null)
            {
                return null;
            }
            try
            {
                return Convert.ToInt16(obj);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int ToInt16(this object obj, short defaultValue)
        {
            if (obj == null)
            {
                return defaultValue;
            }
            try
            {
                return Convert.ToInt16(obj);
            }
            catch (Exception ex)
            {
                return defaultValue;
            }
        }

        public static int ToByte(this object obj, short defaultValue)
        {
            if (obj == null)
            {
                return defaultValue;
            }
            try
            {
                return Convert.ToByte(obj);
            }
            catch (Exception ex)
            {
                return defaultValue;
            }
        }

        public static decimal? ToDecimal(this object obj)
        {
            if (obj == null)
            {
                return null;
            }
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static double? ToDouble(this object obj)
        {
            if (obj == null)
            {
                return null;
            }
            try
            {
                return Convert.ToDouble(obj);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static decimal ToDecimal(this object obj, decimal defaultValue)
        {
            if (obj == null)
            {
                return defaultValue;
            }
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch (Exception ex)
            {
                return defaultValue;
            }
        }

        public static DateTime ToDateTime(this object obj, DateTime defaultValue)
        {
            if (obj == null)
            {
                return defaultValue;
            }
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch (Exception ex)
            {
                return defaultValue;
            }
        }

        public static string NegativeToParenthesize(this object obj)
        {
            var tempObj = obj.ToString();

            var chrAry = tempObj.ToCharArray();
            if (chrAry.Any())
            {
                if (chrAry[0] == '-')
                {
                    tempObj = tempObj.Remove(0, 1);
                    return string.Format("({0})", tempObj);
                }
            }
            return tempObj;
        }

    }
}
