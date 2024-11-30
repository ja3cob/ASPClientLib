using System;

namespace ASPClientLib.Attributes
{
    public class HttpMethodAttribute : Attribute { }

    public class HttpGetAttribute : HttpMethodAttribute { }
    public class HttpPostAttribute : HttpMethodAttribute { }
    public class HttpPutAttribute : HttpMethodAttribute { }
    public class HttpDeleteAttribute : HttpMethodAttribute { }
    public class HttpPatchAttribute : HttpMethodAttribute { }
}