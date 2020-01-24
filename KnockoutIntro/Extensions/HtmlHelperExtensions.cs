using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace KnockoutIntro.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static HtmlString HtmlConvertToJson(this HtmlHelper htmlHelper, object model)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };
            return new HtmlString(JsonConvert.SerializeObject(model, settings));
        }

    }
}
