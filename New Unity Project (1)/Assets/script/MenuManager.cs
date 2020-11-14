
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
   public void StartGame()
    {
        print("開始遊戲");
        SceneManager.LoadScene("關卡1");

           
    }

    // Update is called once per frame
   public void QuitGame()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
