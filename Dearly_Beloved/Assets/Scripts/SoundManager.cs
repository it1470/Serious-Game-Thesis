using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeVolume()
    {
           //HEY this is a test to now what we are woking on the proto branch//
        AudioListener.volume = volumeSlider.value;
    }
}
