using UnityEngine;
using TMPro; // TMP 컴포넌트를 쓰기 위해 반드시 필요합니다!
using UnityEngine.UI;

public class MyPageManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("UI References")]
    [SerializeField] private TMP_InputField nicknameInputField;
    [SerializeField] private Image currentProfileImage;

    [Header("Modal Windows")]
    [SerializeField] private GameObject myPageModal;
    [SerializeField] private GameObject profileSelectSubModal;
    // 끄고 켤 마이페이지 모달 오브젝트를 인스펙터에서 연결할 변수

    private Sprite tempSelectedSprite;

    private string savedNickname = "Player123";
    private Sprite savedProfileSprite;

    // 버튼을 누르면 입력된 값을 출력하는 함수
    private void Start()
    {

        if (savedProfileSprite == null)
        {
            savedProfileSprite = currentProfileImage.sprite;
        }
        LoadUserData();
        profileSelectSubModal.SetActive(false);
    }

    public void LoadUserData()
    {
        nicknameInputField.text = savedNickname;
        if (savedProfileSprite != null)
        {
            currentProfileImage.sprite = savedProfileSprite;
            tempSelectedSprite = currentProfileImage.sprite;
        }

    }
    public void OnClickOpenProfileSelect()
    {
        if (profileSelectSubModal != null)
        {
            profileSelectSubModal.SetActive(true); // 서브 팝업 열기
        }
    }
    public void OnSelectProfile(Image clickedButtonImage)
    {
        if (clickedButtonImage == null) return;

        // 1. 임시 선택 이미지 변수에 저장
        tempSelectedSprite = clickedButtonImage.sprite;

        // 2. 메인 마이페이지 화면의 프로필 이미지 미리보기 변경
        currentProfileImage.sprite = tempSelectedSprite;

        // 3. 선택 완료했으니 서브 팝업 닫기
        OnClickCloseProfileSelect();
    }
    public void OnClickCloseProfileSelect()
    {
        if (profileSelectSubModal != null)
        {
            profileSelectSubModal.SetActive(false);
        }
    }


    // 저장 버튼 클릭 시 호출
    public void OnClickSave()
    {
        // 공백 검사
        if (string.IsNullOrEmpty(nicknameInputField.text.Trim()))
        {
            Debug.LogWarning("닉네임은 공백일 수 없습니다.");
            return;
        }
        savedProfileSprite = tempSelectedSprite;
        // 입력된 임시 데이터를 최종 저장
        savedNickname = nicknameInputField.text;

        Debug.Log($"프로필 저장 완료! 닉네임: {savedNickname}");
        myPageModal.SetActive(false);

        // (선택 사항) 저장 후 모달 닫기
        // CloseModal();
    }

    // 닫기 버튼 클릭 시 호출 (저장하지 않고 원상복구 후 닫기)
    public void OnClickClose()
    {
        LoadUserData(); // 직전에 저장되어 있던 데이터로 다시 덮어씌움
        myPageModal.SetActive(false); // 팝업 비활성화
    }
}
