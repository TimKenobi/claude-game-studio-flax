using FlaxEngine;

/// <summary>
/// Simple audio manager for playing music, ambient, and sound effects.
/// Singleton pattern — one per scene or persistent across scenes.
/// </summary>
public class AudioManager : Script
{
    public static AudioManager Instance { get; private set; }

    [Serialize, ShowInEditor, Header("Audio Sources")]
    private AudioSource _musicSource;

    [Serialize, ShowInEditor]
    private AudioSource _ambientSource;

    [Serialize, ShowInEditor, Header("Volume")]
    private float _masterVolume = 1.0f;

    [Serialize, ShowInEditor]
    private float _musicVolume = 0.7f;

    [Serialize, ShowInEditor]
    private float _sfxVolume = 1.0f;

    [Serialize, ShowInEditor]
    private float _ambientVolume = 0.5f;

    public float MasterVolume
    {
        get => _masterVolume;
        set
        {
            _masterVolume = Mathf.Clamp(value, 0f, 1f);
            UpdateVolumes();
        }
    }

    public override void OnEnable()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Actor);
            return;
        }
        Instance = this;
    }

    public override void OnDisable()
    {
        if (Instance == this)
            Instance = null;
    }

    /// <summary>
    /// Play background music with optional crossfade.
    /// </summary>
    public void PlayMusic(AudioClip clip)
    {
        if (_musicSource == null || clip == null)
            return;

        _musicSource.Clip = clip;
        _musicSource.IsLooping = true;
        _musicSource.Play();
        UpdateVolumes();
    }

    /// <summary>
    /// Play ambient sound loop.
    /// </summary>
    public void PlayAmbient(AudioClip clip)
    {
        if (_ambientSource == null || clip == null)
            return;

        _ambientSource.Clip = clip;
        _ambientSource.IsLooping = true;
        _ambientSource.Play();
        UpdateVolumes();
    }

    /// <summary>
    /// Play a one-shot sound effect at a world position.
    /// </summary>
    public void PlaySFX(AudioClip clip, Float3 position)
    {
        if (clip == null)
            return;

        // Use Flax's built-in spatial audio playback
        Audio.PlayOneShotAtPoint(clip, position, _sfxVolume * _masterVolume);
    }

    /// <summary>
    /// Play a non-spatial UI sound effect.
    /// </summary>
    public void PlayUISound(AudioClip clip)
    {
        if (clip == null)
            return;

        Audio.PlayOneShot(clip, _sfxVolume * _masterVolume);
    }

    public void StopMusic()
    {
        _musicSource?.Stop();
    }

    private void UpdateVolumes()
    {
        if (_musicSource != null)
            _musicSource.Volume = _musicVolume * _masterVolume;
        if (_ambientSource != null)
            _ambientSource.Volume = _ambientVolume * _masterVolume;
    }
}
