using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Powerup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider whoHitMe)
    {
        if (whoHitMe.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }    
}
