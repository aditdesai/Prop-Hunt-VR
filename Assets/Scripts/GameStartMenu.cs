using UnityEngine;
using UnityEngine.UI;

public class GameStartMenu : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject mainMenu;

    [Header("Main Menu Buttons")]
    public Button startButton;
    public Button quitButton;


    // Start is called before the first frame update
    void Start()
    {
        EnableMainMenu();

        //Hook events
        startButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(QuitGame);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        mainMenu.SetActive(false);
        SceneTransitionManager.singleton.GoToSceneAsync(1);
    }

    public void EnableMainMenu()
    {
        mainMenu.SetActive(true);
    }
}
