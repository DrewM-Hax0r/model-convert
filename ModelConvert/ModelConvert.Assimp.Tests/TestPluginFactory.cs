using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelConvert.Abstractions;

namespace ModelConvert.Assimp.Tests
{
    [TestClass]
    public class TestPluginFactory
    {

        private readonly IPluginFactory PluginFactory;

        public TestPluginFactory()
        {
            this.PluginFactory = new PluginFactory();
        }

        [TestMethod]
        public void SupportedImportFormats()
        {
            var supportedFormats = this.PluginFactory.GetSupportedImportFormats();

            Assert.AreEqual(66, supportedFormats.Count);
            AssertModelFormat(supportedFormats[0], "3D File", ".3d");
            AssertModelFormat(supportedFormats[1], "Autodesk 3DS Max File", ".3ds");
            AssertModelFormat(supportedFormats[2], "3D Manufacturing Format File", ".3mf");
            AssertModelFormat(supportedFormats[3], "AC3D File", ".ac");
            AssertModelFormat(supportedFormats[4], "AC3D File", ".ac3d");
            AssertModelFormat(supportedFormats[5], "ACC File", ".acc");
            AssertModelFormat(supportedFormats[6], "Additive Manufacturing Format File", ".amf");
            AssertModelFormat(supportedFormats[7], "ASE File", ".ase");
            AssertModelFormat(supportedFormats[8], "ASK File", ".ask");
            AssertModelFormat(supportedFormats[9], "Allegorithmic Substance Painter Scene File", ".assbin");
            AssertModelFormat(supportedFormats[10], "Blitz3D File", ".b3d");
            AssertModelFormat(supportedFormats[11], "Blender File", ".blend");
            AssertModelFormat(supportedFormats[12], "Biovision Hierarchy Character Animation File", ".bvh");
            AssertModelFormat(supportedFormats[13], "COB File", ".cob");
            AssertModelFormat(supportedFormats[14], "Character Studio Position Marker File", ".csm");
            AssertModelFormat(supportedFormats[15], "COLLADA (COLLAborative Design Activity) File", ".dae");
            AssertModelFormat(supportedFormats[16], "AutoCAD Drawing Interchange Format File", ".dxf");
            AssertModelFormat(supportedFormats[17], "Neutral File", ".enff");
            AssertModelFormat(supportedFormats[18], "Autodesk FilmBox File", ".fbx");
            AssertModelFormat(supportedFormats[19], "Binary Graphics Language Transmission Format File", ".glb");
            AssertModelFormat(supportedFormats[20], "ASCII Graphics Language Transmission Format File", ".gltf");
            AssertModelFormat(supportedFormats[21], "HMP File", ".hmp");
            AssertModelFormat(supportedFormats[22], "Industry Foundation Classes File", ".ifc");
            AssertModelFormat(supportedFormats[23], "Compressed Industry Foundation Classes File", ".ifczip");
            AssertModelFormat(supportedFormats[24], "Irrlicht File", ".irr");
            AssertModelFormat(supportedFormats[25], "Irrlicht File", ".irrmesh");
            AssertModelFormat(supportedFormats[26], "LightWave 3D File", ".lwo");
            AssertModelFormat(supportedFormats[27], "LightWave 3D File", ".lws");
            AssertModelFormat(supportedFormats[28], "Foundry Modo File", ".lxo");
            AssertModelFormat(supportedFormats[29], "Quake 2 File", ".md2");
            AssertModelFormat(supportedFormats[30], "Quake 3 File", ".md3");
            AssertModelFormat(supportedFormats[31], "idTech4 Animation File", ".md5anim");
            AssertModelFormat(supportedFormats[32], "idTech4 Camera File", ".md5camera");
            AssertModelFormat(supportedFormats[33], "idTech4 Mesh File", ".md5mesh");
            AssertModelFormat(supportedFormats[34], "MDC File", ".mdc");
            AssertModelFormat(supportedFormats[35], "Simulink File", ".mdl");
            AssertModelFormat(supportedFormats[36], "Godot Engine File", ".mesh");
            AssertModelFormat(supportedFormats[37], "Godot Engine File", ".mesh.xml");
            AssertModelFormat(supportedFormats[38], "LightWave 3D File", ".mot");
            AssertModelFormat(supportedFormats[39], "MilkShape 3D File", ".ms3d");
            AssertModelFormat(supportedFormats[40], "3D Low-polygon Modeler File", ".ndo");
            AssertModelFormat(supportedFormats[41], "Neutral File", ".nff");
            AssertModelFormat(supportedFormats[42], "Wavefront OBJ File", ".obj");
            AssertModelFormat(supportedFormats[43], "Object Format File", ".off");
            AssertModelFormat(supportedFormats[44], "Open Game Engine Exchange File", ".ogex");
            AssertModelFormat(supportedFormats[45], "idTech4 File", ".pk3");
            AssertModelFormat(supportedFormats[46], "Polygon Format File", ".ply");
            AssertModelFormat(supportedFormats[47], "MikuMikuDance File", ".pmx");
            AssertModelFormat(supportedFormats[48], "AutoCAD Project File", ".prj");
            AssertModelFormat(supportedFormats[49], "Quick3D Model File", ".q3o");
            AssertModelFormat(supportedFormats[50], "Quick3D Scene File", ".q3s");
            AssertModelFormat(supportedFormats[51], "RAW File", ".raw");
            AssertModelFormat(supportedFormats[52], "SCN File", ".scn");
            AssertModelFormat(supportedFormats[53], "SIB File", ".sib");
            AssertModelFormat(supportedFormats[54], "Source Engine File", ".smd");
            AssertModelFormat(supportedFormats[55], "Standard Triangle Language File", ".stl");
            AssertModelFormat(supportedFormats[56], "STEP File", ".stp");
            AssertModelFormat(supportedFormats[57], "TER File", ".ter");
            AssertModelFormat(supportedFormats[58], "UC File", ".uc");
            AssertModelFormat(supportedFormats[59], "Valve Source Flex Animation Data File", ".vta");
            AssertModelFormat(supportedFormats[60], "DirectX (Binnary/ASCII) File", ".x");
            AssertModelFormat(supportedFormats[61], "Extensible 3D Graphics File", ".x3d");
            AssertModelFormat(supportedFormats[62], "X3DB File", ".x3db");
            AssertModelFormat(supportedFormats[63], "XGL File", ".xgl");
            AssertModelFormat(supportedFormats[64], "XML File", ".xml");
            AssertModelFormat(supportedFormats[65], "ZGL File", ".zgl");
        }

        private static void AssertModelFormat(IModelFormat actualFormat, string expectedDescription, string expectedFileExtension)
        {
            Assert.AreEqual(expectedDescription, actualFormat.Description);
            Assert.AreEqual(expectedFileExtension, actualFormat.FileExtension);
        }

    }
}