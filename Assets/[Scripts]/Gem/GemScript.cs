using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    private SoundManager soundManager;

    private void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        soundManager.PlaySoundFX(Sound.GEM, Channel.GEM);
        Destroy(gameObject);
    }
}
