public class Method
{
    public string MethodName;
    public List<Parameter> Parameters;
    public string ReturnType;
    public string Body;

    public override string ToString()
    {
        var methodDefinition = $"public {ReturnType} {MethodName}({this.ParametersToString()})\n";
        var methodBody = $"{{\n{Body}\n}}";
        return $"{methodDefinition}{methodBody}";
    }

    private string ParametersToString()
    {
        return String.Join(',', this.Parameters.Select(p => p.ToString()));
    }
}