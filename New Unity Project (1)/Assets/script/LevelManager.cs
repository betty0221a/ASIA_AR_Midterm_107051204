using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
public void NextLevel()
{

}
public void BackToMenu()
{
        SceneManager.LoadScene("選單");
}
public void QuitGame()
{
        Application.Quit();
}

}
