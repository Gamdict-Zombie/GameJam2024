using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject[] items; // 상점 아이템 프리팹들
    private GameObject selectedItem;
    private int selectedItemIdx = -1;  // 선택된 아이템 인덱스를 저장할 변수
    private bool isPlacingItem = false;
    public TMP_Text coin;
    public GameObject storeMenuBtns;
    public Button CreateTowerBtn;
    public Button EnhanceTowerBtn;
    public Button EnhancePlayerBtn;

    public GameObject createTowerBtns;
    public Button BackBtn_0;
    public GameObject EnhanceTowerBtns;
    public Button BackBtn_1;
    public GameObject EnhancePlayerBtns;
    public Button BackBtn_2;

    private Camera mainCamera;

    void Start()
    {
        CreateTowerBtn.onClick.AddListener(OnCreateTowerBtnClicked);
        EnhanceTowerBtn.onClick.AddListener(OnEnhanceTowerButtonClicked);
        EnhancePlayerBtn.onClick.AddListener(OnEnhancePlayerButtonClicked);
        BackBtn_0.onClick.AddListener(OnBackButtonClicked);
        BackBtn_1.onClick.AddListener(OnBackButtonClicked);
        BackBtn_2.onClick.AddListener(OnBackButtonClicked);

        mainCamera = Camera.main;
    }

    void OnCreateTowerBtnClicked()
    {
        createTowerBtns.SetActive(true);
        storeMenuBtns.SetActive(false);
    }

    void OnEnhanceTowerButtonClicked()
    {
        EnhanceTowerBtns.SetActive(true);
        storeMenuBtns.SetActive(false);
    }

    void OnEnhancePlayerButtonClicked()
    {
        EnhancePlayerBtns.SetActive(true);
        storeMenuBtns.SetActive(false);
    }

    void OnBackButtonClicked()
    {
        createTowerBtns.SetActive(false);
        EnhanceTowerBtns.SetActive(false);
        EnhancePlayerBtns.SetActive(false);
        storeMenuBtns.SetActive(true);
    }

    void Update()
    {
        if (isPlacingItem && selectedItem != null)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Mathf.Abs(mainCamera.transform.position.z);  // 카메라의 z 위치를 고려하여 조정

            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
            worldPosition.z = 0;  // 여기서 z를 0으로 설정합니다.
            selectedItem.transform.position = worldPosition;

            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                PlaceItem(worldPosition);
            }
        }
    }

    public void SelectItem(int itemIndex)
    {
        if (selectedItem != null)
        {
            Destroy(selectedItem);
        }

        selectedItem = Instantiate(items[itemIndex]);
        selectedItemIdx = itemIndex;
        isPlacingItem = true;
    }

    void PlaceItem(Vector3 position)
    {
        Instantiate(items[selectedItemIdx], position, Quaternion.identity);

        // 초기화
        Destroy(selectedItem);
        selectedItem = null;
        selectedItemIdx = -1;
        isPlacingItem = false;
    }
}
