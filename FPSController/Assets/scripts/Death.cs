using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] private HP m_pv;
#pragma warning restore 0649
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_pv.decreaseHp();
            if (m_pv.getHp() == 0)
                FindObjectOfType<GameManager>().gameOver();
        }
    }
}
