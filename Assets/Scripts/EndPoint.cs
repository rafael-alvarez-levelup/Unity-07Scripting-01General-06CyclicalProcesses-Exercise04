using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public delegate void EndPointReachedEventHandler();
    public event EndPointReachedEventHandler OnReached;

    private void OnTriggerEnter()
    {
        EndPointReached();
    }

    private void EndPointReached()
    {
        if (OnReached != null)
        {
            OnReached();
        }
    }
}