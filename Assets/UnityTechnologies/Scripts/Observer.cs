using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public GameObject enemy;
    public Transform player;
    public GameObject shield;
    public GameEnding gameEnding;

    bool m_IsPlayerInRange;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = false;
        }
    }

    private void Update()
    {
        if (m_IsPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);

            RaycastHit raycastHit;

            if(Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.transform == shield.transform)
                {
                    shield.SetActive(false);
                    enemy.SetActive(false);
                }
                if (raycastHit.collider.transform == player)
                {
                    gameEnding.CaughtPlayer();
                }
            }
        }
    }
}
