using System;
using MonoDevelop.Core;
using MonoDevelop.Core.FileSystem;
using System.IO;

namespace MonoDevelop.Refactoring.Unity
{
	public class FileOperationsHandler : FileSystemExtension
	{
		const string MetaSuffix = ".meta";

		public override bool CanHandlePath (FilePath path, bool isDirectory)
		{
			return true;
		}

		public override void CopyFile (FilePath source, FilePath dest, bool overwrite)
		{
			LoggingService.LogDebug ("MonoDevelop.Refactoring.Unity.FileOperationsHandler.CopyFile: source=" + source + ", dest=" + dest + ", overwrite=" + overwrite);
			base.CopyFile (source, dest, overwrite);
			if (FileOperationsOptions.TrackFiles && FileOperationsOptions.TrackCopy) {
				string srcMeta = GetMetaPathForFile (source);
				if (File.Exists (srcMeta)) {
					File.Copy (srcMeta, GetMetaPathForFile (dest));
				}
			}
		}

		public override void RenameFile (FilePath file, string newName)
		{
			LoggingService.LogDebug ("MonoDevelop.Refactoring.Unity.FileOperationsHandler.RenameFile: file=" + file + ", newName=" + newName);
			base.RenameFile (file, newName);
			if (FileOperationsOptions.TrackFiles && FileOperationsOptions.TrackRename) {
				string srcMeta = GetMetaPathForFile (file);
				if (File.Exists (srcMeta)) {
					File.Move (srcMeta, GetMetaPathForFile (file.ParentDirectory.Combine (newName)));
				}
			}
		}

		public override void MoveFile (FilePath source, FilePath dest)
		{
			LoggingService.LogDebug ("MonoDevelop.Refactoring.Unity.FileOperationsHandler.MoveFile: source=" + source + ", dest=" + dest);
			base.MoveFile (source, dest);
			if (FileOperationsOptions.TrackFiles && FileOperationsOptions.TrackMove) {
				string srcMeta = GetMetaPathForFile (source);
				if (File.Exists (srcMeta)) {
					File.Move (srcMeta, GetMetaPathForFile (dest));
				}
			}
		}

		public override void DeleteFile (FilePath file)
		{
			LoggingService.LogDebug ("MonoDevelop.Refactoring.Unity.FileOperationsHandler.DeleteFile: file=" + file);
			base.DeleteFile (file);
			if (FileOperationsOptions.TrackFiles && FileOperationsOptions.TrackDelete) {
				string srcMeta = GetMetaPathForFile (file);
				if (File.Exists (srcMeta))
					File.Delete (srcMeta);
			}
		}

		public override void CopyDirectory (FilePath sourcePath, FilePath destPath)
		{
			LoggingService.LogDebug ("MonoDevelop.Refactoring.Unity.FileOperationsHandler.CopyDirectory: sourcePath=" + sourcePath + ", destPath=" + destPath);
			base.CopyDirectory (sourcePath, destPath);
			if (FileOperationsOptions.TrackDirectories && FileOperationsOptions.TrackCopy) {
				string srcMeta = GetMetaPathForFile (sourcePath);
				if (File.Exists (srcMeta))
					File.Copy (srcMeta, GetMetaPathForFile (destPath));
			}
		}

		public override void RenameDirectory (FilePath path, string newName)
		{
			LoggingService.LogDebug ("MonoDevelop.Refactoring.Unity.FileOperationsHandler.RenameDirectory: path=" + path + ", newName=" + newName);
			base.RenameDirectory (path, newName);
			if (FileOperationsOptions.TrackDirectories && FileOperationsOptions.TrackRename) {
				string srcMeta = GetMetaPathForFile (path);
				if (File.Exists (srcMeta))
					File.Move (srcMeta, GetMetaPathForFile (path.ParentDirectory.Combine (newName)));
			}
		}

		public override void MoveDirectory (FilePath sourcePath, FilePath destPath)
		{
			LoggingService.LogDebug ("MonoDevelop.Refactoring.Unity.FileOperationsHandler.MoveDirectory: sourcePath=" + sourcePath + ", destPath=" + destPath);
			base.MoveDirectory (sourcePath, destPath);
			if (FileOperationsOptions.TrackDirectories && FileOperationsOptions.TrackMove) {
				string srcMeta = GetMetaPathForFile (sourcePath);
				if (File.Exists (srcMeta))
					File.Move (srcMeta, GetMetaPathForFile (destPath));
			}
		}

		public override void DeleteDirectory (FilePath path)
		{
			LoggingService.LogDebug ("MonoDevelop.Refactoring.Unity.FileOperationsHandler.DeleteDirectory: path=" + path);
			base.DeleteDirectory (path);
			if (FileOperationsOptions.TrackDirectories && FileOperationsOptions.TrackDelete) {
				string srcMeta = GetMetaPathForFile (path);
				if (File.Exists (srcMeta))
					File.Delete (srcMeta);
			}
		}

		string GetMetaPathForFile (FilePath file)
		{
			return file + MetaSuffix;
		}
	}
}
