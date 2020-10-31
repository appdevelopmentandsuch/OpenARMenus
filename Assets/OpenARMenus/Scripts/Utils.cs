using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class Utils
{
    
    public GameObject FindObject(Transform transform, string objectName) {
        GameObject foundObject = null;
        Transform foundTransform = transform.Find(objectName);
        if(foundTransform != null) {
        foundObject = foundTransform.gameObject;
        } else {
            foreach(Transform child in transform) {
                foundObject = FindObject(child, objectName);
                if(foundObject != null) {
                    break;
                }
            }
        }
        return foundObject;
    }
}
