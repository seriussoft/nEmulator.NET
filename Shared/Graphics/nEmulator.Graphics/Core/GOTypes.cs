using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.Core;

/// <summary>
/// <see cref="CoreGraphicalObject"/>
/// </summary>
[Flags]
public enum GOTypes : Int32
{
  /// <summary>
  /// Unknown GO (or it isn't a GO, thus, unknown...)
  /// </summary>
  Unknown = 0x0,
  /// <summary>
  /// [Base | Basic] GO
  /// </summary>
  BGO = 0x1 << 0,
  /// <summary>
  /// Core GO
  /// </summary>
  CGO = 0x1 << 1,
  /// <summary>
  /// Custom GO
  /// </summary>
  CusGO = 0x1 << 2,
  /// <summary>
  /// Advanced GO
  /// </summary>
  AGO = 0x1 << 3,
  /// <summary>
  /// Extended GO
  /// </summary>
  ExGO = 0x1 << 4,
  /// <summary>
  /// Templated GO
  /// </summary>
  TemGO = 0x1 << 5,
  /// <summary>
  /// Container GO
  /// </summary>
  ConGO = 0x1 << 6,
  /// <summary>
  /// Plain Old GO
  /// </summary>
  POGO = 0x1 << 7,
  /// <summary>
  /// Dynamic GO
  /// </summary>
  DyGO = 0x1 << 8,
}
