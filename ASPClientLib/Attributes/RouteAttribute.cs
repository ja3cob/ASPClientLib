namespace ASPClientLib.Attributes;

public class RouteAttribute(string template) : Attribute;
public class RouteApiControllerAttribute(string? template = null) : RouteAttribute("api/[controller]/" + template);