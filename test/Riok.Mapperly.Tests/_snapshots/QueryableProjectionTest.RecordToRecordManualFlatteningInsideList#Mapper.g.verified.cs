//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private partial global::System.Linq.IQueryable<global::B> Map(global::System.Linq.IQueryable<global::A> source)
    {
#nullable disable
        return System.Linq.Queryable.Select(source, x => new global::B(x.Id.ToString(), global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(x.Values, x1 => Map(x1)))));
#nullable enable
    }
}