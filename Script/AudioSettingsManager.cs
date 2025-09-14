using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettingsManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider musicSlider;
    public Slider sfxSlider;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (musicSlider != null && PlayerPrefs.HasKey("MusicVolume"))
        {
            float musicVolume = PlayerPrefs.GetFloat("MusicVolume");
            musicSlider.value = musicVolume;
            SetMusicVolume(musicVolume);
        }

        if (sfxSlider != null && PlayerPrefs.HasKey("SFXVolume"))
        {
            float sfxVolume = PlayerPrefs.GetFloat("SFXVolume");
            sfxSlider.value = sfxVolume;
            SetSFXVolume(sfxVolume);
        }
    }

    public void SetMusicVolume(float volume)
    {
        if (volume > 0)
            audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
        else
            audioMixer.SetFloat("MusicVolume", -80f); // أقل مستوى ممكن للصوت

        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    public void SetSFXVolume(float volume)
    {
        if (volume > 0)
            audioMixer.SetFloat("SFXVolume", Mathf.Log10(volume) * 20);
        else
            audioMixer.SetFloat("SFXVolume", -80f);

        PlayerPrefs.SetFloat("SFXVolume", volume);
    }
}
