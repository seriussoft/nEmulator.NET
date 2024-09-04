using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.Core;

public class GraphicsFactory 
  : IGraphicsFactory
  , IChainConstruct<GraphicsFactory>
{
  public IGraphicsManager Mgr { get; set; }

  public GraphicsFactory()
  {

  }

  public GraphicsFactory Hire(IGraphicsManager mgr)
  {
    this.Mgr = mgr;


    return this;
  }

  #region Implicit Implementation Details

  /// <summary>
  /// TODO-EX: Implement Exception prevention/handling/other for GraphicsFactory.With(Action<GraphicsFactory>)</GraphicsFactory>
  /// </summary>
  /// <param name="setterAction"></param>
  /// <returns></returns>
  public GraphicsFactory With(Action<GraphicsFactory> setterAction)
  {
    setterAction?.Invoke(this);

    return this;
  }

  #endregion  Implicit Implementation Details

  #region Explicit Implementation Details

  IGraphicsFactory IGraphicsFactory.Hire(IGraphicsManager mgr)
    => this.Hire(mgr);

  

  #endregion  Explicit Implementation Details
}

public interface IGraphicsFactory
{
  public IGraphicsManager Mgr { get; set; }

  public IGraphicsFactory Hire(IGraphicsManager mgr);
  public IGraphicsFactory Draw();

}