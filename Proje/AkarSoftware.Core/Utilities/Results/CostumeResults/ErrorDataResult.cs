﻿using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class ErrorResult<T> : DataResult<T>
    {
        public ErrorResult(T data) : base(data, ResultStatus.Error)
        {

        }

        public ErrorResult(T data, string Messages) : base(data,ResultStatus.Error, Messages)
        {


        }
    }
}

