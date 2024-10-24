using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject finishPanel;
    IEnumerator DisableStartPrompt()
    {
        yield return new WaitForSeconds(10);
        startPanel.SetActive(false);
    }

    private void Start()
    {
        startPanel.SetActive(true);
        finishPanel.SetActive(false);
        StartCoroutine(DisableStartPrompt());
    }

    public void OnFinish()
    {
        startPanel.SetActive(false);
        finishPanel.SetActive(true);
    }
}
