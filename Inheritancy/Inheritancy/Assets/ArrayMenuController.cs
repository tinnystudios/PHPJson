using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMenuController : MonoBehaviour {

    //Static Menu Controller
    public static ArrayMenuController Instance;

    public PageView[] pages;
    public ArrayMenuButton[] menuButtons;

    private Dictionary<ArrayMenuButton, PageView> menuButtonLookUp = new Dictionary<ArrayMenuButton, PageView>();

    public PageView m_CurrentPage; //Active Page

    private void Awake()
    {
        Instance = this;

        pages = GetComponentsInChildren<PageView>(includeInactive:true);
        menuButtons = GetComponentsInChildren<ArrayMenuButton>(includeInactive: true);

        //Go through the menu buttons
        for (int i = 0; i < menuButtons.Length; i++) {
            //Add menu button relative to pages
            menuButtonLookUp.Add(menuButtons[i], pages[i]);
        }
    }

    public void GoToPageByMenuButton(ArrayMenuButton menuButton) {
        var menuButtonPage = menuButtonLookUp[menuButton];
        GoToPage(menuButtonPage);
    }

    public void GoToPage(PageView page) {
        m_CurrentPage.gameObject.SetActive(false);
        m_CurrentPage = page;
        m_CurrentPage.gameObject.SetActive(true);
    }

}
