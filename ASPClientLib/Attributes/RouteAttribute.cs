using System;

namespace ASPClientLib.Attributes
{
    public class RouteAttribute : Attribute
    {
        public string Template { get; }

        public RouteAttribute(string template)
        {
            Template = template;
        }
    }

    public class RouteApiControllerAttribute : RouteAttribute
    {
        public RouteApiControllerAttribute(string? template = null) : base("api/[controller]/" + template) { }
    }
}