using UnityEngine.Events;

public interface IAggregatedUnityEvent { }

public abstract class AggregatedUnityEvent : IAggregatedUnityEvent
{
    private UnityEvent _event;

    public AggregatedUnityEvent()
    {
        _event = new UnityEvent();
    }

    public void Subscribe(UnityAction action)
    {
        _event.AddListener(action);
    }

    public void Unsubscribe(UnityAction action)
    {
        _event.RemoveListener(action);
    }

    public void Publish()
    {
        _event.Invoke();
    }
}

public abstract class AggregatedUnityEvent<TEventInfo> : IAggregatedUnityEvent
{
    private UnityEvent<TEventInfo> _event;

    public AggregatedUnityEvent()
    {
        _event = new UnityEvent<TEventInfo>();
    }

    public void Subscribe(UnityAction<TEventInfo> action)
    {
        _event.AddListener(action);
    }

    public void Unsubscribe(UnityAction<TEventInfo> action)
    {
        _event.RemoveListener(action);
    }

    public void Publish(TEventInfo publishData)
    {
        _event.Invoke(publishData);
    }
}