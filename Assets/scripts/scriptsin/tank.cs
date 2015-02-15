using UnityEngine;
using System.Collections;

public class tank : baseRotateTurret
{

    public GameObject bulletPrefab;
    private GameObject turret;
    private GameObject nozzle;
    public Camera camera;

    void findTurretNozzle()
    {
        Transform[] transforms = GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.gameObject.name == "turret")
            {
                turret = t.gameObject;
            }
            if (t.gameObject.name == "nozzle")
            {
                nozzle = t.gameObject;
            }
        }
    }
    void fireBullet()
    {
    if (Input.GetButtonDown("Fire1"))
        {
            Quaternion rotation = Quaternion.Euler(Vector3.up * turret.transform.rotation.eulerAngles.y);
            Instantiate(bulletPrefab, nozzle.transform.position, rotation);
        }
    }
    protected void aimTurret()
    {

        Vector3 mousePos = Input.mousePosition;   //{x.y.z}
        mousePos.z = camera.transform.position.y - turret.transform.position.y;

        Vector3 worldPos = camera.ScreenToWorldPoint(mousePos);

        targetPos = worldPos;
        base.Update();

        //print("worldPos" + worldPos);
    }
}
