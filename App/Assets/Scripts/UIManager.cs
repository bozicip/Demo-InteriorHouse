using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField] private TextMeshProUGUI txtDoors;
    public TextMeshProUGUI txtESC;
    public GameObject panelSelect;
    public static bool isLockAllControl = false;
    void Start()
    {
        instance = this;
    }
    public void ShowDoorNotice(bool openNotice)
    {
        txtDoors.gameObject.SetActive(openNotice);
    }
    public void onClosePanel()
    {
        panelSelect.gameObject.SetActive(false);
        isLockAllControl = false;
        txtESC.gameObject.SetActive(false);
    }
}
