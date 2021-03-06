# Pickles Release Notes

## v1.0.0 - 2014-12-15

### Breaking Change

- Support for the nAnt runner has been discontinued. nAnt users can migrate by using nAnt's capabilities to call the command line runner of Pickles. ([#179](https://github.com/picklesdoc/pickles/pull/179))

### Bug Fix

- The checkmark/cross icon in the GUI client did not always show the cross icon when appropriate, and its state could be changed by the user. ([#177](https://github.com/picklesdoc/pickles/pull/177))

## v0.20.0 - 2014-12-10

### Breaking Change

- The msbuild runner will now break the build when an error occurs. This reflects our belief that the Living Documentation is a first class output of the software development process.

### New Features

- The command line and powershell runners now return an error code of 0 when everything went fine, and 1 if there was an error.
- The HTML and DHTML output versions no longer horizontally spread tables.
- The GUI version has an icon  

## v0.19.0 - 2014-11-25

### Breaking Change

- DITA support has been discontinued. ([#153](https://github.com/picklesdoc/pickles/pull/153))

### New Features

- Each runner has its own download package
- Several improvements to the DHTML version
  - A progress indicator when loading features for the first time
  - Add a toggle to show/hide folder contents (top level folders are collapsed by default)
- The Nuget package for the MSBuild runner adds an msbuild target file - see [MSBuild Task](http://www.picklesdoc.com/#!Pages/MSBuildTask.md) for documentation ([#157](https://github.com/picklesdoc/pickles/pull/157))
- The text "pickled on" was replaced with "generated on".

### For developers

We are now using a new assert library: [NFluent](http://n-fluent.net/).

## v0.18.2 - 2014-09-12

### Bug(s) Fixed

- Fixed issue where the Html version didn't render the pass/fail icons ([#139](https://github.com/picklesdoc/pickles/issues/139))
- Fixed issue where the Html version generated an unexpected entry for a file in obj/Debug ([#140](https://github.com/picklesdoc/pickles/issues/140))
- Removed dependencies from the Nuget packages ([#142](https://github.com/picklesdoc/pickles/issues/142))
- The nuget packages Pickles.CommandLine and Pickles.MSBuild contain the files twice ([#144](https://github.com/picklesdoc/pickles/issues/144))

## v0.18.1 - 2014-09-01

### Bug(s) Fixed

- Fixed issue where multiline arguments of gherkin steps would not be rendered in the DHtml verion ([#134](https://github.com/picklesdoc/pickles/issues/134))

## v0.18.0 - 2014-07-07

### New Feature(s)

- **Potential Breaking Change**: the folder structure of the dependencies of the static HTML version was changed. If you override the .css files, you will need to update your workflow to account for that.

### Bug(s) Fixed

- Fixed issue where multiple results files for a single feature causes exceptions when processing scenario outline examples ([#123](https://github.com/picklesdoc/pickles/pull/123))
- Fixed issue where pickles would crash when a specified test results file does not exist ([#126](https://github.com/picklesdoc/pickles/issues/126))

## v0.17.4 - 2014-06-04

### Bug(s) Fixed

- Description blocks are rendered as code elements in DHtml version ([#118](https://github.com/picklesdoc/pickles/issues/118))

## v0.17.3 - 2014-05-28

### Bug(s) Fixed

- PowerShell version works again

## v0.17.2 - 2014-05-28

Some things went wrong during the publication of versions 0.17.0 and 0.17.1. Therefore 0.17.2 is the first published 0.17.x version.

### New Feature(s)

- Added test status in the DHTML browsing section (left nav) (#110)

### Bug(s) Fixed

- Crash because of nunit result (#108)
- Avoid crash on start of GUI (#112)

## v0.16.0 - 2014-05-15

### New Feature(s)

- Enable results for individual example results in a scenario outline (in the Html version) ([#105](https://github.com/picklesdoc/pickles/pull/105))

### Bug Fixed

- Features don't render correctly when there are less than 4 spaces ([#106](https://github.com/picklesdoc/pickles/pull/106))

## v0.15.0 - 2014-04-11

### New Feature(s)

- Allow multiple result files ([#83](https://github.com/picklesdoc/pickles/issues/83)): it is now possible to use multiple test result files. This will come in handy if you need to partition your test runs. Simple use a semicolon-separated list of file paths instead of the single file path as an argument

## v0.14.0 - 2014-03-27

### New Feature(s)

- The (static) Html version now supports images with .png, .gif, .jpg and .bmp extensions. This partially addresses issue ([#12](https://github.com/picklesdoc/pickles/issues/12))
- Several updates of external dependencies, including the long out-of-date IKVM. Yay!
- All production code and test code now use the excellent [System.IO.Abstraction](https://github.com/tathamoddie/System.IO.Abstractions) library and its TestingHelpers classes.
- We are using build services provided by [MyGet](http://www.myget.org/)

## v0.13.1 - 2013-12-20

### Bug(s) Fixed

- DHTML uses the Feature's description for the Background ([#74](https://github.com/picklesdoc/pickles/issues/74))
- Nuget manifest should mention PicklesDoc instead of only Jeffrey Cameron ([#84](https://github.com/picklesdoc/pickles/issues/84))
- Crash when a feature is not present in the test result (with NUnit) ([#85](https://github.com/picklesdoc/pickles/issues/85))

## v0.13.0 - 2013-11-29

### New Feature(s)

- The UI version now includes the option to generate each selected output format in its own directory ([#78](https://github.com/picklesdoc/pickles/pull/78))

### Bug(s) Fixed

- Left nav bug fix in DHTML format ([#73](https://github.com/picklesdoc/pickles/pull/73))
- DHTML uses the Feature's description for the Background ([#74](https://github.com/picklesdoc/pickles/issues/74))


## v0.12.1 - 2013-10-28

### Bug(s) Fixed

- Fixes a .NET runtime version issue caused by combining all Pickles runners in one directory. We are back to each runner in a separate directory, and will likely remain so until all assemblies use the same .NET framework version.

## v0.12 - 2013-10-25

### New Feature(s)

- DHTML output format should render Markdown correctly (one step closer toward feature parity for all export formats) ([#60](https://github.com/picklesdoc/pickles/issues/60))
- The .zip file contains all 5 Pickles runners in one directory, reducing the size of the download by roughly three quarters.

### Bug(s) Fixed

- When selecting multiple output formats in the UI, pickles generates the first output format multiple times ([#66](https://github.com/picklesdoc/pickles/issues/66))

## v0.11 - 2013-09-26

### New Feature(s)

- Better Error Reporting: both the command line client and the UI show a log ([#36](https://github.com/picklesdoc/pickles/issues/36))

### Bug(s) Fixed

- Pickles crashes when generating excel with really long descriptions ([#62](https://github.com/picklesdoc/pickles/issues/62))
- Calling pickles.exe without any arguments in a directory without features causes a crash ([#63](https://github.com/picklesdoc/pickles/issues/63))

## v0.10 - 2013-08-29

### New Feature(s)

- Add support for SpecRun test results ([#21](https://github.com/picklesdoc/pickles/issues/21)). Refer to the wiki page for instructions on how to configure SpecRun correctly: [Integrating Test Results From SpecRun](http://www.picklesdoc.com/#!Pages/IntegratingTestResultsFromSpecRun.md).

### Bug(s) Fixed

- Please implement marking ignored test cases with yellow sign rather than red for all Test Result providers (not just MSTest) ([#47](https://github.com/picklesdoc/pickles/issues/47))
- Remove duplication of example feature files ([#50](https://github.com/picklesdoc/pickles/issues/50))
- Adding background to features in word ([#58](https://github.com/picklesdoc/pickles/pull/58))
- Handle cucumber feature with no scenarios ([#59](https://github.com/picklesdoc/pickles/pull/59))


## Older Releases without Release Notes

- v0.9 - 2013-07-23 
- v0.8 - 2012-12-17
- v0.7 - 2012-08-07
- v0.6 was skipped
- v0.5 - 2012-03-13
- v0.4 - 2012-01-20
- v0.3 - 2011-12-13
- v0.2 - 2011-11-14
- v0.1 - 2011-10-22
