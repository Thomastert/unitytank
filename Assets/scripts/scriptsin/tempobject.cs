using UnityEngine;
using System.Collections;

public class tempobject : MonoBehaviour {
    public float maxLiveTime;
    private float lifeTime;
    public float lightFade;
    private Light light;
    void removeAfterTime()
    {
        lifeTime += Time.deltaTime;
        if (lifeTime > maxLiveTime)
        {
            Destroy(this.gameObject);

        }


    }
}
