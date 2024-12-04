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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider whatdidIHit)
    {
        if (whatdidIHit.tag == "ForceField")
        {           
           hasForceField = true;
           forceField.gameObject.SetActive(true);               
        }
    }

    public void Caught()
    {
        if (hasForceField == false)
        {
            Destroy(this.gameObject);
        }
        else if (hasForceField == true)
        {
            hasForceField = false;            
        }
    }
}