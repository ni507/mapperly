﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private partial global::System.Collections.Generic.Stack<int> Map(global::System.ReadOnlyMemory<int> source)
    {
        return MapToStack(source.Span);
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private global::System.Collections.Generic.Stack<int> MapToStack(global::System.ReadOnlySpan<int> source)
    {
        var target = new global::System.Collections.Generic.Stack<int>();
        target.EnsureCapacity(source.Length + target.Count);
        foreach (var item in source)
        {
            target.Push(item);
        }
        return target;
    }
}