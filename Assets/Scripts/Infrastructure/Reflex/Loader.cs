using Plugins.MonoCache;
using Reflex.Core;
using UnityEngine.SceneManagement;

namespace Infrastructure.Reflex
{
    public class Loader : MonoCache
    {
        private void Start()
        {
            Scene scene = SceneManager.LoadScene(Constants.MainScene, new LoadSceneParameters(LoadSceneMode.Single));
            
            ReflexSceneManager.PreInstallScene(scene, builder =>
                builder.AddInstance(""));
        }
    }
}