using System.IO;
using UnityEditor;

static class MyShaderIncludePaths {

	[ShaderIncludePath]
	static string[] GetPaths () {
		return new string[] {
			Path.GetFullPath("Assets/My Pipeline")
		};
	}
}