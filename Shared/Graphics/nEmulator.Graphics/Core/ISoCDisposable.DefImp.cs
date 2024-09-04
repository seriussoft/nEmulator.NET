using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.Core;

public partial interface ISoCDisposable
{
  /// 
  /// <summary><para>
  /// A Default Implementation of this method has already been provided.<br/>
  /// Please see <see cref="IDisposable"/>, <see cref="IAsyncDisposable"/>, and <see cref="ISoCDisposable"/>
  ///   for more general/overarching knowledge on the matter...
  /// </para></summary>
  /// <inheritdoc cref="IDisposable.Dispose"/>
  void IDisposable.Dispose()
  {
    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    Dispose(disposing: true);
    GC.SuppressFinalize(this);
  }

  /// <summary><para>
  /// A Default Implementation of this method has already been provided.<br/>
  /// Please see the following for more general/overarching knowledge on the matter:
  /// <list type="number">
  ///   <item><term><see cref="ISoCDisposable"/> </term> <description></description></item>
  ///   <item><term><see cref="IDisposable"/> </term> <description></description></item>
  ///   <item>
  ///     <term><see cref="IAsyncDisposable"/> </term> 
  ///     <description>... <inheritdoc cref="IAsyncDisposable" path="//summary/*"/></description>
  ///   </item>
  ///   
  /// </list>
  /// </para></summary>
  /// <inheritdoc cref="IDisposable"/>
  /// <inheritdoc cref="IAsyncDisposable"/>
  /// <inheritdoc cref="ISoCDisposable"/>
  /// <param name="disposing"></param>
  protected virtual void Dispose(bool disposing)
  {      
    var shouldDispose = !(HasTriggeredDispose || HasDisposed);
    if (shouldDispose)
    {
      HasTriggeredDispose = true;

      if (disposing)
      {
        DisposeManagedState();
      }

      // TODO: free unmanaged resources (unmanaged objects) and override finalizer
      DisposeUnmanagedState();

      // TODO: set large fields to null
      DeReferenceLargeFields();

      HasDisposed = true;

      DeconstructSelf();
    }
  }

}
