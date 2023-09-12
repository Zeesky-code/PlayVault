using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PlayVaultWeb.Helpers
{
    public static class EnumHelper
    {
        private static SelectList EnumToSelectList(Type enumType)
        {
            var values = Enum.GetValues(enumType);
            var items = values.Cast<object>().Select(value => new SelectListItem
            {
                Text = Enum.GetName(enumType, value),
                Value = value.ToString()
            }).ToList();

            return new SelectList(items, "Value", "Text");
        }
        public static IHtmlContent EnumDropDownListFor<TModel, TEnum>(
        this IHtmlHelper<TModel> htmlHelper,
        Expression<Func<TModel, TEnum>> expression,
        object htmlAttributes = null)
        {
            var modelExplorer = htmlHelper.NameFor(expression);
            var enumType = typeof(TEnum);

            if (!enumType.IsEnum)
            {
                throw new ArgumentException("TEnum must be an enum type.");
            }

            var selectList = EnumToSelectList(enumType);
            return htmlHelper.DropDownListFor(expression, selectList, htmlAttributes);
        }
    }
}
