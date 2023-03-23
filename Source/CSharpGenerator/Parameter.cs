public class Parameter
{
    public string ParameterType;
    public string ParameterName;

    public override string ToString()
    {
        return $"{ParameterType} {ParameterName}";
    }
}