using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeShader : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        // 检查是否成功获取了SpriteRenderer组件
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer组件未找到");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Color color = spriteRenderer.color;
            color.a = 0.5f; // 设置透明度为50%
            spriteRenderer.color = color;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Color color = spriteRenderer.color;
            color.a = 1f; // 设置透明度为50%
            spriteRenderer.color = color;
        }
    }
}
