using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro; 

public class HomeGM : MonoBehaviour
{
    public Button playButton;
    public Button enhanceButton;
    public Button settingButton;
    public Button exitButton;
    public Button nextStageButton;
    public Button beforeStageButton;
    public TMP_Text stageText;

    private int currentStage = 1;

    void Start()
    {
        playButton.onClick.AddListener(OnplayButtonClicked);
        enhanceButton.onClick.AddListener(OnEnhanceButtonClicked);
        settingButton.onClick.AddListener(OnSettingButtonClicked);
        nextStageButton.onClick.AddListener(OnNextStageButtonClicked);
        beforeStageButton.onClick.AddListener(OnBeforeStageButtonClicked);

        UpdateStageText();
    }

    void OnplayButtonClicked()
    {
        // 예시로 'GameScene'이라는 이름의 씬을 로드합니다.
        Debug.Log("Play Button Clicked");
        // SceneManager.LoadScene("SampleScene"); 
        SceneManager.LoadScene(currentStage.ToString()); 
    }

    void OnEnhanceButtonClicked()
    {
        // Enhance 버튼 클릭 시 동작 정의
        Debug.Log("Enhance Button Clicked");
    }
    void OnExitButtonClicked()
    {
        Debug.Log("Exit Button Clicked");
        // Application.Quit();
    }

    void OnSettingButtonClicked()
    {
        // Setting 버튼 클릭 시 동작 정의
        Debug.Log("Setting Button Clicked");
    }

    void OnNextStageButtonClicked()
    {
        currentStage++;
        UpdateStageText();
    }

    void OnBeforeStageButtonClicked()
    {
        if (currentStage > 1)
        {
            currentStage--;
            UpdateStageText();
        }
    }

    void UpdateStageText()
    {
        stageText.text = "Stage " + currentStage;
    }
}
