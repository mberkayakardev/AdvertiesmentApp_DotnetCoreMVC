namespace AkarSoftware.Core.Utilities.Results.BaseResults
{
    public interface IResult
    {
        public bool Success { get; }
        public string Messages { get; }
    }
}
