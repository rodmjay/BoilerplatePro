﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace BoilerplatePro.Base.Common.Extensions
{
    public static class ObjectExtensions
    {
        public static string ToQueryString(this object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            var properties = obj.GetType().GetProperties();
            var keyValuePairs = properties.Select(property =>
            {
                var key = Uri.EscapeDataString(property.Name);
                var value = Uri.EscapeDataString(property.GetValue(obj)?.ToString() ?? "");
                return $"{key}={value}";
            });

            return string.Join("&", keyValuePairs);
        }
        public static string GetLogMessage<T>(string message, [CallerMemberName] string callerName = null)
        {
            return $"[{nameof(T)}.{callerName}] - {message}";
        }

        public static string GetLogMessage<T>(this T inputType, string message,
            [CallerMemberName] string callerName = null)
        {
            return GetLogMessage<T>(message, callerName);
        }

        public static string ToJson<T>(this T source)
        {
            return JsonConvert.SerializeObject(source);
        }

        public static string ToJson<T>(this T source, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(source, settings);
        }

        public static int GetQuarter(this DateTime dateTime)
        {
            return (int)Math.Ceiling(dateTime.Month / 3.0);
        }
    }
}