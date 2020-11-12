using UnityEngine;

public class Door : MonoBehaviour
{
    private bool _isOpen;

    private Switcher _switcher;

    private void Awake()
    {
        _switcher = FindObjectOfType<Switcher>();
    }

    void Start()
    {
        _isOpen = false;
    }

    void Update()
    {
        if (_switcher.IsSwitched && !_isOpen)
        {
            OpenDoor();

            _isOpen = true;
        }
    }

    private void OpenDoor()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);
    }

}
