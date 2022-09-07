namespace ExpressionToCodeLib.Internal;

[Obsolete]
sealed class ObjectStringifyImpl : IObjectStringifier
{
    internal readonly bool UseFullyQualifiedTypeNames;

    public ObjectStringifyImpl(bool useFullyQualifiedTypeNames = false)
        => UseFullyQualifiedTypeNames = useFullyQualifiedTypeNames;

    [Obsolete]
    public string TypeNameToCode(Type type)
        => ObjectToCodeImpl.TypeNameToCode(ExpressionToCodeConfiguration.GlobalCodeGenConfiguration with { UseFullyQualifiedTypeNames = UseFullyQualifiedTypeNames, }, type);

    [Obsolete]
    public string? PlainObjectToCode(object? val, Type? type)
        => ObjectToCodeImpl.PlainObjectToCode(new ExpressionToCodeConfiguration { UseFullyQualifiedTypeNames = UseFullyQualifiedTypeNames, }, val, type);
}
