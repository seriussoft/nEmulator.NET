using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.GDIPlus.Core;

public abstract partial class BaseGraphicalObject
  : IGraphicalObject, InDisposable
{




  // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
  // ~BaseGraphicalObject()
  // {
  //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
  //     Dispose(disposing: false);
  // }

  #region Properties that give us access to interface-dedicated-functionality...

  protected ISoCDisposable ___Disposable => this;
  protected ISoCAsyncDisposable ___AsyncDisposable => this;
  protected InDisposable ___nDisposable => this;

  #endregion  Properties that give us access to interface-dedicated-functionality...

  #region These properties are ONLY necessary for function of I[SoC|SoCAsync|n]Disposable

  bool ISoCDisposable.ShouldCleanUpUnmanagedState { get; set; }
  bool ISoCAsyncDisposable.ShouldCleanUpUnmanagedState { get; set; }
  bool ISoCDisposable.HasDisposed { get; set; }
  bool ISoCAsyncDisposable.HasDisposed { get; set; }
  bool ISoCDisposable.HasTriggeredDispose { get; set; }
  bool ISoCAsyncDisposable.HasTriggeredDispose { get; set; }

  #endregion  These properties are ONLY necessary for function of I[SoC|SoCAsync|n]Disposable
  
  #region Async Disposable

  public virtual async Task<bool> AsyncDeconstructSelf()
    => await Task<bool>.FromResult(true);

  public virtual async Task<bool> AsyncDeReferenceLargeFields()
    => await Task<bool>.FromResult(true);

  public virtual async Task<bool> AsyncDisposeManagedState()
    => await Task<bool>.FromResult(true);

  public virtual async Task<bool> AsyncDisposeUnmanagedState()
    => await Task<bool>.FromResult(true);

  #endregion  Async Disposable

  #region Disposable

  public virtual bool DeconstructSelf() => true;

  public virtual bool DeReferenceLargeFields() => true;

  public virtual bool DisposeManagedState() => true;

  public virtual bool DisposeUnmanagedState() => true;

  #endregion  Disposable

}
