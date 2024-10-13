using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    public GameObject fade;
    private Animator animator;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(fade);
        animator = fade.GetComponent<Animator>();

        if(instance != null )
            Destroy(this.gameObject);
        else
            instance = this;
    }

    public void FadeIn()
    {
        animator.SetBool("In", true);
    }

    public void FadeOut()
    {
        animator.SetBool("In", false);
    }
}
