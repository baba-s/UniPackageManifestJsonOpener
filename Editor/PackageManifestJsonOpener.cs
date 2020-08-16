using System.Diagnostics;
using System.IO;
using UnityEditor;

namespace Kogane.Internal
{
	internal static class PackageManifestJsonOpener
	{
		[MenuItem( "Edit/UniPackageManifestJsonOpener/Open manifest.json" )]
		private static void OpenManifestJson()
		{
			var path = $@"{Directory.GetCurrentDirectory()}\Packages\manifest.json";
			Process.Start( path );
		}

		[MenuItem( "Edit/UniPackageManifestJsonOpener/Open packages-lock.json" )]
		private static void OpenPackagesLockJson()
		{
			var path = $@"{Directory.GetCurrentDirectory()}\Packages\packages-lock.json";
			Process.Start( path );
		}
	}
}