using UnityEngine;

namespace Services.Assests
{
    public interface IAssetsProvider
    {
        GameObject InstantiateEntity(string path);
    }
}