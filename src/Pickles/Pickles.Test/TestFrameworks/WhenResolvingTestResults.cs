﻿using System;

using Autofac;

using NUnit.Framework;

using PicklesDoc.Pickles.TestFrameworks;

using NFluent;

namespace PicklesDoc.Pickles.Test.TestFrameworks
{
    [TestFixture]
    public class WhenResolvingTestResults : BaseFixture
    {
        private const string TestResultsResourcePrefix = "PicklesDoc.Pickles.Test.TestFrameworks.";

        [Test]
        public void ThenCanResolveAsSingletonWhenNoTestResultsSelected()
        {
            var item1 = Container.Resolve<ITestResults>();
            var item2 = Container.Resolve<ITestResults>();

            Check.That(item1).IsNotNull();
            Check.That(item1).IsInstanceOf<NullTestResults>();
            Check.That(item2).IsNotNull();
            Check.That(item2).IsInstanceOf<NullTestResults>();
            Check.That(item1).IsSameReferenceThan(item2);
        }

        [Test]
        public void ThenCanResolveAsSingletonWhenTestResultsAreMsTest()
        {
            FileSystem.AddFile("results-example-mstest.trx", RetrieveContentOfFileFromResources(TestResultsResourcePrefix + "results-example-mstest.trx"));

            var configuration = Container.Resolve<Configuration>();
            configuration.TestResultsFormat = TestResultsFormat.MsTest;
            configuration.AddTestResultFiles(new[] { FileSystem.FileInfo.FromFileName("results-example-mstest.trx") });

            var item1 = Container.Resolve<ITestResults>();
            var item2 = Container.Resolve<ITestResults>();

            Check.That(item1).IsNotNull();
            Check.That(item1).IsInstanceOf<MsTestResults>();
            Check.That(item2).IsNotNull();
            Check.That(item2).IsInstanceOf<MsTestResults>();
            Check.That(item1).IsSameReferenceThan(item2);
        }

        [Test]
        public void ThenCanResolveAsSingletonWhenTestResultsAreNUnit()
        {
            FileSystem.AddFile("results-example-nunit.xml", RetrieveContentOfFileFromResources(TestResultsResourcePrefix + "results-example-nunit.xml"));

            var configuration = Container.Resolve<Configuration>();
            configuration.TestResultsFormat = TestResultsFormat.NUnit;
            configuration.AddTestResultFile(FileSystem.FileInfo.FromFileName("results-example-nunit.xml"));

            var item1 = Container.Resolve<ITestResults>();
            var item2 = Container.Resolve<ITestResults>();

            Check.That(item1).IsNotNull();
            Check.That(item1).IsInstanceOf<NUnitResults>();
            Check.That(item2).IsNotNull();
            Check.That(item2).IsInstanceOf<NUnitResults>();
            Check.That(item1).IsSameReferenceThan(item2);
        }

        [Test]
        public void ThenCanResolveAsSingletonWhenTestResultsArexUnit()
        {
            FileSystem.AddFile("results-example-xunit.xml", RetrieveContentOfFileFromResources(TestResultsResourcePrefix + "results-example-xunit.xml"));

            var configuration = Container.Resolve<Configuration>();
            configuration.TestResultsFormat = TestResultsFormat.xUnit;
            configuration.AddTestResultFile(FileSystem.FileInfo.FromFileName("results-example-xunit.xml"));

            var item1 = Container.Resolve<ITestResults>();
            var item2 = Container.Resolve<ITestResults>();

            Check.That(item1).IsNotNull();
            Check.That(item1).IsInstanceOf<XUnitResults>();
            Check.That(item2).IsNotNull();
            Check.That(item2).IsInstanceOf<XUnitResults>();
            Check.That(item1).IsSameReferenceThan(item2);
        }

        [Test]
        public void ThenCanResolveAsSingletonWhenTestResultsAreCucumberJson()
        {
            FileSystem.AddFile("results-example-json.json", RetrieveContentOfFileFromResources(TestResultsResourcePrefix + "results-example-json.json"));

            var configuration = Container.Resolve<Configuration>();
            configuration.TestResultsFormat = TestResultsFormat.CucumberJson;
            configuration.AddTestResultFile(FileSystem.FileInfo.FromFileName("results-example-json.json"));

            var item1 = Container.Resolve<ITestResults>();
            var item2 = Container.Resolve<ITestResults>();

            Check.That(item1).IsNotNull();
            Check.That(item1).IsInstanceOf<CucumberJsonResults>();
            Check.That(item2).IsNotNull();
            Check.That(item2).IsInstanceOf<CucumberJsonResults>();
            Check.That(item1).IsSameReferenceThan(item2);
        }

