using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish2 : MonoBehaviour
{

    [SerializeField] private AudioSource finishSound2;
    private bool levelCompleted2 = false;
 
    private int nextSceneToLoad;

    public void Start()
    {
        finishSound2 = GetComponent<AudioSource>();
       

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted2)
        {
            finishSound2.Play();

            SceneManager.LoadScene(nextSceneToLoad);

        }


    }


}

