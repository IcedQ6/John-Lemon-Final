using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;
using static UnityEngine.Rendering.DebugUI;

public class Shield : MonoBehaviour
{
    private bool hasForceField;

    public GameObject forceField;

    public void RemoveShield()
    {
        forceField.SetActive(false);
    }

    private void OnTriggerEnter(Collider whatdidIHit)
    {
        if (whatdidIHit.tag == "ForceField")
        {
            forceField.gameObject.SetActive(true);
            hasForceField = true;                        
        }

    }
}