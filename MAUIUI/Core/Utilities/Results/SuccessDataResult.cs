using MAUIUI.Core.Utilities.Results;
namespace MAUIUI.Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
{
    public SuccessDataResult(T data, bool success, string message) : base(data, success, message)
    {
    }
    public SuccessDataResult(T data, bool success) : base(data, success)
    {
    }
    public SuccessDataResult(T data) : base(data, true)
    {
    }
    public SuccessDataResult() : base(default, true)
    {
        }

    }

}

