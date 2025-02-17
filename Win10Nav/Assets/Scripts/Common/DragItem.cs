using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DragItem : MonoBehaviour, IDragHandler, IEndDragHandler,IBeginDragHandler
{
    public bool IsDrag = false;
    private RectTransform dragTarget;
    private Canvas canvas;
    public UnityEvent onBeginDrag;
    public UnityEvent onEndDrag;
    private Vector3 _beginMousePos;
    private Vector3 _beginPanelPos;
    protected virtual void Awake()
    {
        if (dragTarget == null) dragTarget = transform.GetComponent<RectTransform>();
        if (canvas == null) canvas = GetComponentInParent<Canvas>();
    }

    public void OnDrag(PointerEventData eventData)
    {

        dragTarget.anchoredPosition= _beginPanelPos+Input.mousePosition- _beginMousePos;
        IsDrag = true;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        onEndDrag.Invoke();
        IsDrag = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        onBeginDrag.Invoke();
        IsDrag = true;
        _beginMousePos=Input.mousePosition;
        _beginPanelPos = dragTarget.anchoredPosition;
    }
}