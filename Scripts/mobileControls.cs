using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mobileControls : MonoBehaviour
{
    public bool isPressed;

    void start()
    {
        SetupButton();                                                              
    }
    void update()
    {

    }
    void SetupButton()
    {
        EventTrigger trigger = gameObject.AddComponent<EventTrigger>();
        var pointerDown = new EventTrigger.Entry();
        pointerDown.eventID = EventTriggerType.PointerDown;
        pointerDown.callback.AddListener((e) => onClickDown());

        var pointerUp = new EventTrigger.Entry();
        pointerUp.eventID = EventTriggerType.PointerUp;
        pointerUp.callback.AddListener((e) => onClickUp());

        trigger.triggers.Add(pointerDown);
        trigger.triggers.Add(pointerUp);
    }
    public void onClickDown()
    {
        isPressed = true;
    }
    public void onClickUp()
    {
        isPressed = false;
    }
}
