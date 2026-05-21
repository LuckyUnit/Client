using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameStopManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Modal Windows")]
    [SerializeField] private GameObject GameStopModal;

    private void Start()
    {
        HidePopup();
    }

    public void OnClickGameStop()
    {
        Debug.Log("Open GameStop");
        if (GameStopModal != null) GameStopModal.SetActive(true);
    }

    public void CloseGameStopModal()
    {
        if (GameStopModal != null) GameStopModal.SetActive(false);
    }

    public void HidePopup()
    {
        GameStopModal.SetActive(false);

    }
}
