using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public delegate void EndPointReachedEventHandler();
    public event EndPointReachedEventHandler OnEndPointReached;

    private void OnTriggerEnter()
    {
        if (OnEndPointReached != null)
        {
            OnEndPointReached();
        }
    }
}