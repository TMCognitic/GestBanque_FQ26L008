namespace Models.Exceptions;

internal class SoldeInsuffisantException : ArgumentOutOfRangeException
{
    public SoldeInsuffisantException()
    {
    }

    public SoldeInsuffisantException(string? paramName, string? message) : base(paramName, message)
    {
    }
}
