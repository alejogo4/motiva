using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonScript : MonoBehaviour
{
    public bool estado = false;

    public GameObject target;

    void Start()
    {
        target =  GameObject.Find("ARCamera");
    }
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.3f);
        StartCoroutine(DestruirObjeto());
        transform.LookAt(target.transform);      
        


    }

    IEnumerator DestruirObjeto()
    {
        yield return new WaitForSeconds(3);
        
        Destroy(gameObject);

    }
}
