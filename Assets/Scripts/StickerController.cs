using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StickerController : MonoBehaviour
{
    public GameObject xSticker1, xSticker2, xSticker3, gameOver, touchMe, winner, restart;
    public static int health;

    public Image emptyBar, fullBar;
    public float maxTime = 3f;
    float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        xSticker1.gameObject.SetActive(false);
        xSticker2.gameObject.SetActive(false);
        xSticker3.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
        emptyBar.gameObject.SetActive(false);
        fullBar.gameObject.SetActive(false);
        touchMe.gameObject.SetActive(true);
        winner.gameObject.SetActive(false);

        timeLeft = maxTime;
    }

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchMe.gameObject.SetActive(false);
        }

               if (health<0)
        {
            health = 0;
        }

        switch (health)
        {
            case 3:
                xSticker1.gameObject.SetActive(false);
                xSticker2.gameObject.SetActive(false);
                xSticker3.gameObject.SetActive(false);
                break;
            case 2:
                xSticker1.gameObject.SetActive(true);
                xSticker2.gameObject.SetActive(false);
                xSticker3.gameObject.SetActive(false);
                break;
            case 1:
                xSticker1.gameObject.SetActive(true);
                xSticker2.gameObject.SetActive(true);
                xSticker3.gameObject.SetActive(false);
                break;
            case 0:
                xSticker1.gameObject.SetActive(true);
                xSticker2.gameObject.SetActive(true);
                xSticker3.gameObject.SetActive(true);
                gameOver.gameObject.SetActive(true);
                emptyBar.gameObject.SetActive(false);
                fullBar.gameObject.SetActive(false);
                break;
        }

        if (CheckController.finishCount==9 && health>0)
        {
            emptyBar.gameObject.SetActive(true);
            fullBar.gameObject.SetActive(true);
            WinBar();
        }
        else
        {
            emptyBar.gameObject.SetActive(false);
            fullBar.gameObject.SetActive(false);
        }
    }

    public void WinBar()
    {

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            fullBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            Time.timeScale = 0;
            winner.gameObject.SetActive(true);
        }
    }

    
    public void RestartScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
