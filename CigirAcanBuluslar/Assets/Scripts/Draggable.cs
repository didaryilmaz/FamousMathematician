using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 startPosition;
    private Transform originalParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.position;
        originalParent = transform.parent;

        // Drag edilen objeyi parent'tan ayır
        transform.SetParent(transform.root);
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Objeyi imleçle hareket ettir
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Eğer bir Drop alanına bırakılmadıysa, objeyi başlangıç pozisyonuna döndür
        transform.position = startPosition;
        transform.SetParent(originalParent);
    }
}
