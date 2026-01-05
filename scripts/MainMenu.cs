using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject player;

    public void StartGame()
    {
        player.GetComponent<AutoMove>().BeginMovement();
    }

    public void ExitGame()
    {
        Debug.Log("Oyun kapatýlýyor...");
        Application.Quit();
    }
}