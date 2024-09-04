/*************************************************************************************************
 * - FileName:  ISoCAsyncDisposable.DefImp.cs
 * - BaseType:  Interface
 * - Full-Name: Interface Separation-of-Concerns Async Disposable Default-Method-Implementations
 * - Parts:
 *    Masterfile:                       ISoCAsyncDisposable.cs        
 *    Default-Method-Implementations:   ISoCAsyncDisposable.DefImp.cs 
 *    XmlDocuments:                     ISoCAsyncDisposable.XmlDocs.cs
 * -------------------------------------------------------------------
 * - DoC [Date of Creation]:  2024.09.01 @01.09.00
 * - DF [Date Format]:        YYYY.MM.dd @HH.mm.ss
 * - Owner:                   Nate VanBuskirk, Nathan VanBuskirk 
 *                              && SeriusSoft LLC (per Nathan VanBuskirk)
 * - Original Developer:      Nate VanBuskirk, Nathan VanBuskirk ~ per SeriusSoft LLC
 * -------------------------------------------------------------------
 * - Purpose:
 *    ISoCAsyncDisposable.DefImp.cs is meant to add Default Method Implementations to
 *      ISoCAsyncDisposable such that the proper and simple Disposing of Rss (Resources)
 *      Asyncronously does not get bloated or overwhelmed with unecessary functionality,
 *      undesirable/seemingly-suplerfluous members (properties|fields|methods|etc),
 *      or a cross between business logic and core developer-only logic intermingled with
 *      necessary, albeit sometimes ick, logic.
 *    To see more about the intention of ISoCAsyncDisposable in general, please see
 *      the masterfile: ISoCAsyncDisposable.cs
 * -------------------------------------------------------------------
 * - Most Important Change History: 
 *    0.0.0.0:  
 *****/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.Core;


public partial interface ISoCAsyncDisposable
{
  public bool ShouldCleanUpUnmanagedState { get; set; }
  public bool HasDisposed { get; protected set; }
  public bool HasTriggeredDispose { get; protected set; }

  async ValueTask IAsyncDisposable.DisposeAsync()
  {
    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //await Dispose(disposing: true);
    await DisposeAsyncCore(true).ConfigureAwait(false);
    
    GC.SuppressFinalize(this);
  }

  protected virtual async ValueTask DisposeAsyncCore(bool disposing)
  {
    var shouldDispose = !(HasTriggeredDispose || HasDisposed);
    if (shouldDispose)
    {
      HasTriggeredDispose = true;

      if (disposing)
      {
        await AsyncDisposeManagedState();
      }

      // TODO: free unmanaged resources (unmanaged objects) and override finalizer
      await AsyncDisposeUnmanagedState();

      // TODO: set large fields to null
      await AsyncDeReferenceLargeFields();

      HasDisposed = true;

      await AsyncDeconstructSelf();
    }
  }
}
