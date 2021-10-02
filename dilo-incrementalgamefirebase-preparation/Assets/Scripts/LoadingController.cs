using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingController : MonoBehaviour
{
    [SerializeField] private Button _localButton;
    [SerializeField] private Button _cloudButton;

    // Start is called before the first frame update
    void Start()
    {
        _localButton.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            UserDataManager.LoadFromLocal();
            SceneManager.LoadScene(1);
        });

        _cloudButton.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            StartCoroutine(UserDataManager.LoadFromCloud(() => SceneManager.LoadScene(1)));
        });

        // button didisable agar mencegah tidak terjadinya spam klik ketika
        // proses onclick pada button sedang berjalan



        //UserDataManager.Load();
        //SceneManager.LoadScene(1);
    }

    // men-disable button agar tidak bisa ditekan
    private void SetButtonInteractable(bool interactable)
    {
        _localButton.interactable = interactable;
        _cloudButton.interactable = interactable;
    }
}
