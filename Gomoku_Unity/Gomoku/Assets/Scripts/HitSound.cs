using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 生成時に音を鳴らすためのクラス
/// </summary>
public class HitSound : MonoBehaviour
{
    public AudioClip hitSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(hitSound);
    }
}
