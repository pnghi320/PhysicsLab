using System;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string soundEffectsPref = "soundEffectsPref";
    private float soundEffectFloat;

    public AudioSource[] soundEffectsAudio;


    private void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        soundEffectFloat = PlayerPrefs.GetFloat(soundEffectsPref);
        Debug.Log(soundEffectFloat);

        for (int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = soundEffectFloat;
        }
    }
}
