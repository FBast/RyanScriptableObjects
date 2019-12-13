namespace Plugins.SOEvents {
    public interface IGameEventListener<T> {
        void OnEventRaised(T item);
    }
}