namespace nEmulator.Graphics.GDIPlus.Core;

public abstract partial class BaseGraphicalObject
  : IGraphicalObject, InDisposable
{
  public virtual string? Name { get; set; }
  public virtual Guid ID { get; set; }

  /// <summary>
  /// 
  /// 
  /// 
  /// <para>
  /// The public, empty/default cstr is offered ONLY for use with Serialization/Deserialization
  /// </para></summary>
  public BaseGraphicalObject() : this(null, null)
  {

  }

  public BaseGraphicalObject(string? name, Guid? id)
  {

  }

  

  

}

