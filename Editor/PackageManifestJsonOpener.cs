using System.Diagnostics;
using System.IO;
using UnityEditor;

namespace Kogane.Internal
{
	internal static class PackageManifestJsonOpener
	{
		[MenuItem( "Edit/Open Package manifest.json" )]
		private static void Open()
		{
			var path = $@"{Directory.GetCurrentDirectory()}\Packages\manifest.json";
			Process.Start( path );
		}
	}
}