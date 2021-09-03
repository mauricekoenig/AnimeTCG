

using UnityEngine;

public static class GameObjectExtensions
{
    public static void SetName (this GameObject gameObject, string name) {

        gameObject.name = name;
    }

    public static void SetPosition(this GameObject gameObject, Vector3 position) {

        gameObject.transform.position = position;
    }

    public static void SetRotation(this GameObject gameObject, Quaternion quaternion) {

        gameObject.transform.rotation = quaternion;
    }
}