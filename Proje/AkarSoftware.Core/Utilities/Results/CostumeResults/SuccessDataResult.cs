using AkarSoftware.Core.Utilities.Results.BaseResults;

namespace AkarSoftware.Core.Utilities.Results.CostumeResults
{
    public class SuccessDataResult<T> : DataResult<T> 
    {
        public SuccessDataResult(T data, string Messages) : base(data, true, Messages)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {
        }



    }
}
