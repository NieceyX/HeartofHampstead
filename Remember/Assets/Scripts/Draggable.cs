using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler
{
    [SerializeField]
    private float dampingSpeed = .05f;

    private RectTransform draggingObject;
    private Vector3 velocity = Vector3.zero;

    private void Awake()
    {
        draggingObject = transform as RectTransform;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
       if (RectTransformUtility.ScreenPointToWorldPointInRectangle(draggingObject, eventData.position, eventData.pressEventCamera, out var globalMousePosition))
        {
            draggingObject.position = Vector3.SmoothDamp(draggingObject.position, globalMousePosition, ref velocity, dampingSpeed);
        }
    }

}
