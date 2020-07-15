using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Rigidbody rb;
    // Update is called once per frame
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        this.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        this.transform.position=(new Vector3(this.transform.position.x+this.transform.rotation.x%360/75,1, this.transform.position.z + this.transform.rotation.z % 360/160));

    }
}
