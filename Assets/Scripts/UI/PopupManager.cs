using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public static PopupManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void OpenPopup(string popupName)
    {
        Debug.Log("Popup açıldı: " + popupName);
    }

    public void ClosePopup(string popupName)
    {
        Debug.Log("Popup kapandı: " + popupName);
    }
}