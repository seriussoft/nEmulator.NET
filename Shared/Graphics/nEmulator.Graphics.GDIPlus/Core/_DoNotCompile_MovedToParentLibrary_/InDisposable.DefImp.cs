using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.GDIPlus.Core;

//public partial class InDisposable
public partial interface InDisposable
  : ISoCDisposable, ISoCAsyncDisposable
{

}
