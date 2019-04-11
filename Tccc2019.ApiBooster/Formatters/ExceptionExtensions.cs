using System;
using System.Collections.Generic;

namespace Tccc2019.ApiBooster.Formatters
{
    public static class ExceptionExtensions
    {
        public static CustomError ToCustomError(this Exception ex)
        {
            var customError = new CustomError
            {
                ExceptionType = ex.GetType().Name,
                StackTrace = ex.StackTrace,
                Message = ex.Message.Replace("\r\n", "   "),
                Data = new List<CustomDictEntry>()
            };

            var ts = ex.TargetSite;
            if (ts != null)
            {
                customError.ModuleName = ts.Module.Name;
                customError.DeclaringTypeName = ts.DeclaringType?.Name;
                customError.TargetSiteName = ts.Name;
            }

            foreach (var dataKey in ex.Data.Keys)
            {
                if (ex.Data[dataKey] != null)
                {
                    customError.Data.Add(new CustomDictEntry
                    {
                        Key = dataKey.ToString(),
                        Value = ex.Data[dataKey]?.ToString()
                    });
                }
            }

            if (ex.InnerException != null)
                customError.InnerError = ex.InnerException.ToCustomError();

            return customError;
        }

        public static string InnermostMessage(this Exception e)
        {
            while (true)
            {
                if (e.InnerException == null) return e.Message.Replace("\r\n", "   ");
                e = e.InnerException;
            }
        }
    }
}