        [Test]
        public void ThenCanResolveAsSingletonWhenTestResultsAreSpecrun()
        {
            FileSystem.AddFile("results-example-specrun.html", RetrieveContentOfFileFromResources(TestResultsResourcePrefix + "results-example-specrun.html"));

            var configuration = Container.Resolve<Configuration>();
            configuration.TestResultsFormat = TestResultsFormat.SpecRun;
            configuration.AddTestResultFile(FileSystem.FileInfo.FromFileName("results-example-specrun.html"));

            var item1 = Container.Resolve<ITestResults>();
            var item2 = Container.Resolve<ITestResults>();

            Check.That(item1).IsNotNull();
            Check.That(item1).IsInstanceOf<SpecRunResults>();
            Check.That(item2).IsNotNull();
            Check.That(item2).IsInstanceOf<SpecRunResults>();
            Check.That(item1).IsSameReferenceThan(item2);
        }

        [Test]
        public void ThenCanResolveWhenNoTestResultsSelected()
        {
            var item = Container.Resolve<ITestResults>();

            Check.That(item).IsNotNull();
            Check.That(item).IsInstanceOf<NullTestResults>();
        }


        [Test]
        public void ThenCanResolveWhenTestResultsAreMsTest()
        {
            FileSystem.AddFile("results-example-mstest.trx", RetrieveContentOfFileFromResources(TestResultsResourcePrefix + "results-example-mstest.trx"));

            var configuration = Container.Resolve<Configuration>();
            configuration.TestResultsFormat = TestResultsFormat.MsTest;
            configuration.AddTestResultFile(FileSystem.FileInfo.FromFileName("results-example-mstest.trx"));

            var item = Container.Resolve<ITestResults>();

            Check.That(item).IsNotNull();
            Check.That(item).IsInstanceOf<MsTestResults>();
        }

        [Test]
        public void ThenCanResolveWhenTestResultsAreNUnit()
        {
           FileSystem.AddFile("results-example-nunit.xml", RetrieveContentOfFileFromResources(TestResultsResourcePrefix + "results-example-nunit.xml"));

            var configuration = Container.Resolve<Configuration>();
            configuration.TestResultsFormat = TestResultsFormat.NUnit;
            configuration.AddTestResultFile(FileSystem.FileInfo.FromFileName("results-example-nunit.xml"));

            var item = Container.Resolve<ITestResults>();

            Check.That(item).IsNotNull();
            Check.That(item).IsInstanceOf<NUnitResults>();
        }

        [Test]
        public void ThenCanResolveWhenTestResultsArexUnit()
        {
            FileSystem.AddFile("results-example-xunit.xml", RetrieveContentOfFileFromResources(TestResultsResourcePrefix + "results-example-xunit.xml"));

            var configuration = Container.Resolve<Configuration>();
            configuration.TestResultsFormat = TestResultsFormat.xUnit;
            configuration.AddTestResultFile(FileSystem.FileInfo.FromFileName("results-example-xunit.xml"));

            var item = Container.Resolve<ITestResults>();

            Check.That(item).IsNotNull();
            Check.That(item).IsInstanceOf<XUnitResults>();
        }

        [Test]
        public void ThenCanResolveWhenTestResultsAreCucumberJson()
        {
            FileSystem.AddFile("results-example-json.json", RetrieveContentOfFileFromResources(TestResultsResourcePrefix + "results-example-json.json"));

            var configuration = Container.Resolve<Configuration>();
            configuration.TestResultsFormat = TestResultsFormat.CucumberJson;
            configuration.AddTestResultFile(FileSystem.FileInfo.FromFileName("results-example-json.json"));

            var item = Container.Resolve<ITestResults>();

            Check.That(item).IsNotNull();
            Check.That(item).IsInstanceOf<CucumberJsonResults>();
        }

        [Test]
        public void ThenCanResolveWhenTestResultsAreSpecrun()
        {
            FileSystem.AddFile("results-example-specrun.html", RetrieveContentOfFileFromResources(TestResultsResourcePrefix + "results-example-specrun.html"));

            var configuration = Container.Resolve<Configuration>();
            configuration.TestResultsFormat = TestResultsFormat.SpecRun;
            configuration.AddTestResultFile(FileSystem.FileInfo.FromFileName("results-example-specrun.html"));

            var item = Container.Resolve<ITestResults>();

            Check.That(item).IsNotNull();
            Check.That(item).IsInstanceOf<SpecRunResults>();
        }
    }
}