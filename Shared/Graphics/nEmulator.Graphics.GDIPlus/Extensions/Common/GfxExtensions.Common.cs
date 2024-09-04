using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nEmulator.Graphics.GDIPlus.Extensions.Common;

public static partial class GfxExtensions
{
  public static Rectangle ToRectangleFromPoint(this Size size, Point? startingPoint = null)
    => size.ToRectangleImpl(startingPoint ?? Point.Empty);

  public static Rectangle ToRectangle(this Size size, int startX = 0, int startY = 0)
    => size.ToRectangleImpl(new Point(startX, startY));

  private static Rectangle ToRectangleImpl(this Size size, Point startingPoint)
    => new Rectangle(startingPoint, size);



  public static RectangleF ToRectangleF(this SizeF sizef, PointF? startingPoint = null)
    => sizef.ToRectangleFImpl(startingPoint ?? Point.Empty);

  public static RectangleF ToRectangleF(this SizeF sizef, int startX = 0, int startY = 0)
    => sizef.ToRectangleFImpl(new PointF(startX, startY));

  private static RectangleF ToRectangleFImpl(this SizeF sizef, PointF startingPointf)
    => new RectangleF(startingPointf, sizef);


  /******************
   * was gonna have enum so you can tell it to pick between:
   * + ctrl.CreateGraphics 
   * + Graphics.FromImage(ctrl.BackgroundImage)
  public static System.Drawing.Graphics FromControl(this Control ctrl)
  {
    ctrl.CreateGraphics()
  }
  *****/
}
