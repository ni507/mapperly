﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    partial void Map(global::A source, global::B dest)
    {
        dest.SetValue(source.GetValue());
    }
}
    
[global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
static file class UnsafeAccessor
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.UnsafeAccessor(global::System.Runtime.CompilerServices.UnsafeAccessorKind.Method, Name = "get_value")]
    public static extern int GetValue(this global::A source);

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.UnsafeAccessor(global::System.Runtime.CompilerServices.UnsafeAccessorKind.Method, Name = "set_value")]
    public static extern void SetValue(this global::B target, int value);
}