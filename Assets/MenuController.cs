using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{

    EventSystem events;
    
    void Start()
    {
        GetComponentInChildren<EventSystem>();
    }

    
    void Update()
    {
        if(events.currentSelectedGameObject == null) {
            if(events.firstSelectedGameObject != null)
            {
                events.SetSelectedGameObject(events.firstSelectedGameObject);
            }
        }
    }

    public void Button1Pressed()
    {
        print("button 1 pressed");
    }
    public void Button2Pressed()
    {
        print("button 2 pressed");
    }
    public void Button3Pressed()
    {
        print("button 3 pressed");
    }
    public void Button4Pressed()
    {
        print("button 4 pressed");
    }
    
    

}
