using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject bottonPausa;
    [SerializeField] private GameObject menuPausa;

    private bool playPause = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(playPause)
            {
                Resume();
            }
            else
            {
                Pausa();
            }
        }
    }
    public void Pausa()
    {
        playPause = true;
        Time.timeScale = 0f;
        bottonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void Resume()
    {
        playPause = false;
        Time.timeScale = 1f;
        bottonPausa.SetActive(true);
        menuPausa.SetActive(false);

    }
    public void Restart()
    {
        playPause = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        

    }

    public void Quit()
    {
        Debug.Log("Close play");
        Application.Quit();
    }

}
