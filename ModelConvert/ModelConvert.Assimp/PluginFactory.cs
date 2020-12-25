using Assimp;
using ModelConvert.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace ModelConvert.Assimp
{
    internal class PluginFactory : IPluginFactory
    {
        List<IModelFormat> IPluginFactory.GetSupportedImportFormats()
        {
            var context = new AssimpContext();
            return context.GetSupportedImportFormats().Select<string, IModelFormat>(fileExtension =>
                new ModelFormat(GetFileDescription(fileExtension), fileExtension)
            ).ToList();
        }

        private static string GetFileDescription(string fileExtension)
        {
            switch(fileExtension)
            {
                case ".3ds": return "Autodesk 3DS Max File";
                case ".3mf": return "3D Manufacturing Format File";
                case ".ac":
                case ".ac3d": return "AC3D File";
                case ".amf": return "Additive Manufacturing Format File";
                case ".assbin": return "Allegorithmic Substance Painter Scene File";
                case ".b3d": return "Blitz3D File";
                case ".blend": return "Blender File";
                case ".bvh": return "Biovision Hierarchy Character Animation File";
                case ".csm": return "Character Studio Position Marker File";
                case ".dae": return "COLLADA (COLLAborative Design Activity) File";
                case ".dxf": return "AutoCAD Drawing Interchange Format File";
                case ".nff":
                case ".enff": return "Neutral File";
                case ".fbx": return "Autodesk FilmBox File";
                case ".glb": return "Binary Graphics Language Transmission Format File";
                case ".gltf": return "ASCII Graphics Language Transmission Format File";
                case ".ifc": return "Industry Foundation Classes File";
                case ".ifczip": return "Compressed Industry Foundation Classes File";
                case ".irr":
                case ".irrmesh": return "Irrlicht File";
                case ".mot":
                case ".lws":
                case ".lwo": return "LightWave 3D File";
                case ".lxo": return "Foundry Modo File";
                case ".md2": return "Quake 2 File";
                case ".md3": return "Quake 3 File";
                case ".md5anim": return "idTech4 Animation File";
                case ".md5camera": return "idTech4 Camera File";
                case ".md5mesh": return "idTech4 Mesh File";
                case ".mdl": return "Simulink File";
                case ".mesh":
                case ".mesh.xml": return "Godot Engine File";
                case ".ms3d": return "MilkShape 3D File";
                case ".ndo": return "3D Low-polygon Modeler File";
                case ".obj": return "Wavefront OBJ File";
                case ".off": return "Object Format File";
                case ".ogex": return "Open Game Engine Exchange File";
                case ".pk3": return "idTech4 File";
                case ".ply": return "Polygon Format File";
                case ".pmx": return "MikuMikuDance File";
                case ".prj": return "AutoCAD Project File";
                case ".q3o": return "Quick3D Model File";
                case ".q3s": return "Quick3D Scene File";
                case ".smd": return "Source Engine File";
                case ".stl": return "Standard Triangle Language File";
                case ".stp": return "STEP File";
                case ".vta": return "Valve Source Flex Animation Data File";
                case ".x": return "DirectX (Binnary/ASCII) File";
                case ".x3d": return "Extensible 3D Graphics File";
                default: return fileExtension.Substring(1).ToUpper() + " File";
            }
        }
    }
}