using UnityEngine;
using System.Collections.Generic;

public class PlaySoundOnClick : MonoBehaviour
{
    private AudioSource audioSource;

    // Tüm aktif AudioSource'ları takip eden statik bir liste
    private static List<AudioSource> activeAudioSources = new List<AudioSource>();

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        Debug.Log($"{gameObject.name} tıklandı!");

        if (audioSource != null)
        {
            // Önceki tüm sesleri durdur
            StopAllOtherAudioSources();

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
                Debug.Log("Ses oynatılıyor...");
            }
        }
        else
        {
            Debug.LogError("AudioSource bileşeni bulunamadı!");
        }
    }

    private void StopAllOtherAudioSources()
    {
        // Şu an oynayan tüm diğer sesleri durdur
        foreach (AudioSource source in activeAudioSources)
        {
            if (source != audioSource && source.isPlaying)
            {
                source.Stop();
                Debug.Log($"{source.gameObject.name} ses durduruldu.");
            }
        }

        // Mevcut AudioSource'u listeye ekle
        if (!activeAudioSources.Contains(audioSource))
        {
            activeAudioSources.Add(audioSource);
        }
    }
}