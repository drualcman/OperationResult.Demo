namespace OperationResult.Entities;
public class Result<SuccessResultType, ErrorResultType> : Result<ErrorResultType>
{
    public SuccessResultType SuccessValue { get; private set; }
    public Result(SuccessResultType success)
    {
        SuccessValue = success;
    }

    public Result(ErrorResultType error) : base(error)
    {

    }

    public void HandleError(Action<SuccessResultType> onSuccess, Action<ErrorResultType> onError)
    {
        if(HasError)
        {
            onError(ErrorValue);
        }
        else
        {
            onSuccess(SuccessValue);
        }
    }
}
