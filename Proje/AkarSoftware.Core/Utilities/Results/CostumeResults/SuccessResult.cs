using AkarSoftware.Core.Utilities.Results.BaseResults;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
            
        }

        public SuccessResult() : base(true)
        {

        }
    }
}
