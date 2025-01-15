using UnityEngine;
using Vuforia;

public class TargetStatusHandler : MonoBehaviour
{
    public ObserverBehaviour observerBehaviour;

    void Start()
    {
        if (observerBehaviour)
        {
            observerBehaviour.OnTargetStatusChanged += OnStatusChanged;
        }
    }

    private void OnStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.NO_POSE)
        {
            Debug.Log("Hedef geçici olarak kayboldu.");
        }
        else if (targetStatus.Status == Status.TRACKED)
        {
            Debug.Log("Hedef algılandı.");
        }
    }
}
