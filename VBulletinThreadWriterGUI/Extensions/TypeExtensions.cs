#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace VBulletinThreadWriterGUI.Extensions
{
    public static class TypeExtensions
    {
        //public static IEnumerable<DependencyProperty> GetDependencyProperties(this Type type, bool includeBaseDependencyProperties)
        //{
        //    var properties = type.GetFields(BindingFlags.Static | BindingFlags.Public)
        //                         .Where(f => f.FieldType == typeof(DependencyProperty));
            
        //    if (type.BaseType != null && includeBaseDependencyProperties)
        //        properties = properties.Union(type.BaseType.GetDependencyProperties(false));
            
        //    return properties;
        //}

        public static DependencyProperty? GetDependencyProperty(
            this object dependencyObject, 
            string dependencyPropertyName)
        {
            FieldInfo? fi = dependencyObject.GetType().GetMember(dependencyPropertyName,
                MemberTypes.All, BindingFlags.Public | BindingFlags.Static)[0] as FieldInfo;
            
            if(fi == null)
            {
                throw new Exception($"No Property found by the name of '{dependencyPropertyName}' in Type '{dependencyObject.GetType()}'. ");
            }

            DependencyProperty? dp = fi.GetValue(dependencyObject) as DependencyProperty;

            return dp;
        }
    }
}
