using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackGround : MonoBehaviour
{
    [SerializeField] private float parallaxEffect;
    private GameObject cam;

    private float xPosition;
    private float yPosition;

    private void Start()
    {
        cam = GameObject.Find("Virtual Camera");
        xPosition = transform.position.x;
        yPosition = transform.position.y;
    }

    private void Update()
    {
        float xdistanceToMove = cam.transform.position.x * parallaxEffect;
        float ydistanceToMove = cam.transform.position.y * parallaxEffect;
        transform.position = new Vector3(xPosition + xdistanceToMove, yPosition + ydistanceToMove);
    }

}
