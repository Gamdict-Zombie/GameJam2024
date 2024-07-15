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
    

    void Start()
    {
        CreateTowerBtn.onClick.AddListener(OnCreateTowerBtnClicked);
        EnhanceTowerBtn.onClick.AddListener(OnEnhanceTowerButtonClicked);
        EnhancePlayerBtn.onClick.AddListener(OnEnhancePlayerButtonClicked);
        BackBtn_0.onClick.AddListener(OnBackButtonClicked);
        BackBtn_1.onClick.AddListener(OnBackButtonClicked);
        BackBtn_2.onClick.AddListener(OnBackButtonClicked);
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
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;
            selectedItem.transform.position = mousePosition;

            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                PlaceItem();
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
        isPlacingItem = true;
    }

    void PlaceItem()
    {
        // 아이템을 배치할 위치를 결정하고, 필요한 로직을 추가합니다.
        isPlacingItem = false;
        selectedItem = null;
    }
}
