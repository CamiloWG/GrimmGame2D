using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;

    public AudioSource bgSource;
    public AudioSource effectSource;

    public AudioClip jump;
    public AudioClip coin;



    public AudioClip deathGretel;
    public AudioClip deathHansel;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else Destroy(instance);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlaySound(AudioClip clip)
    {
        effectSource.PlayOneShot(clip);
    }


    public void PlayJump()
    {
        PlaySound(jump);
    }

    public void PlayCoin()
    {
        PlaySound(coin);
    }

    public void PlayDeath(PlayerInfo player)
    {
        if(player.female)
        {
            PlaySound(deathGretel);
        } else PlaySound(deathHansel);
    }
}
