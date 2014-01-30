using System;
using MonoDevelop.Core;

namespace MonoDevelop.Refactoring.Unity
{
	public static class FileOperationsOptions
	{
		public static bool TrackFiles {
			get { return PropertyService.Get ("MonoDevelop.Refactoring.Unity.TrackFiles", true); }
			set { PropertyService.Set ("MonoDevelop.Refactoring.Unity.TrackFiles", value); }
		}

		public static bool TrackDirectories {
			get { return PropertyService.Get ("MonoDevelop.Refactoring.Unity.TrackDirectories", false); }
			set { PropertyService.Set ("MonoDevelop.Refactoring.Unity.TrackDirectories", value); }
		}

		public static bool TrackCopy {
			get { return PropertyService.Get ("MonoDevelop.Refactoring.Unity.TrackCopy", true); }
			set { PropertyService.Set ("MonoDevelop.Refactoring.Unity.TrackCopy", value); }
		}

		public static bool TrackMove {
			get { return PropertyService.Get ("MonoDevelop.Refactoring.Unity.TrackMove", true); }
			set { PropertyService.Set ("MonoDevelop.Refactoring.Unity.TrackMove", value); }
		}

		public static bool TrackRename {
			get { return PropertyService.Get ("MonoDevelop.Refactoring.Unity.TrackRename", true); }
			set { PropertyService.Set ("MonoDevelop.Refactoring.Unity.TrackRename", value); }
		}

		public static bool TrackDelete {
			get { return PropertyService.Get ("MonoDevelop.Refactoring.Unity.TrackDelete", true); }
			set { PropertyService.Set ("MonoDevelop.Refactoring.Unity.TrackDelete", value); }
		}
	}
}

