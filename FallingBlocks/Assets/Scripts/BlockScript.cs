using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float doneZone;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < doneZone)
        {
            Destroy(gameObject);
        }
    }
}
