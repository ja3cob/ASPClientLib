﻿using ASPClientLib.Interfaces;

namespace ASPClientLib.Classes
{
    public class ActionResult : IActionResult { }

    public class ActionResult<T>
    {
        public T Value { get; }

        public ActionResult(T value)
        {
            Value = value;
        }
    }
}