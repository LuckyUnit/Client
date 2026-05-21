using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LobbyUIManager : MonoBehaviour
{
    [Header("Stage Text")]
    [SerializeField] private TMP_Text currentStageText;
    [SerializeField] private TMP_Text bestStageText;

    

    [Header("Scene Names")]
    [SerializeField] private string gameSceneName = "GameScene";
    [SerializeField] private string rankingSceneName = "RankScene";
    [SerializeField] private string titleSceneName = "TitleScene";
    [SerializeField] private string lobbySceneName = "LobbyScene";

    private int currentWorld = 1;
    private int currentStage = 5;
    private int bestWorld = 2;
    private int bestStage = 3;

    private void Start()
    {
        UpdateStageUI();
    }

    private void UpdateStageUI()
    {
        if (currentStageText != null)
            currentStageText.text = "Stage " + currentWorld + "-" + currentStage;

        if (bestStageText != null)
            bestStageText.text = "Best " + bestWorld + "-" + bestStage;
    }

    // --- Button Functions ---

    

    public void OnClickTitle()
    {
        Debug.Log("Go to Title Scene");
        SceneManager.LoadScene(titleSceneName);
    }

    public void OnClickGameStart()
    {
        Debug.Log("Go to Game Scene");
        SceneManager.LoadScene(gameSceneName);
    }

    public void OnClickRanking()
    {
        Debug.Log("Go to Ranking Scene");
        SceneManager.LoadScene(rankingSceneName);
    }
    public void OnClickLobby()
    {
        Debug.Log("Go to Lobby Scene");
        SceneManager.LoadScene(lobbySceneName);
    }
}