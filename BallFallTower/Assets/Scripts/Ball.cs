using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(0f, jumpForce, 0f);

        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.07f,0f), Quaternion.Euler(90, 0f, 0f));
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log(materialName);

        if (materialName == "PlatformSafe (Insatance)")
        {
            // Continue
        }
        else if (materialName == "PlatformDanger (Insatance)")
        {
            //GameOver
        }
        else if (materialName == "LastRing (Insatance)")
        {
            //LevelPass
        }
    }
}
