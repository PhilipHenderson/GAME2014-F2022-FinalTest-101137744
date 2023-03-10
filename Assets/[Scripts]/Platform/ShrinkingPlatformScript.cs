//////////////////////////////////////////////
///
/// Source File Name : GAME2014-F2022-FinalTest-101137744
/// Student Name: Philip Henderson
/// StudentID: 101137744
/// Last Date Modified: Decemeber 16th, 2022 Time: 4:30am
/// Program Description: Platformer Game, Added Floating, 
///                        Shrinking Platforms, Also Added Gems
/// Revision History:
///     V1.0 Added Shrinking Platforms
///     V1.1 Added Gems
///     V1.2 Added Sound Effects 
/// 
//////////////////////////////////////////////




using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingPlatformScript : MonoBehaviour
{
    public float shrinkFactor;
    public float shrinkSpeed;
    public bool onPlatform;

    private Vector3 originalScale;
    private Vector3 originalTransform;
    private SoundManager soundManager;

    private void Start()
    {
        originalScale = transform.localScale;
        soundManager = FindObjectOfType<SoundManager>();
    }


    public void OnCollisionEnter2D(Collision2D other)
    {
        onPlatform = true;
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        onPlatform = false;
    }

    private void Update()
    {
        if (onPlatform == true)
        {
            Shrink();
        }
        else
        {
            Grow();
        }
    }


    private void Shrink()
    {
        if (transform.localScale.x > 0 || transform.localScale.y > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x - shrinkFactor * shrinkSpeed * Time.deltaTime,
                                                   transform.localScale.y - shrinkFactor * shrinkSpeed * Time.deltaTime);
            soundManager.PlaySoundFX(Sound.SHRINK, Channel.PLATFORM);
        }
    }

    private void Grow()
    {
        if (transform.localScale.x < originalScale.x || transform.localScale.y < originalScale.y)
        {
            transform.localScale = new Vector3(transform.localScale.x + shrinkFactor * shrinkSpeed * Time.deltaTime,
                                            transform.localScale.y + shrinkFactor * shrinkSpeed * Time.deltaTime);
            soundManager.PlaySoundFX(Sound.GROW, Channel.PLATFORM);
        }
    }



}
