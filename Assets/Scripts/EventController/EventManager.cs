using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [Header("Event info")]
    public int eventNumber;
    public int eventIndex;
    public static EventManager instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        eventNumber = transform.childCount;
    }

    private void Start()
    {
        
        
    }

    public void CheckEventProgress()
    {
        Debug.Log(eventIndex + "/" +  eventNumber);
    }

    public bool EventIsEnded()
    {
        return eventIndex == eventNumber;
    }

}
