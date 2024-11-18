using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : BaseButton
{
    [SerializeField] private int _indexMainMenu;
    protected override void OnClick()
    {
        SceneManager.LoadScene(_indexMainMenu);
    }
}
