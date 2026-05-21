using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class PopupManager : MonoBehaviour
{
    [Header("Modal Windows")]
    [SerializeField] private GameObject myPageModal;
    [SerializeField] private GameObject settingModal;

    private void Start()
    {
        HidePopup();
    }

    public void OnClickMyPage()
    {
        Debug.Log("Open MyPage");
        if (myPageModal != null) myPageModal.SetActive(true);
    }

    public void CloseMyPageModal()
    {
        if (myPageModal != null) myPageModal.SetActive(false);
    }

    public void OnClickSetting()
    {
        Debug.Log("Open Setting");
        if (settingModal != null) settingModal.SetActive(true);
    }

    public void CloseSettingModal()
    {
        if (settingModal != null) settingModal.SetActive(false);
    }
    public void HidePopup()
    {
        myPageModal.SetActive(false);
        settingModal.SetActive(false);
    }
}


