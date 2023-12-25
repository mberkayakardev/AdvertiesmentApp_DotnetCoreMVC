using AkarSoftware.Core.Extentions.FluentValidation.ComplexType;
using AkarSoftware.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Core.Utilities.Results.CostumeResults;

namespace AkarSoftware.Core.Utilities.Results.BaseResults
{
    public interface IResult
    {
        public ResultStatus Status { get; }
        public string Messages { get; }
        public IEnumerable<ErrorModel> ValidationErrors { get; }
    }
}

