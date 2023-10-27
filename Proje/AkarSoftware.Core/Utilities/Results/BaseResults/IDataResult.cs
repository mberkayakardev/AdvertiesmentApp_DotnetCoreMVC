namespace AkarSoftware.Core.Utilities.Results.BaseResults
{
    public interface IDataResult<T> : IResult 
    {
        public T Data { get; }
    }
}
