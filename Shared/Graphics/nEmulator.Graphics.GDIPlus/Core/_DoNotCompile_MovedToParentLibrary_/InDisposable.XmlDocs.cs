using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.GDIPlus.Core;

/// <summary><para>
/// Implement this interface for the best support, implementation, and 
///   separation of concerns in regards to Disposing objects on the stack/heap.<br/>
/// This has built-in or Default-Implementation of the standard <see cref="IDisposable.Dispose"/><br/>
///   and <see cref="IAsyncDisposable.DisposeAsync"/> methods (given the preferred implementation).
/// </para><para>
/// As such, methods to actually implement, in order to best implement the Disposable patterns across
///   Asyncronous AND Synchronous programming, are provided.</para><para>
/// For a better idea on which methods need implementing, and what is available at your fingertips,<br/>
///   checkout all 4 of the related interfaces below...</para><para>
/// <b>See:</b>
/// <list >
///   <item><term>SeriusSoft</term></item>
///   <item> <see cref="ISoCDisposable"/></item>
///   <item> <see cref="ISoCAsyncDisposable"/></item>
/// <item><term>Standard</term></item>
///   <item> <seealso cref="IDisposable"/></item>
///   <item> <seealso cref="IAsyncDisposable"/></item>
/// </list>
/// </para></summary>
public partial interface InDisposable
  : ISoCDisposable, ISoCAsyncDisposable
{
#pragma warning disable IDE0051
#pragma warning disable IDE0044
#pragma warning disable IDE1006

  /// <summary><para>
  /// <inheritdoc cref="ISoCDisposable.___DOCS.__LOCAL_ONLY.__Summary" path="/summary/para[@id='s00']/node()"/><br/>
  /// <inheritdoc cref="ISoCDisposable.___DOCS.__LOCAL_ONLY.__Summary" path="/summary/para[@id='s01']/node()"/>
  /// <see cref="___DOCS"/>
  /// <inheritdoc cref="ISoCDisposable.___DOCS.__LOCAL_ONLY.__Summary" path="/summary/para[@id='s02']/node()"/>
  /// </para></summary>
  private static class ___DOCS
  {
    /// <inheritdoc cref="">
    private static bool __ABC
    
    /// <inheritdoc cref=""/>
                      , __XYZ
      
      
    ; //last of the bool fields for use with xml-documentation cleanup-and-simplification
  }

#pragma warning restore IDE1006
#pragma warning restore IDE0044
#pragma warning restore IDE0051

}   //END-INTERFACE InDisposable

