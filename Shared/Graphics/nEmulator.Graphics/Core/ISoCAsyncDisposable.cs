using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.Core;

/// <summary><para>
/// Use this if you are implementing in an async-only class.<br/>
/// If you need some or mix of sync/async, then check out the <see cref="InDisposable"/> 
///   interface contract instead.</para><para>
/// TODO: Check that the xml-documentation in ISoCAsyncDisposable.XmlDocs.cs is completed...
/// </para><para>
/// TODO: Redo XmlDocumentation found within BOTH: ISoCAsyncDisposable.cs &amp;&amp; ISoCAsyncDisposable.DefImp.cs
/// </para><para>
/// TODO: Check out work done in ISoCDisposable.cs &amp;&amp; ISoCDisposable.XmlDocs.cs for more info...
/// </para></summary>
public partial interface ISoCAsyncDisposable
  : IAsyncDisposable
{
  Task<bool> AsyncDisposeManagedState();
  Task<bool> AsyncDisposeUnmanagedState();
  Task<bool> AsyncDeReferenceLargeFields();
  Task<bool> AsyncDeconstructSelf();
}
