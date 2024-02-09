using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsController : MonoBehaviour
{
    public static SettingsController ThisInstance;
    private static bool MusicOn = true;
    
    // Start is called before the first frame update
    void Start()
    {
        if (ThisInstance == null)
        {
            ThisInstance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool IsMusicOn()
    {
        return MusicOn;
    }
}
