using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    [Header("Music")]
    [SerializeField] private AudioClip musicClip;

    private AudioSource musicAudioSource;
    protected override void Awake()
    {
        musicAudioSource = GetComponent<AudioSource>();
        PlayMusic();
    }

    private void PlayMusic(){
        musicAudioSource.loop = true;
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
    }

    public void PlaySound(AudioClip clipToPlay, float volume)
    {
        AudioSource audioSource = null;
        audioSource.clip = clipToPlay;
        audioSource.volume = volume;
        audioSource.Play();

    }


}
