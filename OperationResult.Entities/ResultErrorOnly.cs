namespace OperationResult.Entities;
public class Result<ErrorResultType>
{
    public ErrorResultType ErrorValue { get; private set; }
    public bool HasError { get; private set; }
    public Result(ErrorResultType error)
    {
        ErrorValue = error;
        HasError = true;
    }
    public Result()
    {
        HasError = false;
    }
    public void HandleError(Action<ErrorResultType> onError, Action onSuccess = null)
    {
        if(HasError) onError.Invoke(ErrorValue);
        else onSuccess?.Invoke();
    }
}
