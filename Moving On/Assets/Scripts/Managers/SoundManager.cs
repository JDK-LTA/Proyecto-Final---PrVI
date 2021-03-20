using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : Manager<SoundManager>
{
    [SerializeField] private List<SoundFXDefinition> soundFX;

    [SerializeField] private List<MusicClipDefinition> musics;
    [SerializeField] private AudioSource musicSource;
    [HideInInspector] public AudioSource narrationSource;
    [SerializeField] public float maxGlobalVolume = 1, sfxVolume = 1, musicVolume = 1;
    private float actualSfxVol = 1, actualMusicVol = 1;

    private bool fadingIn = false, fadingOut = false;
    private float fadeTimer = 0;
    private MusicClipDefinition activeClip;

    public void GetSoundEffect(SoundEffect soundEffect, AudioSource effectsSource)
    {
        SoundFXDefinition sound = soundFX.Find(sfx => sfx.Effect == soundEffect);
        AudioClip effect = sound.Clip;
        effectsSource.clip = effect;
    }

    public void PlayMusic(MusicClip musicClip)
    {
        activeClip = musics.Find(mc => mc.musicCue == musicClip);
        if (!musicSource.isPlaying)
        {
            musicSource.PlayOneShot(activeClip.clip);
        }
        fadingIn = true;
        musicSource.volume = 0;
    }
    public void PlayNarration()
    {
        narrationSource.Play();
    }

    private void Update()
    {
        if (!fadingOut && musicSource.isPlaying && musicSource.time > activeClip.fadeOutCue)
        {
            fadingOut = true;
        }

        if (fadingIn)
        {
            fadeTimer += Time.deltaTime;
            musicSource.volume = Mathf.Lerp(0, activeClip.maxVolume * actualMusicVol, fadeTimer / activeClip.fadeInCue);
            if (fadeTimer >= activeClip.fadeInCue)
            {
                fadingIn = false;
                fadeTimer = 0;
                musicSource.volume = activeClip.maxVolume * actualMusicVol;
            }
        }
        else if (fadingOut)
        {
            fadeTimer += Time.deltaTime;
            musicSource.volume = Mathf.Lerp(activeClip.maxVolume * actualMusicVol, 0, fadeTimer - activeClip.fadeOutCue / activeClip.endVolCue - activeClip.fadeOutCue);
            if (fadeTimer >= activeClip.endVolCue - activeClip.fadeOutCue)
            {
                fadingOut = false;
                fadeTimer = 0;
                musicSource.volume = 0;
            }
        }
    }

    public void UpdateGlobalVolume()
    {
        UpdateSFXVolume();
        UpdateMusicVolume();
    }
    public void UpdateSFXVolume()
    {
        actualSfxVol = sfxVolume * maxGlobalVolume;

        foreach (SoundFXDefinition sfx in soundFX)
        {
            sfx.AudioSource.volume *= actualSfxVol;
        }
    }
    public void UpdateMusicVolume()
    {
        actualMusicVol = musicVolume * maxGlobalVolume;

        musicSource.volume *= actualMusicVol;
    }
}
