using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engine : MonoBehaviour
{
    public float speed = 10;
    Rigidbody myRigi;
    public PhysicMaterial carMat;
    // Use this for initialization
    void Start()
    {
        myRigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        carMat.dynamicFriction = 1 - (Mathf.Abs(Input.GetAxis("Vertical")));

        if (Input.GetKey(KeyCode.W))
        {
            myRigi.AddRelativeForce(Vector3.forward * 3 * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            myRigi.AddRelativeForce(Vector3.back * 3 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myRigi.AddRelativeTorque(Vector3.up * 50 * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            myRigi.AddRelativeTorque(Vector3.down * 50 * speed * Time.deltaTime);
        }
    }
}
