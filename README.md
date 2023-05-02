# Slayer-Tools
Repo for code that I can easily reuse across multiple Unity projects.
# Installing with Unity Package Manager
To install this project as a [Git dependency](https://docs.unity3d.com/Manual/upm-git.html) using the Unity Package Manager,
add the following line to your project's `manifest.json`:

```
"com.saberslay.slayertools": "https://github.com/saberslay/Slayer-Tools.git"
```

You will need to have Git installed and available in your system's PATH.

If you are using [Assembly Definitions](https://docs.unity3d.com/Manual/ScriptCompilationAssemblyDefinitionFiles.html) in your project, you will need to add `SlayerTools` and/or `SlayerToolsEditor` as Assembly Definition References.
