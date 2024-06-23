using ASPClientLib.Interfaces;

namespace ASPClientLib.Classes;

public class ActionResult : IActionResult;

public class ActionResult<T>(T value)
{
    public T Value { get; } = value;
}