﻿namespace Survey_4216528;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        //MainPage = new AppShell();

        MainPage = new NavigationPage(new SurveysView());
    }
}
