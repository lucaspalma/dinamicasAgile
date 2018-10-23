using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace dinamicasAgile.Extensions
{
    public static class EnumExtensions
    {
        public static string DisplayName(this Enum item)
        {
            var type = item.GetType();
            var member = type.GetMember(item.ToString());
            DisplayAttribute displayName = (DisplayAttribute) member[0].GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault();

            if (displayName != null)
            {
                return displayName.Name;
            }

            return item.ToString();
        }
    }
}