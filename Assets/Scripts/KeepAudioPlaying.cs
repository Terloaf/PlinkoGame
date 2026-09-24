using UnityEngine;

public class KeepAudioPlaying : MonoBehaviour
{
    private static KeepAudioPlaying instance;


    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
