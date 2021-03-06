﻿using System;

namespace Ucoin.Framework.Web.Activator
{
    // Same as PreApplicationStartMethodAttribute, but for methods to be called after App_Start
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class PostApplicationStartMethodAttribute : BaseActivationMethodAttribute
    {
        public PostApplicationStartMethodAttribute(Type type, string methodName)
            : base(type, methodName)
        {
        }
    }
}
