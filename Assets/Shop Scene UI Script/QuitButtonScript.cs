using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Onclick()
    {
        //문자열 이용해서 씬 전환
        //SceneManager.LoadScene("Stage1");
        SceneManager.LoadScene("HomeScene");
    }
}