using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        ray = new Ray ();
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))

            {
            if (hit.collider.tag == "Alvo")
            {
         Debug.Log("Acertou");
         Destroy(hit.transform.gameObject);
        }

        }


        }


    }
}
