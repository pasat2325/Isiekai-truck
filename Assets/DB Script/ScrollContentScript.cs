using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScrollContentScript : MonoBehaviour
{
    [SerializeField]
    private SkinDB skinDB;
    [SerializeField]
    private GameObject skinPrefab;
    [SerializeField]
    private GameObject parent;
    

    

    // Start is called before the first frame update
    void Awake()
    {
        int skinCount = skinDB.skinCount;

        for (int i = 0; i < skinCount; i++) {   
            NewSkinPrefabScript prefabScript = skinPrefab.GetComponent<NewSkinPrefabScript>();
            prefabScript.skinNumberChange(i);
            
            Instantiate(skinPrefab, parent.transform);;
            
        }
    }


}
