using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public string correctAnswer;

    public void OnDrop(PointerEventData eventData)
    {
        Draggable draggable = eventData.pointerDrag.GetComponent<Draggable>();

        if (draggable != null)
        {
            if (draggable.gameObject.name == correctAnswer)
            {
                Debug.Log("Doğru eşleştirme!");
                FindObjectOfType<AudioManager>().DogruSesCal();
            }
            else
            {
                Debug.Log("Yanlış eşleştirme!");
                FindObjectOfType<AudioManager>().YanlisSesCal();
            }
        }
    }
}
