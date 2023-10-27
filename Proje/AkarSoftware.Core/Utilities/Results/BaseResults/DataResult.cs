namespace AkarSoftware.Core.Utilities.Results.BaseResults
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string Messages) : base(success, Messages)
        {

        }

        public DataResult(T data, bool Success) : base(Success)
        {
        }

        public T Data { get; }

    }
}
