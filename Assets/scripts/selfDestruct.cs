using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {
    public float maxLiveTime;
    private float lifeTime;
    public float lightFade;
    private Light light;
	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        light.intensity += lightFade;


        lifeTime += Time.deltaTime;
        if (lifeTime > maxLiveTime) 
        {
            Destroy(this.gameObject);
        
        }
	}
}
