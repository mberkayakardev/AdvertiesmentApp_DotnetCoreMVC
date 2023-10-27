using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace AkarSoftware.Core.Utilities.Results.BaseResults
{
    public class Result : IResult
    {
        public bool Success { get; }
        public string Messages { get; }

        public Result(bool Success, string StatusMessages) : this(Success)
        {
            this.Messages = StatusMessages;
        }

        public Result(bool Success)
        {
            this.Success = Success;
        }
    }
}
