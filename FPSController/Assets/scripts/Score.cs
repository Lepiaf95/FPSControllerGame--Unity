using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int m_score;

    // Start is called before the first frame update
    void Start()
    {
        m_score = 0;
        GetComponent<Text>().text = "Score : " + getScore();
    }

    public int getScore()
    {
        return m_score;
    }

    public void increaseScore()
    {
        m_score++;
        GetComponent<Text>().text = "Score : " + getScore();
        if (m_score == 8)
        {
            FindObjectOfType<GameManager>().gameWin();
        }
    }
}
