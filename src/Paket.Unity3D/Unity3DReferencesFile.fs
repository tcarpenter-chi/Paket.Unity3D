﻿/// Utilities to install Paket dependencies into Unity3D projects 
namespace Paket.Unity3D

open Paket.Utils
open System.IO

/// Represents paket.unity3d.references file
type Unity3DReferencesFile = 
    {
        ReferencesFile:Paket.ReferencesFile
        UnityAssetsDir:string
    }
    static member FindAllReferencesFiles(folder) =
        FindAllFiles(folder, Constants.Unity3DReferencesFile) 
        |> Seq.map (fun fi -> {ReferencesFile=Paket.ReferencesFile.FromFile fi.FullName
                               UnityAssetsDir=Path.Combine(fi.DirectoryName, "Assets")})
