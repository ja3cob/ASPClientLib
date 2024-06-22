namespace ASPClientLib.Attributes;

public class RouteAttribute(string template) : Attribute
{
    public string Template { get; } = template;
}

public class RouteApiControllerAttribute(string? template = null) : RouteAttribute("api/[controller]/" + template);