using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScrollContentScript : MonoBehaviour
{
    [SerializeField]
    SkinManagerScript skinManager;

    
    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = skinManager.selectedArtwork;
        Vector3 position = new Vector3(0,0,0);
        Quaternion rotation = new Quaternion(0,0,0,0);

        GameObject newObject = Instantiate(prefab, position, rotation);
    }


}
