namespace NexusForever.Game.Abstract.Cinematic
{
    public interface IScene : IKeyframeAction
    {
        uint InitialDelay { get; }
        uint SceneId { get; }
    }
}