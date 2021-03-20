using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct SoundFXDefinition
{
    public SoundEffect Effect;
    public AudioClip Clip;
    public AudioSource AudioSource;
}

[System.Serializable]
public enum SoundEffect
{
    PlayerSteps,
    PlayerJump,
    PlayerColliding,
    PlayerPlaneWind,
    PlayerBoatCracks,
    PlayerFolding,
    PlayerWaterSplash
}

[System.Serializable]
public enum MusicClip
{
    MainThemeHalf,
    MainThemeComplete,
    Anthro01_01,
    Anthro01_02,
    Anthro02_01,
    Anthro02_02,
    Anthro02_03,
    Boat01_01,
    Boat01_02,
    Boat02_01,
    Boat02_02,
    Boat02_03,
    Plane01_01,
    Plane01_02,
    Plane02_01,
    Plane02_02,
    Narration
}

[System.Serializable]
public struct MusicClipDefinition
{
    public MusicClip musicCue;
    public AudioClip clip;
    public float fadeInCue, fadeOutCue, endVolCue;
    [Range(0, 1)]
    public float maxVolume;
}
