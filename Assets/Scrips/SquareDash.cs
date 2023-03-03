using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareDash : MonoBehaviour
{
    public float delay;
    private float delaySeconds;
    public GameObject obj;
    public Movement jump;
    void Start()
    {
        delaySeconds = delay;
        
    }

    // Update is called once per frame
    void Update()
    {   if (jump.jump)
        {
            if (delaySeconds > 0)
            {
                delaySeconds -= Time.deltaTime;
            }
            else
            {
                GameObject currentObj = Instantiate(obj, transform.position, transform.rotation);
                delaySeconds = delay;
                Destroy(currentObj, 0.35f);
            }
        }
        
    }
}
