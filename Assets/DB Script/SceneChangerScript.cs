using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChangerScript : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
