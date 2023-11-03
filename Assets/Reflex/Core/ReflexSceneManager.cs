using System;
using JetBrains.Annotations;
using Reflex.Injectors;
using UnityEngine.SceneManagement;

namespace Reflex.Core
{
    public static class ReflexSceneManager
    {
        [PublicAPI]
        public static void PreInstallScene(Scene scene, Action<ContainerDescriptor> builder)
        {
            UnityInjector.ScenePreInstaller.Add(scene, builder);
        }
    }
}