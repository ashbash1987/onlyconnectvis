using UnityEngine;
using UnityEngine.Events;

public class Enabler : MonoBehaviour
{
    public UnityEvent OnEnableEvent = new UnityEvent();
    public UnityEvent OnDisableEvent = new UnityEvent();

    private void OnEnable()
    {
        OnEnableEvent.Invoke();
    }

    private void OnDisable()
    {
        OnDisableEvent.Invoke();
    }
}
