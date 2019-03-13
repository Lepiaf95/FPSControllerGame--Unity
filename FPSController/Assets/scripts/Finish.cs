using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Finish : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] private HP m_pv;
    [SerializeField] private Text m_txt;
#pragma warning restore 0649

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_txt.text = "Congratulations!!";
            m_pv.increaseHp();
        }
    }
}
