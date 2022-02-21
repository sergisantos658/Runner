using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Resolution : MonoBehaviour
{
    // Start is called before the first frame update
    //public Dropdown resolutionDropDown;
    int qualityLevel;
    private void Start()
    {
         qualityLevel = QualitySettings.GetQualityLevel();
        QualitySettings.SetQualityLevel(2, true);
    }
    public void SetQuality(int index)
    {
        //bool fullscreen = Screen.fullScreen;
        Debug.Log(qualityLevel);
        QualitySettings.SetQualityLevel(2,true);
        Debug.Log(qualityLevel);
    }
}
