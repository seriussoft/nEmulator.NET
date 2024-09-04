﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.Core;

/// <summary><para>
/// These are the most basic form of all types of Graphical Object 
///   (<see cref="BaseGraphicalObject"/> is merely the base to provide disposable
///   and similar functionality).<br/>
/// This object, on, OTOH, must be extended by all graphical objects.<br/>
/// You will sometimes here the term: CGO (Core Graphical Object).<br/>
/// That is referring to this class.</para><para>
/// Other the many types of GOs, or Graphical Objects, the most common are:
/// <list type="bullet">
///  <item>
///   <term>GO</term>
///   <description> <i>refers to: </i> ANY Graphical Object</description>
///  </item>
///  <item>
///   <term>CGO</term>
///   <description> Core Graphical Object</description>
///  </item>
///  <item>
///   <term>BGO</term>
///   <description> Base (or Basic) Graphical Object</description>
///  </item>
///  <item>
///   <term>CusGO</term>
///   <description> CUS-tom Graphical Object</description>
///  </item>
///  <item>
///   <term>AGO</term>
///   <description> Advanced Graphical Object</description>
///  </item>
///  <item>
///   <term>ExGO</term>
///   <description> Extended Graphical Object</description>
///  </item>
///  <item>
///   <term>TemGO</term>
///   <description> Templated Graphical Object</description>
///  </item>
///  <item>
///   <term>ConGO</term>
///   <description> Container Graphical Object: <i>Container for other Graphical Object, process, or similar</i></description>
///  </item>
///  <item>
///   <term>POGO</term>
///   <description> Plain Old Graphical Object: <i>Data Model holding data for a GO process</i></description>
///  </item>
///  <item>
///   <term></term>
///   <description></description>
///  </item>
///  <item>
///   <term></term>
///   <description></description>
///  </item>
///  <item>
///   <term></term>
///   <description></description>
///  </item>
/// </list>
/// </para></summary>
public abstract partial class CoreGraphicalObject
  : BaseGraphicalObject, IGraphicalObject, INoOp
{
  protected INoOp __this => this;
  public void NoOp() { }

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  [Obsolete("These need to be fleshed out and then return self...", error:true)]
  public CoreGraphicalObject NoOpReturn() => this;

  public virtual CoreGraphicalObject DrawFor(IGraphicsFactory gfxFactory, bool runOnCompletion = true)
    => gfxFactory.Mgr is not null
        ? DrawFor(gfxFactory.Mgr)
        : DrawForFactoryOnly(gfxFactory, runOnCompletion);

  #region Work: Sans Manager

  protected virtual CoreGraphicalObject DrawForFactoryOnly(IGraphicsFactory gfxFactory, bool runOnCompletion = true)
  {
    PrepareFactory(gfxFactory);
    FeedInstructionsTo(gfxFactory);
    if (runOnCompletion)
      FlushInstructionsFor(gfxFactory);

    return this;
  }

  #endregion  Work: Sans Manager

  public virtual CoreGraphicalObject DrawFor(IGraphicsManager gfxMgr, bool runOnCompletion = true)
  {
    PrepareManager(gfxMgr);
    FeedInstructionsTo(gfxMgr);
    if (runOnCompletion)
      FlushInstructionsFor(gfxMgr);

    return this;
  }

  #region IGraphicsFactory Handshakes

  public virtual CoreGraphicalObject PrepareFactory(IGraphicsFactory factory)
  {

    return NoOpReturn();
  }

  public virtual CoreGraphicalObject FeedInstructionsTo(IGraphicsFactory factory)
  {
    

    return NoOpReturn();
  }

  #endregion  IGraphicsFactory Handshakes

  #region IGraphicsManager Handshakes

  public virtual CoreGraphicalObject PrepareManager(IGraphicsManager mgr)
  {
    

    return NoOpReturn();
  }

  public virtual CoreGraphicalObject FeedInstructionsTo(IGraphicsManager mgr)
  {
    

    return NoOpReturn();
  }

  #endregion  IGraphicsManager Handshakes

  #region Flushing Instructions List from JUST THIS object, no one else's...

  public virtual CoreGraphicalObject FlushInstructionsFor(IGraphicsManager mgr)
  {
    if(mgr is null)
    {
      return NoOpReturn();
    }

    
    
    return NoOpReturn();
  }

  public virtual CoreGraphicalObject FlushInstructionsFor(IGraphicsFactory factory)
    => factory.Mgr is null
      ? NoOpReturn()
      : FlushInstructionsFor(factory.Mgr);

  #endregion  Flushing Instructions List from JUST THIS object, no one else's...

  #region Deal With This Later...
  //(
  //(factory.Mgr is not null)
  //    ? FlushInstructionsFor(factory.Mgr)
  //    : __this.NoOp()
  //);

  //public void NoOp() {  }

  //{
  //  if (factory.Mgr is not null)
  //  {
  //    FlushInstructionsTo(factory.Mgr);
  //    return;
  //  }

  //  //no manager, so we need to implement this
  //  //  flushing of JUST OUR instructions...

  //}

  #endregion  Deal With This Later...





}
