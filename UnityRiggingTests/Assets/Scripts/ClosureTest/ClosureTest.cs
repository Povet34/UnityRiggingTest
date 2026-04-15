using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosureTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var refInt = new RefValue<int>(1);
    }
}


public class RefValue<T>
{
    public T value;
    public RefValue(T v = default) { value = v; }
    public static implicit operator T(RefValue<T> r) => r.value;
}