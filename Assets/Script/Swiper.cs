using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swiper : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        if ((Mathf.Abs(eventData.delta.x))> (Mathf.Abs(eventData.delta.y))){
            if (eventData.delta.x > 0)
                PlayerMover.SwitchPosition("right");
            else
                PlayerMover.SwitchPosition("left");
        }
        else
        {
            if (eventData.delta.y > 0)
                PlayerMover.SwitchPosition("up");
            else
                PlayerMover.SwitchPosition("down");
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
    }
}
