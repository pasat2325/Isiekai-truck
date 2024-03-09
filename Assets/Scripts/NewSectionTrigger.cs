using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class NewSectionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject roadSection;
    public GameObject roadClone;
    public float loc;
    public int loc_multiplier = 1;
    public void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Trigger"))
        {
            roadClone = Instantiate(roadSection,new Vector3(0,0,loc * loc_multiplier), Quaternion.Euler(new Vector3(0, 270, 0)));
            loc_multiplier++;
            Destroy(roadClone,20);
        }
    }
}
