﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Application.Core.Dtos
{
    public class BadOpResult:OpResult
    {
        public BadOpResult(string message) : base(OpResultStatus.Error, message) { }

        public BadOpResult(OpResultStatus status) : base(status) { }
    }
}
