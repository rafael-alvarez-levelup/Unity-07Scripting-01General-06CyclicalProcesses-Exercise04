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

    // TODO: DRY
    private IEnumerator HideSwitchRoutine()
    {
        Vector3 originalPosition = transform.position;
        Vector3 newPosition = new Vector3(originalPosition.x, originalPosition.y - 0.4f, originalPosition.z);

        float timeStep = 0f;

        while (time > timeStep)
        {
            timeStep += Time.deltaTime;
            float step = timeStep / time;

            transform.position = Vector3.Lerp(originalPosition, newPosition, step);

            yield return null;
        }

        if (OnActivated != null)
        {
            OnActivated();
        }
    }

    #endregion
}