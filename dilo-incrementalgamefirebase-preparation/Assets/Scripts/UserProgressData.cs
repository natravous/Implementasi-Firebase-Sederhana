using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //menambahkan System.Serializable agar object nantinya dapat di-serialize menjadi string untuk disimpan 
//dan kemudian di-deserialize kembali menjadi object untuk di-load.
public class UserProgressData
{
    public double Gold = 0;
    public List<int> ResourcesLevels = new List<int>();
}
