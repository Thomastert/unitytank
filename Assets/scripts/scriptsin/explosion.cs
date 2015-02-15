using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
    public float maxLiveTime;
    private float lifeTime;
    public float lightFade;
    private Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }

    void fadeExplosion() 
    {
        light.intensity += lightFade;


       
    
    }
	
}
