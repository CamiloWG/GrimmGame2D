using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource bgSource;
    public AudioSource effectSource;

    public AudioClip jump;
    public AudioClip coin;

    public Slider volumeSlider;

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
        volumeSlider.value = bgSource.volume;
        effectSource.volume = bgSource.volume;
        volumeSlider.onValueChanged.AddListener(x => OnSliderValueChanged(x));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnSliderValueChanged(float volumen)
    {
        bgSource.volume = volumen;
        effectSource.volume = volumen;
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
    
}
