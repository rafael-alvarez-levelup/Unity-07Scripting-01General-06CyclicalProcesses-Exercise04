using System.Collections;
using UnityEngine;

public static class ExtensionMethods
{
    public static IEnumerator LerpTransformationRoutine(this Transform transform, Vector3 originalPosition, Vector3 newPosition, float time)
    {
        float timeStep = 0f;

        while (time > timeStep)
        {
            timeStep += Time.deltaTime;
            float step = timeStep / time;

            transform.position = Vector3.Lerp(originalPosition, newPosition, step);

            yield return null;
        }
    }
}