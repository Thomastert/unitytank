using UnityEngine;
using System.Collections;

public class destructibleobject : MonoBehaviour
{
    public int lives = 10;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void deadcontroler(Collision coll)
    {
        if (coll.gameObject.name == "kogel(Clone)")
        {
            lives--;
            if (lives <= 0)
            {
                Destroy(this.gameObject);

            }


        }
    }
}
