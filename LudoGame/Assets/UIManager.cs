using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{



    public GameObject landingScreen;
    public GameObject mainMenuCanvas;
    public GameObject settingsCanvas;
    public GameObject coinsPurchaseCanvas;
    public GameObject oneOnOne2pCanvas;
    public GameObject oneOnOne3pCanvas;
    public GameObject oneOnOne4pCanvas;
    public GameObject teamUpCanvas;
    public GameObject privTableCreate;
    public GameObject privTableJoin;
    public GameObject playOffline;
    public GameObject playWithComputer;
    public GameObject profileCanvas;
    public GameObject avatarSelect;
    public GameObject coinsPayment;

    // Start is called before the first frame update
    void Start()
    {
        //initial conditions setting everything false
        settingsCanvas.SetActive(false);
        coinsPurchaseCanvas.SetActive(false);
        oneOnOne2pCanvas.SetActive(false);
        oneOnOne3pCanvas.SetActive(false);
        oneOnOne4pCanvas.SetActive(false);
        teamUpCanvas.SetActive(false);
        privTableCreate.SetActive(false);
        privTableJoin.SetActive(false);
        playOffline.SetActive(false);
        playWithComputer.SetActive(false);
        profileCanvas.SetActive(false);
        avatarSelect.SetActive(false);
        coinsPayment.SetActive(false);


        //except the landing screen
        mainMenuCanvas.SetActive(true);

    }

    #region OnClick Shet

    public void coinsMenu()
    {
        mainMenuCanvas.SetActive(false);
        coinsPurchaseCanvas.SetActive(true);
    }

    public void closeButton()
    {
        // Close everything 
        settingsCanvas.SetActive(false);
        coinsPurchaseCanvas.SetActive(false);
        oneOnOne2pCanvas.SetActive(false);
        oneOnOne3pCanvas.SetActive(false);
        oneOnOne4pCanvas.SetActive(false);
        teamUpCanvas.SetActive(false);
        privTableCreate.SetActive(false);
        privTableJoin.SetActive(false);
        playOffline.SetActive(false);
        playWithComputer.SetActive(false);
        landingScreen.SetActive(false);
        profileCanvas.SetActive(false);
        avatarSelect.SetActive(false);
        coinsPayment.SetActive(false);


        //except the main menu
        mainMenuCanvas.SetActive(true);
    }

    public void settingsMenu()
    {
        settingsCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    public void oneOnOne2p()
    {
        mainMenuCanvas.SetActive(false);
        oneOnOne2pCanvas.SetActive(true);
        oneOnOne4pCanvas.SetActive(false);
        oneOnOne3pCanvas.SetActive(false);
    }

    public void oneOnOne3p()
    {
        mainMenuCanvas.SetActive(false);
        oneOnOne2pCanvas.SetActive(false);
        oneOnOne4pCanvas.SetActive(false);
        oneOnOne3pCanvas.SetActive(true);
        
    }

    public void oneOnOne4p()
    {
        mainMenuCanvas.SetActive(false);

        oneOnOne2pCanvas.SetActive(false);
        oneOnOne3pCanvas.SetActive(false);
        oneOnOne4pCanvas.SetActive(true);
    }

    public void PlayOfflineMenu()
    {
        playOffline.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    public void PlayWithCompMenu()
    {
        playWithComputer.SetActive(true);
        mainMenuCanvas.SetActive(false);

    }

    public void LoadMainMenu()
    {
        mainMenuCanvas.SetActive(true);
        landingScreen.SetActive(false);
    }

    public void TeamUpMenu()
    {
        teamUpCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false
);
    }

    public void PrivTableCreate()
    {
        privTableCreate.SetActive(true);

        mainMenuCanvas.SetActive(false);
        privTableJoin.SetActive(false);

    }

    public void PrivTableJoin()
    {
        privTableJoin.SetActive(true);

        privTableCreate.SetActive(false);
        mainMenuCanvas.SetActive(false);

    }

    public void YourProfile()
    {
        profileCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false); 
    }

    public void SelectAvatar()
    {
        avatarSelect.SetActive(true);
        profileCanvas.SetActive(false);
    }

    public void PayCoins()
    {
        coinsPayment.SetActive(true);
        coinsPurchaseCanvas.SetActive(false);
    }

    #endregion

}
