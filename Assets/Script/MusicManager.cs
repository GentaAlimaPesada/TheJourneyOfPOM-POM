using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance { get; private set; }

    [SerializeField] private AudioSource sfx;
    [SerializeField] private AudioSource bgm;
    [SerializeField] private AudioSource voice;

    public void PlaySfxOnce(AudioClip audioClip)
    {
        sfx.PlayOneShot(audioClip);
    }
    public void PlayBgmOnce(AudioClip audioClip)
    {
        bgm.PlayOneShot(audioClip);
    }
}
