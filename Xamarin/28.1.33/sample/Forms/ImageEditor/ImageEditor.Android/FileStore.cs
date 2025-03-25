#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.IO;

namespace SampleBrowser.SfImageEditor.Droid
{
	public class FileStore: IFileStore
	{
        [Obsolete]
        public string GetFilePath()
		{
			return Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "image.png");
		}
	}
}