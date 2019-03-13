using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public void gameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("reStart", 1.0f);
        }
    }

    public void gameWin()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("reStart", 1.0f);
        }
    }

    private void reStart()
    {
        FindObjectOfType<MenuManager>().returnMenu();
    }
}
