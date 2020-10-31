using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
[RequireComponent(typeof(Rigidbody))]
public class TwoDMenu : MonoBehaviour
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
    //=====================================================//
    //=======================COLORS========================//
    //=====================================================//
    public Color MenuColor = Color.clear;
    public Color MenuImageColor = Color.clear;
    public Color MenuImageFilledColor = Color.clear;
    
    //=====================================================//
    //=======================IMAGES========================//
    //=====================================================//
    public Sprite MenuImage = null;
    public Sprite MenuImageFilled = null;

    //=====================================================//
    //====================GAME OBJECTS=====================//
    //=====================================================//
    private GameObject MenuBody = null;
    private GameObject MenuMain = null;
    private GameObject MenuMainFilled = null;
    
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
    }

    private void InitMenuImages() {
        if(MenuImage != null) {
            MenuMain.GetComponent<Image>().sprite = MenuImage;
        }

        if(MenuImageFilled != null) {
            MenuMainFilled.GetComponent<Image>().sprite = MenuImageFilled;
        }
    }

    private void InitMenuColors() {
        if(MenuColor == Color.clear) {
            MenuColor = Color.white;
        } else if(MenuColor != Color.clear) {
            MenuImageColor = MenuColor;
            MenuImageFilledColor = MenuColor;
        }

        if(MenuImageColor == Color.clear) {
            MenuImageColor = Color.white;
        }

        if(MenuImageFilledColor == Color.clear) {
            MenuImageFilledColor = Color.white;
        }

        MenuImageFilledColor.a = 0.3f;
        MenuMain.GetComponent<Image>().color = MenuImageColor;
        MenuMainFilled.GetComponent<Image>().color = MenuImageFilledColor;
    }

    private void InitDimensions() {
        MenuMain.GetComponent<RectTransform>().sizeDelta = new Vector2(Width, Height);
    }

    private void InitBoxCollider() {
        collider = GetComponent<BoxCollider>();
        collider.size = new Vector3(Width + COLLIDER_OFFSET, Height + COLLIDER_OFFSET, COLLIDER_OFFSET);
        collider.center = new Vector3(0,0,0);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!");
    }
}
