using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.GDIPlus.Core;

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
  : BaseGraphicalObject, IGraphicalObject
{
}

