﻿using System;
using System.IO.Abstractions.TestingHelpers;
using NUnit.Framework;
using PicklesDoc.Pickles.Extensions;
using NFluent;

namespace PicklesDoc.Pickles.Test.Extensions
{
    [TestFixture]
    internal class PathExtensionsTests : BaseFixture
    {
        [Test]
        public void Get_A_Relative_Path_When_Location_Is_Deeper_Than_Root()
        {
            MockFileSystem fileSystem = FileSystem;
            fileSystem.AddFile(@"c:\test\deep\blah.feature", "Feature:"); // adding a file automatically adds all parent directories

            string actual = PathExtensions.MakeRelativePath(@"c:\test", @"c:\test\deep\blah.feature", fileSystem);

            Check.That(actual).IsEqualTo(@"deep\blah.feature");
        }

        [Test]
        public void Get_A_Relative_Path_When_Location_Is_Deeper_Than_Root_Even_When_Root_Contains_End_Slash()
        {
            MockFileSystem fileSystem = FileSystem;
            fileSystem.AddFile(@"c:\test\deep\blah.feature", "Feature:"); // adding a file automatically adds all parent directories

            string actual = PathExtensions.MakeRelativePath(@"c:\test\", @"c:\test\deep\blah.feature", fileSystem);

            Check.That(actual).IsEqualTo(@"deep\blah.feature");
        }
    }
}