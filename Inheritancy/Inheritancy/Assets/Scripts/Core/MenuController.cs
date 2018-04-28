using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    //Static Menu Controller
    public static MenuController Instance;
    //Active Page
    public PageView m_CurrentPage;

    //Calls at the start of the object
    private void Awake()
    {
        ProcessSingleton();
        InitializePages();
    }

    public void InitializePages() {
        //Find all page views.
        PageView[] allPageViews = FindObjectsOfType<PageView>();

        //Deactivate pages
        for (int i = 0; i < allPageViews.Length; i++)
        {
            allPageViews[i].gameObject.SetActive(false);
        }

        //Run first page if it exists
        if (m_CurrentPage != null)
        {
            GoToPage(m_CurrentPage);
        }
    }

    public void ProcessSingleton() {
        //If another instance exist and it is not me, destroy myself
        if (Instance != null && Instance != this)
        {
            Destroy(Instance.gameObject);
        }

        //Assign instance to this
        Instance = this;
    }

    public void GoToPage(PageView page) {
        m_CurrentPage.gameObject.SetActive(false);
        m_CurrentPage = page;
        m_CurrentPage.gameObject.SetActive(true);
    }

}
