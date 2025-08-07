using UnityEngine;

public class GerenteMusical : MonoBehaviour
{
    [SerializeField] private AudioClip musicaDeFundo;
    private SistemaDeAudio sistemaDeAudio;

    void Start()
    {
        sistemaDeAudio = FindAnyObjectByType<SistemaDeAudio>();
        
        if (musicaDeFundo != null)
        {
            sistemaDeAudio.PlayBackgroundMusic(musicaDeFundo);
        }
    }
}
