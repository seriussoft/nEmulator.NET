using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using nEmulator.Graphics.GDIPlus.Extensions.Common;

namespace nEmulator.Graphics.GDIPlus._Examples
{
  internal class Example_DrawAPoint
  {
    void _()
    {
      

      var form = new Form();form.Size = new Size(800 + 0, 600 + 20);
      var gfx = form.CreateGraphics();
      var backupImg = new Bitmap(800, 600);

      var gfx2 =
        System.Drawing.Graphics.FromImage(
          form.BackgroundImage
          ?? (form.BackgroundImage = backupImg)
        );

      gfx.DrawArc(Pens.BlueViolet, form.BackgroundImage.Size.ToRectangle(), 0, 90);


    }
  }
}
