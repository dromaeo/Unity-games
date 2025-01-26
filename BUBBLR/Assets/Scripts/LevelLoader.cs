using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;
    public bool Fade = false;

    public bool LoadNextLevelBool = false;
    public bool WinSceneBool = false;
    public bool GameOverSceneBool = false;
    public bool LoadMenuBool = false;
    
    void Start()
    {

    }

    void Update()
    {
       if(LoadNextLevelBool == true)
       {
          LoadNextLevel();
          transition.SetBool("Fade", true);
       } 

        if(WinSceneBool == true)
       {
          WinScene();
          transition.SetBool("Fade", true);
       } 

       if(GameOverSceneBool == true)
       {
          GameOverScene();
          transition.SetBool("Fade", true);
       }     

       if(LoadMenuBool == true)
       {
          LoadMenu();
          transition.SetBool("Fade", true);
       }      
    }

    public void LoadNextLevel()
    {
      transition.SetBool("Fade", true);
      StartCoroutine(LoadLevel(1));     
    }

    public void LoadMenu()
    {
      transition.SetBool("Fade", true);
      StartCoroutine(LoadLevel(0));     
    }

    public void WinScene()
    {
      transition.SetBool("Fade", true);
      StartCoroutine(LoadLevel(2));     
    }

    public void GameOverScene()
    {
    transition.SetBool("Fade", true);
    StartCoroutine(LoadLevel(3));     
    }

    IEnumerator LoadLevel(int LevelIndex)
    {  
      yield return new WaitForSeconds(transitionTime);
      SceneManager.LoadScene(LevelIndex);
    }
}