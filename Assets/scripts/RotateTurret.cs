using UnityEngine;
using System.Collections;

public class RotateTurret : baseRotateTurret
{
    public Camera camera;
    
    // Use this for initialization
    

    // Update is called once per frame
    override protected void Update()
    {
        
        Vector3 mousePos = Input.mousePosition;   //{x.y.z}
        mousePos.z = camera.transform.position.y - turret.transform.position.y;

        Vector3 worldPos = camera.ScreenToWorldPoint(mousePos);

        targetPos = worldPos;
        base.Update();

        //print("worldPos" + worldPos);
    }

}