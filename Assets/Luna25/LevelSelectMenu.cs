using UnityEngine;


using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public void LoadLevelScene(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    public void LoadNextScene()
    {
        var ActiveScenename = SceneManager.GetActiveScene().name;
        var y = int.Parse(ActiveScenename);
        var z = y + 1;
       var levelName = z.ToString();
        SceneManager.LoadScene(levelName);
    }
}