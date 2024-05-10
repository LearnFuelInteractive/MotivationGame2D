using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class CloseButton : MonoBehaviour, IPointerClickHandler, IPointerUpHandler, IPointerExitHandler, IPointerDownHandler
{
    public UnityEvent closeProblemPopup;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Hello click");
        closeProblemPopup.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Hello up");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Hello exit");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Hello down");
    }
}
