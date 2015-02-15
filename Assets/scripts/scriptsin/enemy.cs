using UnityEngine;
using System.Collections;

public class enemy : tank {
    private float reloadTime;
    public float timeToReload;
    public GameObject bulletPrefab;
    private Transform turret;
    private Transform nozzle;
    public float shootingRange;
    public Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void DETERMINETARGET()
    {

      Ray myRay = new Ray();
      myRay.origin = turret.position;
      myRay.direction = turret.forward;

      RaycastHit hitInfo;

     if(Physics.Raycast(myRay, out hitInfo,shootingRange))
    {
       //print (hitInfo.collider.gameObject.name);
       string hitObjectName = hitInfo.collider.gameObject.name;
       if (hitObjectName == "tank") 
       {
            Instantiate(bulletPrefab, nozzle.position, nozzle.rotation);
            reloadTime = 0f;
    }
  }
    }
    
    
    void checkIfSeePlayer()
    {
        if (player != null)
        {
            targetPos = player.position;
            base.Update();
        }
    }
}
