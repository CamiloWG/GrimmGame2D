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
        volumeSlider.onValueChanged.AddListener(delegate { OnSliderValueChanged(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnSliderValueChanged()
    {
        bgSource.volume = volumeSlider.value;
    }

    
}
