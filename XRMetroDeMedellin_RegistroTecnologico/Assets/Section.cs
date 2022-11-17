using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section : MonoBehaviour
{
    public GameObject motorSectionPrefab;
    public GameObject motorCompletePrefab;
    //public Transform motorPosition;

    bool section = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!section)
        {
            Debug.Log("seccion");
            motorCompletePrefab.gameObject.SetActive(false);
            motorSectionPrefab.gameObject.SetActive(true);
            //Destroy(motorCompleteScene);
            section = true;

        }
        else
        {
            Debug.Log("completo");
            motorCompletePrefab.gameObject.SetActive(true);
            motorSectionPrefab.gameObject.SetActive(false);
            //Destroy(motorCompleteScene);
            section = false;
        }

    }
}
