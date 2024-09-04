using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.Core;

public partial interface ISoCDisposable
{
#pragma warning disable IDE0051
#pragma warning disable IDE0044
#pragma warning disable IDE1006


  /// <summary>
  /// This is a documentation class. It stores certain Xml-Docs, members, remarks, lists, etc for use
  ///   with ANY member found within <b>THIS</b> <see cref="___DOCS"/>'s enclosing class
  /// </summary>
  private static bool _______;

  /// <summary><para>
  /// <inheritdoc cref="__LOCAL_ONLY.__Summary" path="/summary/para[@id='s00']/node()"/><br/>
  /// <inheritdoc cref="__LOCAL_ONLY.__Summary" path="/summary/para[@id='s01']/node()"/>
  /// <see cref="___DOCS"/>
  /// <inheritdoc cref="__LOCAL_ONLY.__Summary" path="/summary/para[@id='s02']/node()"/>
  /// </para></summary>
  private static class ___DOCS
  {
    private static class __LOCAL_ONLY
    {
      /// <summary>
      /// <para id='s00'>This is a documentation class. </para>
      /// <para id="s01">
      /// It stores certain Xml-Docs, members, remarks, lists, etc for use
      ///   with ANY member found within <b>THIS</b> 
      /// </para>
      /// <para id="s02">'s enclosing class.</para>
      /// </summary>
      private static bool __Summary;
    }

    /// <inheritdoc cref="IAsyncDisposable"/>
    private static bool __IDisposable;

    /// <inheritdoc cref="IDisposable.Dispose"/>
    private static bool __IDisposable_Dispose;

    ///<summary><para>
    /// If it must do some of the work async, then this will need to return unfinished. For that, EITHER:
    ///   - <see langword="return"/> <see langword="true"/> even though not completed (no problems is ok)<br/>
    ///   - OR <see langword="return"/> <see langword="false"/> because not completed (even if no issues)<br/>
    ///   - OR just use the Async functionality, instead. i.e. Check-Out: <see cref="ISoCAsyncDisposable"/>.
    /// </para><para>
    /// If you must/need-to or just plain want to support BOTH the standard <see cref="IDisposable"/> functionality<br/>
    ///   (say, for the <see langword="using"/> expression) AND the newer standard <see cref="IAsyncDisposable"/> functionality<br/>
    ///   (because your object may act on one thread for most [or all] functionality EXCEPT when it needs to run<br/>
    ///   across at least 2 threads [or can be triggered to change thread/task as needed]...)<br/>
    /// Then you should check out <see cref="InDisposable"/> before you even consider trying to implement
    ///   both <see cref="IDisposable"/> and <see cref="IAsyncDisposable"/>...
    /// </para></summary>
    private static bool __DisposeManagedState_Remarks;

    ///<summary>
    ///<para><list type = "bullet" >
    ///   <item>
    ///     <term><see langword="true"/></term> 
    ///     <description> if it runs successfully: no stops/breaks/skips/exceptions...</description>
    ///   </item>
    ///   <item>
    ///     <term><see langword="false"/></term> 
    ///     <description> if it does NOT run successfully: if it stops/breaks/skips/throws-exceptions...</description>
    ///   </item>
    /// </list>
    /// </para>
    /// </summary>
    private static bool __DisposeManagedState_Returns;

    //; //last of the bool fields for use with xml-documentation cleanup-and-simplification
  }
#pragma warning restore IDE1006
#pragma warning restore IDE0044
#pragma warning restore IDE0051
}   //END-INTERFACE::ISoCDisposable




