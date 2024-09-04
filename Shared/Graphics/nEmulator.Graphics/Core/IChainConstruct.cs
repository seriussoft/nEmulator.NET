namespace nEmulator.Graphics.Core;

public interface IChainConstruct<TChainable>
  where TChainable : IChainConstruct<TChainable>
{
  //IChainConstruct Construct();
  /// <summary>
  /// To Be Implemented such that the thing that is ConstructChainable,
  ///   <typeparamref name="TChainable"/>, returns itself after each <br/>
  ///   setup functor, and where <paramref name="setterAction"/> is this thing
  ///   being passed into your functor to enable setting properties or activating<br/>
  ///   other setup-necessary state for your <typeparamref name="TChainable"/> thing.
  /// </summary>
  /// <param name="setterAction"></param>
  /// <returns></returns>
  TChainable With(Action<TChainable> setterAction);
}

