using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private float sfxfloatTracker;
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string soundEffectsPref = "soundEffectsPref";
    private int firstPlayInt;

    public Slider soundEffectsSlider;
    private float soundEffectFloat;

    public AudioSource[] soundEffectsAudio;
    public AudioSource sfxSound;


    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if(firstPlayInt == 0)
        {
            soundEffectFloat = 0.25f;
            soundEffectsSlider.value = soundEffectFloat;
            PlayerPrefs.SetFloat(soundEffectsPref, soundEffectFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);

        } else
        {
            soundEffectFloat = PlayerPrefs.GetFloat(soundEffectsPref);
            soundEffectsSlider.value = soundEffectFloat;

        }

        sfxfloatTracker = soundEffectFloat;

    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(soundEffectsPref, soundEffectsSlider.value);
    }

    public void OnApplicationFocus(bool focus)
    {
        if(!focus)
        {
            SaveSoundSettings();
        }
    }

    public void saveBackButton()
    {
        SaveSoundSettings();
        Debug.Log(PlayerPrefs.GetFloat(soundEffectsPref));
    }

    public void UpdateSound()
    {
        for(int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = soundEffectsSlider.value;
        }

        // Play sound at certain intervals
        if (sfxfloatTracker + 0.1f < soundEffectsSlider.value || sfxfloatTracker - 0.1f > soundEffectsSlider.value)
        {
            sfxfloatTracker = soundEffectsSlider.value;
            playSFX(soundEffectsSlider.value);
        }

        Debug.Log(soundEffectFloat);
    }

    public void playSFX(float volume)
    {
        sfxSound.volume = volume;
        sfxSound.Play();
    }

}
