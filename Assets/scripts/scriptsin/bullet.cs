using UnityEngine;
using System.Collections;

public class bullet : explosion {
    public float speed;
    private float lifetime = 0f;
    public float maxLifeTime;
    public GameObject explosionPrefab;

    void moveBullet()
    {
        float delta = Time.deltaTime;
        transform.Translate(Vector3.forward * speed * delta);
        lifetime += delta;
        if (lifetime > maxLifeTime)
        {
            Destroy(this.gameObject);
        }
    }
        void RemoveOnImpact(Collision coll)
    { 
        Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    
    }
    
}
