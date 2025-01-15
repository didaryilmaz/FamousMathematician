using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip startSes;  // Sayfa algılandığında çalacak ses (start.mp3)

    public AudioClip dogruSes;
    public AudioClip yanlisSes;

    private AudioSource audioSource;

    void Start()
    {
        // AudioSource bileşenini al
        audioSource = GetComponent<AudioSource>();
    }

    public void DogruSesCal()
    {
        if (dogruSes != null)
        {
            audioSource.clip = dogruSes;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Dogru ses atanmamış!");
        }
    }

    public void YanlisSesCal()
    {
        if (yanlisSes != null)
        {
            audioSource.clip = yanlisSes;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Yanlis ses atanmamış!");
        }
    }
    public void PlayStartSes()
    {
        if (startSes != null)
        {
            audioSource.clip = startSes;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Start ses atanmamış!");
        }
    }

}
