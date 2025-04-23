using UnityEngine;

public class PlayerAttackAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip attackSound1;
    public AudioClip attackSound2;
    public AudioClip attackSound3;

    public void PlayAttackSound1(){
        audioSource.PlayOneShot(attackSound1);
    }

    public void PlayAttackSound2(){
        audioSource.PlayOneShot(attackSound2);
    }

    public void PlayAttackSound3(){
        audioSource.PlayOneShot(attackSound3);
    }
}
