using UnityEngine;

public class sounds : MonoBehaviour
{
    public AudioSource jumpSound;
    public AudioSource barkSound;
    public AudioSource deathSound;
    public AudioSource backgroundSound;

    public void PlayJumpSound()
    {
        if (jumpSound != null)
            jumpSound.Play();
    }

    public void PlayBarkSound()
    {
        if (barkSound != null)
            barkSound.Play();
    }

    public void PlayDeathSound()
    {
        if (deathSound != null)
            deathSound.Play();
    }

    public void PlayBackgroundSound()
    {
        if (backgroundSound != null && !backgroundSound.isPlaying)
        {
            backgroundSound.Play();
        }
    }

    void Start()
    {
        PlayBackgroundSound();
    }
}
