using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HP : MonoBehaviour
{
    private int m_pv;

    // Start is called before the first frame update
    void Start()
    {
        m_pv = 3;
        GetComponent<Text>().text = getHp() + " HP";
    }

    public int getHp()
    {
        return m_pv;
    }

    public void increaseHp()
    {
        m_pv++;
        GetComponent<Text>().text = getHp() + " HP";
    }

    public void decreaseHp()
    {
        m_pv--;
        GetComponent<Text>().text = getHp() + " HP";
    }

}
