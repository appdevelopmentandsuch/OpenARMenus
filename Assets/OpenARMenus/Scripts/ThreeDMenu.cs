using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
[RequireComponent(typeof(Rigidbody))]
public class ThreeDMenu : MonoBehaviour
{

    //=====================================================//
    //======================COLLIDER=======================//
    //=====================================================//
    private BoxCollider collider = null;
    private const int COLLIDER_OFFSET = 5;

    //=====================================================//
    //=====================DIMENSIONS======================//
    //=====================================================//
    public int Width = 200;
    public int Height = 200;
    public float BackgroundScale = 1.2f;
    public int BackgroundDistance = 20;

    //=====================================================//
    //=======================COLORS========================//
    //=====================================================//
    public Color MenuColor = Color.clear;
    public Color MenuImageColor = Color.clear;
    public Color MenuImageFilledColor = Color.clear;
    public Color MainImageColor = Color.clear;
    public Color MainImageFilledColor = Color.clear;
    public Color BackgroundImageColor = Color.clear;
    public Color BackgroundImageFilledColor = Color.clear;
    public float MainImageFilledOpacity = 0.3f;
    public float BackgroundImageFilledOpacity = 0.3f;

    //=====================================================//
    //=======================IMAGES========================//
    //=====================================================//
    public Sprite MenuImage = null;
    public Sprite MenuImageFilled = null;
    public Sprite MainImage = null;
    public Sprite MainImageFilled = null;
    public Sprite BackgroundImage = null;
    public Sprite BackgroundImageFilled = null;

    //=====================================================//
    //====================GAME OBJECTS=====================//
    //=====================================================//
    private GameObject MenuBody = null;
    private GameObject MenuMain = null;
    private GameObject MenuMainFilled = null;
    private GameObject MenuBackground = null;
    private GameObject MenuBackgroundFilled = null;
    
    //=====================================================//
    //=======================METHODS=======================//
    //=====================================================//
    void Start()
    {
        InitMenuObjects();   
        InitMenuImages();
        InitMenuColors();
        InitDimensions();
        InitBoxCollider();
    }

    private void InitMenuObjects() {
        Utils utils = new Utils();

        if(MenuBody == null) {
            MenuBody = utils.FindObject(transform, "Menu Body");
        }

        if(MenuMain == null) {
            MenuMain = utils.FindObject(transform, "Menu Main");
        }

        if(MenuMainFilled == null) {
            MenuMainFilled = utils.FindObject(transform, "Menu Main Filled");
        }

        if(MenuBackground == null) {
            MenuBackground = utils.FindObject(transform, "Menu Background");
        }

        if(MenuBackgroundFilled == null) {
            MenuBackgroundFilled = utils.FindObject(transform, "Menu Background Filled");
        }
    }

    private void InitMenuImages() {
        if(MenuImage != null) {
            MenuMain.GetComponent<Image>().sprite = MenuImage;
            MenuBackground.GetComponent<Image>().sprite = MenuImage;
        }

        if(MenuImageFilled != null) {
            MenuMainFilled.GetComponent<Image>().sprite = MenuImageFilled;
            MenuBackgroundFilled.GetComponent<Image>().sprite = MenuImageFilled;
        }


        if(MainImage != null) {
            MenuMain.GetComponent<Image>().sprite = MainImage;
        }

        if(MainImageFilled != null) {
            MenuMainFilled.GetComponent<Image>().sprite = MainImageFilled;
        }

        if(BackgroundImage != null) {
            MenuBackground.GetComponent<Image>().sprite = BackgroundImage;
        }

        if(BackgroundImageFilled != null) {
            MenuBackgroundFilled.GetComponent<Image>().sprite = BackgroundImageFilled;
        }
    }

    private void InitMenuColors() {
        if(MenuColor == Color.clear) {
            MenuColor = Color.white;
        } else if(MenuColor != Color.clear) {
            MainImageColor = MenuColor;
            MainImageFilledColor = MenuColor;
            BackgroundImageColor = MenuColor;
            BackgroundImageFilledColor = MenuColor;
        }

        if(MenuImageColor != Color.clear) {
            MainImageColor = MenuImageColor;
            BackgroundImageColor = MenuImageColor;
        }
        if(MenuImageFilledColor != Color.clear) {
            MainImageFilledColor = MenuImageFilledColor;
            BackgroundImageFilledColor = MenuImageFilledColor;
        }

        MainImageFilledColor.a = MainImageFilledOpacity;
        BackgroundImageFilledColor.a = BackgroundImageFilledOpacity;
        MenuMain.GetComponent<Image>().color = MainImageColor;
        MenuMainFilled.GetComponent<Image>().color = MainImageFilledColor;
        MenuBackground.GetComponent<Image>().color = BackgroundImageColor;
        MenuBackgroundFilled.GetComponent<Image>().color = BackgroundImageFilledColor;
    }

    private void InitDimensions() {
        MenuMain.GetComponent<RectTransform>().sizeDelta = new Vector2(Width, Height);
        MenuBackground.transform.localPosition = new Vector3(0,0,BackgroundDistance);
        MenuBackground.transform.localScale = new Vector3(BackgroundScale,BackgroundScale,BackgroundScale);
    }

    private void InitBoxCollider() {
        collider = GetComponent<BoxCollider>();
        collider.size = new Vector3((Width * BackgroundScale) + COLLIDER_OFFSET, (Height * BackgroundScale) + COLLIDER_OFFSET, BackgroundDistance + COLLIDER_OFFSET);
        collider.center = new Vector3(0,0,BackgroundDistance / 2);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!");
    }
}
