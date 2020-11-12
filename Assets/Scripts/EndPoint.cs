using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public bool IsEnter { get; private set; }

    private void Start()
    {
        IsEnter = false;
    }

    private void OnTriggerEnter()
    {
        IsEnter = true;
    }

}
