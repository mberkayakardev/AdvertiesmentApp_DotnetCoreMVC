using AkarSoftware.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Core.Utilities.Results.CostumeResults;

namespace AkarSoftware.Core.Utilities.Results.BaseResults
{
    public class Result : IResult
    {
        public string Messages { get; }
        public ResultStatus Status { get; }
        public IEnumerable<ValidatonErrorResult> ValidationErrors { get; }

        public Result(ResultStatus status, string StatusMessages, IEnumerable<ValidatonErrorResult> Errors) : this(status, StatusMessages)
        {
            ValidationErrors = Errors;
        }

        public Result(ResultStatus status, string StatusMessages) : this(status)
        {
            this.Messages = StatusMessages;
        }

        public Result(ResultStatus status)
        {
            this.Status = status;
        }

        public Result (ResultStatus status, IEnumerable<ValidatonErrorResult> Errors) : this (status, string.Empty, Errors) 
        {

        }
    }
}
