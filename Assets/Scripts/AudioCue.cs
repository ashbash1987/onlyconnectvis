using UnityEngine;

public class AudioCue : MonoBehaviour
{
    public AudioClip AudioClip = null;

    private AudioSource _source = null;

    private void Awake()
    {
        _source = gameObject.AddComponent<AudioSource>();
        _source.playOnAwake = false;
        _source.clip = AudioClip;
    }

    private void OnEnable()
    {
        _source.Play();
    }

    private void OnDisable()
    {
        _source.Stop();
        _source.time = 0.0f;
    }

    private void Update()
    {
        if (!_source.isPlaying)
        {
            enabled = false;
        }
    }

    public void Play()
    {
        enabled = true;
    }

    public void Stop()
    {
        enabled = false;
    }
}
