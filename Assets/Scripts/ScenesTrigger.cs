using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesTrigger : MonoBehaviour
{
    private void Awake()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            PlayerManager.instance.player.SetBusy(true);
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        SceneController.instance.FadeIn();
        
        SceneManager.LoadSceneAsync("TestScene");
        yield return null;
        SceneController.instance.FadeOut();
    }
}
