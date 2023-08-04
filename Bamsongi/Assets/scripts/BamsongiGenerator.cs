using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.red, 1f);

            Vector3 force = ray.direction.normalized * 2000f;
            this.CreateBamsongi(force);
        }

        
    }

    private void CreateBamsongi(Vector3 force)
    {
        GameObject go = Instantiate(this.bamsongiPrefab);
        //Debug.LogErrorFormat("广价捞 积己: {0}",go);
        BamsongiController controller = go.GetComponent<BamsongiController>();
        controller.Shoot(force);
    }
}
