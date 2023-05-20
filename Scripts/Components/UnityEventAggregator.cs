using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UnityEventAggregator : MonoBehaviour
{
    private static UnityEventAggregator _instance;
    public static UnityEventAggregator GetInstance()
    {
        if (_instance == null)
        {
            var go = new GameObject(nameof(UnityEventAggregator));
            _instance = go.AddComponent<UnityEventAggregator>();
        }

        return _instance;
    }

    private List<IAggregatedUnityEvent> _events;
    public TEventType GetEvent<TEventType>() where TEventType : class, IAggregatedUnityEvent, new()
    {
        var ev = _events.FirstOrDefault(xx => xx.GetType() == typeof(TEventType));
        
        if (ev == null)
        {
            ev = new TEventType();
            _events.Add(ev);
        }

        return ev as TEventType;
    }

    private void Awake()
    {
        if (this != _instance)
            Destroy(this);

        _events = new List<IAggregatedUnityEvent>();
    }
}