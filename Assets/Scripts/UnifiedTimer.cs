using UnityEngine;
using UnityEngine.UI;

public class UnifiedTimer : MonoBehaviour
{
    public Slider[] Sliders = null;
    public float Duration = 10.0f;
    public AudioClip Clip = null;
    public AudioCue StopCue = null;

    private AudioSource _source = null;
    private float _time = 0.0f;

    private void Awake()
    {
        _source = gameObject.AddComponent<AudioSource>();
        _source.clip = Clip;
        _source.playOnAwake = false;
    }

    private void OnEnable()
    {
        _source.Play();
    }

    private void OnDisable()
    {
        _source.Pause();

        if (StopCue != null)
        {
            StopCue.Play();
        }
    }

    private void Update()
    {
        _time += Time.deltaTime;

        foreach (Slider slider in Sliders)
        {
            slider.normalizedValue = Mathf.Clamp01(_time / Duration);
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

    public void ResetTime()
    {
        _time = 0.0f;

        if (_source != null)
        {
            _source.time = 0.0f;
        }
    }
}
