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
        switcher.OnSwitcherActivated += Switcher_OnSwitcherActivated;
    }

    private void OnDisable()
    {
        switcher.OnSwitcherActivated -= Switcher_OnSwitcherActivated;
    }

    #endregion

    #region Private Methods

    private void Switcher_OnSwitcherActivated()
    {
        switcher.OnSwitcherActivated -= Switcher_OnSwitcherActivated;

        StartCoroutine(OpenDoorRoutine());
    }

    private IEnumerator OpenDoorRoutine()
    {
        Vector3 originalPosition = transform.position;
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);

        float timeStep = 0f;

        while (time > timeStep)
        {
            timeStep += Time.deltaTime;
            float step = timeStep / time;

            transform.position = Vector3.Lerp(originalPosition, newPosition, step);

            yield return null;
        }
    }

    #endregion
}