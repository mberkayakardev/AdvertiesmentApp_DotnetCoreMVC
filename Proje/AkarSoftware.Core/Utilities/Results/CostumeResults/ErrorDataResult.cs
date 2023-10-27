using AkarSoftware.Core.Utilities.Results.BaseResults;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(string Message) : base(default, false, Message)
        {

        }

        public ErrorDataResult(T data, string Message) : base(data, false, Message)
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }
    }
}
