using System.Collections;
using UnityEngine;

public class Door : MonoBehaviour
{
    #region Private Fields

    [SerializeField] private Switcher switcher;

    [SerializeField]
    [Tooltip("Time to open the door.")]
    private float time;

    #endregion

    #region Unity Methods

    private void OnEnable()
    {
        switcher.OnActivated += Switcher_OnActivated;
    }

    private void OnDisable()
    {
        switcher.OnActivated -= Switcher_OnActivated;
    }

    #endregion

    #region Private Methods

    private void Switcher_OnActivated()
    {
        switcher.OnActivated -= Switcher_OnActivated;

        OpenDoor();
    }

    private void OpenDoor()
    {
        Vector3 originalPosition = transform.position;
        Vector3 newPosition = new Vector3(originalPosition.x, originalPosition.y + 2.5f, originalPosition.z);

        StartCoroutine(transform.LerpTransformationRoutine(originalPosition, newPosition, time));
    }

    #endregion
}