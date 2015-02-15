﻿using UnityEngine;
using System.Collections;

public class moveBullet : MonoBehaviour {
    public float speed;
    private float lifetime = 0f;
    public float maxLifeTime;
    public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float delta = Time.deltaTime;
        transform.Translate(Vector3.forward * speed * delta);
        lifetime += delta;
        if(lifetime > maxLifeTime)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter(Collision coll)
    { 
        Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    
    }
}
