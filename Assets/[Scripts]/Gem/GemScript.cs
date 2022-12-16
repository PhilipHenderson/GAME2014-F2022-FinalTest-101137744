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
