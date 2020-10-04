using UnityEngine.SceneManagement;
using UnityEngine;

public class sceneloader : MonoBehaviour
{
    public int scene;
    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
