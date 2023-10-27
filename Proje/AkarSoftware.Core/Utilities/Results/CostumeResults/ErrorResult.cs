using AkarSoftware.Core.Utilities.Results.BaseResults;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {

        }

        public ErrorResult(string Messages) : base(false)
        {


        }
    }
}
   
