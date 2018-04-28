using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMenuController : MonoBehaviour {

    //Static access
    public static ArrayMenuController Instance;
    //Pages
    public PageView[] pages;
    //Menu buttons
    public ArrayMenuButton[] menuButtons;
    //Lookup - link between MenuButton & PageView
    private Dictionary<ArrayMenuButton, PageView> menuButtonLookUp = new Dictionary<ArrayMenuButton, PageView>();
    //CurrentPage
    public PageView m_CurrentPage;

    private void Awake()
    {
        //Assign Instance
        Instance = this;
        //Find pages inside menu controller and include inactive objects
        pages = GetComponentsInChildren<PageView>(includeInactive:true);
        //Find menu buttons
        menuButtons = GetComponentsInChildren<ArrayMenuButton>(includeInactive: true);

        //Go through the menu buttons
        for (int i = 0; i < menuButtons.Length; i++) {
            //Add menu button relative to pages
            menuButtonLookUp.Add(menuButtons[i], pages[i]);
            //Turn off the page
            pages[i].gameObject.SetActive(false);
        }

        //Show the current page
        GoToPage(m_CurrentPage);
    }

    //Open a page using a menu button
    public void GoToPageByMenuButton(ArrayMenuButton menuButton) {
        var menuButtonPage = menuButtonLookUp[menuButton];
        GoToPage(menuButtonPage);
    }

    //Go to a page using a pageView
    public void GoToPage(PageView page) {
        m_CurrentPage.gameObject.SetActive(false);
        m_CurrentPage = page;
        m_CurrentPage.gameObject.SetActive(true);
    }

}
