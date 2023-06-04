using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        parent.transform.position = Vector2.MoveTowards(parent.transform.position, parent.transform.position + new Vector3(0f, 10f,0f), Time.deltaTime);
    }
}
