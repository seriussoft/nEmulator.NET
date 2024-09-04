using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.GDIPlus.Core;


/// <summary><br/><para>
/// This interface has a default implementation of the <see cref="IDisposable.Dispose"/> method AND<br/>
///   the <see cref="Dispose(bool)"/> method because the purpose of this interface/contract<br/>
///   has less to do with Disposing and more to do with ensuring you dispose your data<br/>
///   in a way that is best sooted for the kinds of objects holding onto lots of data <br/>
///   and/or unmanaged code with artifacts that tend to come with said territory...</para><para>
/// Do <b>NOT</b> implement your own versions unless you ABSOLUTELY know what you are doing.</para><para>
/// The <see cref="HasDisposed"/> and <see cref="HasTriggeredDispose"/> properties, also, do not<br/>
///   need anything special done to or with them, but are provided publicly to aid in any API that might<br/>
///   need to keep a watch on memory, Garbage-Collection, and/or know the state of all<br/>
///   things at all times (debugging, for instance).</para><para>
/// </para></summary>
/// <remarks><para>
/// <b>State Management</b>
/// <list type="bullet">
///   <item><see cref="HasTriggeredDispose"/></item>
///   <item><see cref="HasDisposed"/></item>
///   <item><see cref="ShouldCleanUpUnmanagedState"/></item>
/// </list>
/// <b>Methods with Default Implementation</b> - 
///   <i> ONLY implement if you know what you are doing (default implementations do exactly what is needed)</i>
/// <list type="bullet">
///   <item><see cref="IDisposable.Dispose"/></item>
///   <item><see cref="Dispose(bool)"/></item>
///   <item>---</item>
/// </list>
/// <b>Methods | Properties to Implement In Your Code</b>
/// <list type="bullet">
///   <item><see cref="DisposeManagedState"/></item>
///   <item><see cref="DisposeUnmanagedState"/></item>
///   <item><see cref="DeReferenceLargeFields"/></item>
/// </list>
/// </para></remarks>
public partial interface ISoCDisposable : IDisposable
{


  public bool ShouldCleanUpUnmanagedState { get; set; }
  public bool HasDisposed { get; protected set; }
  public bool HasTriggeredDispose { get; protected set; }

  /// <summary><para>
  /// When implemented, this method should dispose of any managed content 
  ///   (specifically, collections/ienumerables/lists/arrays/etc)<br/>
  /// This does NOT include anything unmanaged or that has specific unmanaged resources that ALSO
  ///   need disposing of.<br/>
  /// If your member implements IDisposable, now's the time to trigger those.<br/>
  /// Just be careful of the order you do that in - 
  ///   just in case you have other dependencies upon said member.<br/>
  /// </para></summary>
  /// <returns><inheritdoc cref="___DOCS.__DisposeManagedState_Returns" path="/summary/node()"/></returns>
  /// <remarks><inheritdoc cref="___DOCS.__DisposeManagedState_Remarks" path="/summary/node()"/></remarks>
  bool DisposeManagedState();

  /// <summary><para>
  /// In the event that your object has unmanaged memory, two things need to happen:<br/>
  ///   1. The object needs to be disposed of (cleaned up or let go of) ...<br/>
  ///   2. AND the object needs to be de-referenced (set the pointer or reference 
  ///     to the analog/equivalent of C++'s <see langword="nullptr"/><br/>
  /// What this does is tells the garbage-collector and memory indexer that both:<br/>
  ///   your object no longer needs to be kept/held-on-to,<br/>
  ///   and that those locations in memory are free to be erased, re-used, 
  ///   or w/e the computer wants/needs.</para><para>
  /// That all said, this method can be an empty implementation - unless you have unmanaged memory (or rss)
  ///   to deal with. In which case, you just need to clean that up here.<br/>
  /// You do NOT need to de-reference your objects here, just yet. There's a member method,
  ///   <see cref="DeReferenceLargeFields"/>, just for that.
  /// </para></summary>
  /// <returns><inheritdoc cref="___DOCS.__DisposeManagedState_Returns" path="/summary/node()"/></returns>
  /// <remarks><inheritdoc cref="___DOCS.__DisposeManagedState_Remarks" path="/summary/node()"/></remarks>
  bool DisposeUnmanagedState();

  /// <summary><para>
  /// When overridden, this will need to do one of two things.<br/>
  /// Do you have any large fields that need to be cleaned up, THEN, have the references removed<br/>
  ///     because the Garbage-Collector SERIOUSLY needs to clean up after your object?
  /// <list type="bullet">
  ///  <item>
  ///   <term>If YES </term> 
  ///   <description> Do Nothing ...</description>
  ///  </item>
  ///  <item>
  ///   <term>If NO </term> 
  ///   <description> De-Reference aforementioned member(s) ...</description>
  ///  </item>
  /// </list>
  /// </para></summary>
  /// <returns><inheritdoc cref="___DOCS.__DisposeManagedState_Returns" path="/summary/node()"/></returns>
  /// <remarks><inheritdoc cref="___DOCS.__DisposeManagedState_Remarks" path="/summary/node()"/></remarks>
  bool DeReferenceLargeFields();

  /// <summary><para>
  /// When overridden, this method should essentially JUST do the following:
  /// <code>~TheNameOfMyClassOrStruct();</code></para><para>
  /// Most likely, this will be completely unecessary to perform (except in the case of
  ///   having enough unmanaged memory space that it IS necessary, in which case, you'll need
  ///   to do as mentioned above.</para><para>
  /// In the event you are NOT working with unmanaged rss (resources), just have your implementation
  ///   of this method do and return nothing.
  /// </para></summary>
  /// <returns></returns>
  bool DeconstructSelf();

  
}



