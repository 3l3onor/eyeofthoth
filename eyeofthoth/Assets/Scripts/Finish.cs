using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private   AudioSource finishSound;
      
    private int nextSceneToLoad;

    public void Start()
    {
        finishSound = GetComponent<AudioSource>();
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;

    }

    public  void OnTriggerEnter2D(Collider2D collision)
    {
       
            finishSound.Play();
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }

    
   

}
