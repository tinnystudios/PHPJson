﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    //Static Menu Controller
    public static MenuController Instance;

    public PageView m_HomePage;
    public PageView m_GamePage;
    public PageView m_AboutPage;

    public PageView m_CurrentPage; //Active Page

    //Calls at the start of the object
    private void Start()
    {
        //If another instance exist and it is not me, destroy myself
        if (Instance != null && Instance != this) {
            Destroy(Instance.gameObject);
        }

        //We assigned ourself to MenuControllerStaticInstance
        Instance = this;

        //Find all page views.
        PageView[] allPageViews = FindObjectsOfType<PageView>();

        //Loop through all elements of allPageViews
        for (int i = 0; i < allPageViews.Length; i++) {
            allPageViews[i].gameObject.SetActive(false);
        }
    }

    public void GoToPage(PageView page) {
        m_CurrentPage.gameObject.SetActive(false);
        m_CurrentPage = page;
        m_CurrentPage.gameObject.SetActive(true);
    }

    public static void GoToHomePage() {
        Instance.GoToPage(Instance.m_HomePage);
    }

}
