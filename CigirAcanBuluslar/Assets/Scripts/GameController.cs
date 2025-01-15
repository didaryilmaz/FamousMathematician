using UnityEngine;

public class GameController : MonoBehaviour
{
    public DropZone[] dropZones;

    public void CheckAnswers()
    {
        foreach (var zone in dropZones)
        {
            if (zone.transform.childCount > 0)
            {
                GameObject child = zone.transform.GetChild(0).gameObject;
                if (child.name != zone.correctAnswer)
                {
                    Debug.Log("Yanlış eşleşme bulundu!");
                    return;
                }
            }
            else
            {
                Debug.Log("Tüm alanlar dolu değil!");
                return;
            }
        }

        Debug.Log("Tebrikler! Tüm eşleşmeler doğru!");
    }
}
