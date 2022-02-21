using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volume : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer mixer;
    public Slider sliceV;

    public void SetVolume()
    {
        mixer.SetFloat("Music", Mathf.Log10(sliceV.value) * 20);

    }
}
