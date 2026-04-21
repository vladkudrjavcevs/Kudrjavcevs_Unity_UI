
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource sfxSource;
    public AudioClip buttonClick;
    public AudioClip[] characterSounds;

    public void PlayButtonClick()
    {
        sfxSource.PlayOneShot(buttonClick);
    }

    public void PlayCharacterSound(int index)
    {
        if (index >= 0 && index < characterSounds.Length)
            sfxSource.PlayOneShot(characterSounds[index]);
    }
}