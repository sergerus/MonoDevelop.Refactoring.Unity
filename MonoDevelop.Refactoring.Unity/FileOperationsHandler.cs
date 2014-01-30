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
			Console.WriteLine ("CanHandlePath: path=" + path + ", isDirectory=" + isDirectory);
			if (isDirectory && !FileOperationsOptions.TrackDirectories)
				return false;
			if (!isDirectory && !FileOperationsOptions.TrackFiles)
				return false;
			return File.Exists (GetMetaPathForFile (path));
		}

		public override void CopyFile (FilePath source, FilePath dest, bool overwrite)
		{
			Console.WriteLine ("CopyFile: source=" + source + ", dest=" + dest + ", overwrite=" + overwrite);
			base.CopyFile (source, dest, overwrite);
			if (FileOperationsOptions.TrackCopy)
				File.Copy (GetMetaPathForFile (source), GetMetaPathForFile (dest));
		}

		public override void RenameFile (FilePath file, string newName)
		{
			Console.WriteLine ("RenameFile: file=" + file + ", newName=" + newName);
			base.RenameFile (file, newName);
			if (FileOperationsOptions.TrackRename)
				File.Move (GetMetaPathForFile (file), GetMetaPathForFile (file.ParentDirectory.Combine (newName)));
		}

		public override void MoveFile (FilePath source, FilePath dest)
		{
			Console.WriteLine ("MoveFile: source=" + source + ", dest=" + dest);
			base.MoveFile (source, dest);
			if (FileOperationsOptions.TrackMove)
				File.Move (GetMetaPathForFile (source), GetMetaPathForFile (dest));
		}

		public override void DeleteFile (FilePath file)
		{
			Console.WriteLine ("DeleteFile: file=" + file);
			base.DeleteFile (file);
			if (FileOperationsOptions.TrackDelete)
				File.Delete (GetMetaPathForFile (file));
		}

		public override void CopyDirectory (FilePath sourcePath, FilePath destPath)
		{
			Console.WriteLine ("CopyDirectory: sourcePath=" + sourcePath + ", destPath=" + destPath);
			base.CopyDirectory (sourcePath, destPath);
			if (FileOperationsOptions.TrackCopy)
				File.Copy (GetMetaPathForFile (sourcePath), GetMetaPathForFile (destPath));
		}

		public override void RenameDirectory (FilePath path, string newName)
		{
			Console.WriteLine ("RenameDirectory: path=" + path + ", newName=" + newName);
			base.RenameDirectory (path, newName);
			if (FileOperationsOptions.TrackRename)
				File.Move (GetMetaPathForFile (path), GetMetaPathForFile (path.ParentDirectory.Combine (newName)));
		}

		public override void MoveDirectory (FilePath sourcePath, FilePath destPath)
		{
			Console.WriteLine ("MoveDirectory: sourcePath=" + sourcePath + ", destPath=" + destPath);
			base.MoveDirectory (sourcePath, destPath);
			if (FileOperationsOptions.TrackMove)
				File.Move (GetMetaPathForFile (sourcePath), GetMetaPathForFile (destPath));
		}

		public override void DeleteDirectory (FilePath path)
		{
			Console.WriteLine ("DeleteDirectory: path=" + path);
			base.DeleteDirectory (path);
			if (FileOperationsOptions.TrackDelete)
				File.Delete (GetMetaPathForFile (path));
		}

		string GetMetaPathForFile (FilePath file)
		{
			return file + MetaSuffix;
		}
	}
}
