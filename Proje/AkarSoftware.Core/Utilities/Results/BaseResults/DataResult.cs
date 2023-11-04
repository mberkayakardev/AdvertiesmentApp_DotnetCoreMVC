using AkarSoftware.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Core.Utilities.Results.BaseResults
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, ResultStatus status, string Messages) : base(status, Messages)
        {

        }

        public DataResult(T data, ResultStatus status ) : base(status)
        {
        }

        public T Data { get; }

    }
}
