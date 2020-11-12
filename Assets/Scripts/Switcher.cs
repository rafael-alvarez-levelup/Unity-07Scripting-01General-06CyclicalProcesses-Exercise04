using UnityEngine;

public class Switcher : MonoBehaviour
{
    public bool IsSwitched { get; private set; }

    private void Start()
    {
        IsSwitched = false;
    }

    private void OnTriggerEnter()
    {
        IsSwitched = true;
    }
}
