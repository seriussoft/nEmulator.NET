namespace nEmulator.Graphics.GDIPlus.Core;

public interface IGraphicalObject : InDisposable
{
  string? Name { get; set; }
  Guid ID { get; set; }

  bool Refresh();
  Task<bool> AsyncRefresh();


}

