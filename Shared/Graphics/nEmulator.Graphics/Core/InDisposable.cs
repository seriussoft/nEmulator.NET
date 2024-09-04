namespace nEmulator.Graphics.Core;

#pragma warning disable IDE0051
#pragma warning disable IDE0044
#pragma warning disable IDE1006

/// <summary><para>
/// By Default, we SHOULD see functionality from both interface-contracts 
///   built-into this joint-contract for "free".<br/>
/// Should we desire a merger of those features, such as ability for either/or
///   contract to activate the logic that comes with it's opposite,
///   then we may actually need to do some work here...
/// 
/// </para></summary>
public partial interface InDisposable
  : ISoCDisposable, ISoCAsyncDisposable
{ 
  
}



#pragma warning restore IDE1006
#pragma warning restore IDE0044
#pragma warning restore IDE0051
