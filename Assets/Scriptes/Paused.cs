using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    [SerializeField]
    public GameObject pause;
    public Player player;

    void Start()
    {
        pause.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            pause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void PauseOff(){
        pause.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame(){
        GameManager.instance.level = 0;
        player.food = 100;
        PauseOff();
        SceneManager.LoadScene(0);
        //Application.LoadLevel(Application.loadedLevel);
    }

    public void Quit(){
       Application.Quit();
    }
}
