using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Converters
{
    public static class EnumConverter
    {
        public static TDest ConvertTo<TSource,TDest>(this TSource source)
        {
            try
            {
                return (TDest)Enum.Parse(typeof(TDest), source.ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
                throw e;
            }
           
        }
    }
}
