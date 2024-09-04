using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.Core;

public abstract partial class BaseGraphicalObject
  : IGraphicalObject, InDisposable
{
  //public abstract bool Refresh();
  //public abstract Task<bool> AsyncRefresh();
  
  /// <summary>
  /// When overriden, this will run an async method, <see cref="AsyncRefresh">,
  ///   to refresh the current display of this BGO (<see cref="BaseGraphicalObject"/>)
  ///   based on the latest drawn/updated image...
  /// </summary>
  /// <returns></returns>
  public virtual async Task<bool> AsyncRefresh()
  {
    return await Task<bool>.FromResult(true);
  }

  /// <summary>
  /// When overriden, this will run a synchronous method, <see cref="Refresh"/>,
  ///   to refresh the current display of this BGO (<see cref="BaseGraphicalObject"/>)
  ///   based on the latest drawn/updated image...
  /// </summary>
  /// <returns></returns>
  public virtual bool Refresh()
  {
    return true;
  }
}
