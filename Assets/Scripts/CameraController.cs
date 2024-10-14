using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 控制相机跟随玩家以及实现场景渐入渐出效果
/// </summary>

public class CameraController : MonoBehaviour
{
    public static CameraController instance { get; private set; }
    private CinemachineVirtualCamera virtualCamera;
    public Animator animator;
    public GameObject screenFader;
    private Player player;
    private void Awake()
    {
        instance = this;
        //DontDestroyOnLoad(this);
        screenFader = GameObject.Find("ScreenFader");
        animator = screenFader.GetComponent<Animator>();
        virtualCamera = GetComponentInChildren<CinemachineVirtualCamera>();
        player = FindObjectOfType<Player>();

        virtualCamera.Follow = player.transform;
    }

    public IEnumerator LoadScene(string _sceneName)
    {
        animator.SetBool("In", false);
        yield return new WaitForSeconds(1);

        AsyncOperation async = SceneManager.LoadSceneAsync( _sceneName );
        async.completed += OnLoadScene;
    }

    private void OnLoadScene(AsyncOperation operation)
    {
        animator.SetBool("In", true);
    }
}
