﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Helpers;

namespace perfectTiming.Helpers
{
    public class RequestResult<T>
    {
        public Enums.RequestStatus Status { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
        public T Data { get; set; }
        public string Detail { get; set; }
    }
}
