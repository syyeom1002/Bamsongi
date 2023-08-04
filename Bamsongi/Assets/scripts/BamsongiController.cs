using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    private Rigidbody rBody;
    [SerializeField]
    private float fowoardForce = 2000;
    ParticleSystem effect;
    // Start is called before the first frame update

    private void Awake()
    {
        this.rBody = this.GetComponent<Rigidbody>();
        this.effect = this.GetComponent<ParticleSystem>();
        Debug.Log("Awake");
    }
    void Start()
    {
        Debug.Log("Start");
        //this.shoot();
    }
    public void Shoot(Vector3 force)
    {
        Debug.Log("Shoot");
        this.rBody.AddForce(force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Target")
        {
            Debug.Log("°ú³á¿¡ Ãæµ¹");
            this.rBody.isKinematic = true;// ¾Æ·¡·Î ¾È¶³¾îÁü 
            this.effect.Play();
        }
    }

}
