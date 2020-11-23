using System.Collections;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    #region Events

    public delegate void SwitcherActivatedEventHandler();
    public event SwitcherActivatedEventHandler OnActivated;

    #endregion

    #region Private Fields

    [SerializeField]
    [Tooltip("Time to hide the switch.")]
    private float time;

    #endregion

    #region Unity Methods

    private void OnTriggerEnter()
    {
        StartCoroutine(HideSwitchRoutine());

        Destroy(GetComponent<Collider>());
    }

    #endregion

    #region Private Methods

    private IEnumerator HideSwitchRoutine()
    {
        Vector3 originalPosition = transform.position;
        Vector3 newPosition = new Vector3(originalPosition.x, originalPosition.y - 0.4f, originalPosition.z);

        yield return StartCoroutine(transform.LerpTransformationRoutine(originalPosition, newPosition, time));

        SwitcherActivated();
    }

    private void SwitcherActivated()
    {
        if (OnActivated != null)
        {
            OnActivated();
        }
    }

    #endregion
}