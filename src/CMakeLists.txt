project(Calculator_material LANGUAGES CSharp)

cmake_minimum_required(VERSION 3.16)
include(CSharpUtilities)
set(CMAKE_INCLUDE_CURRENT_DIR ON)
set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR}/CMAKE)

add_executable(Calculator_material
	Calculator_material/App.config
	Calculator_material/App.xaml
	Calculator_material/App.xaml.cs
	Calculator_material/MainWindow.xaml
	Calculator_material/MainWindow.xaml.cs
	Calculator_material/HelpWindow.xaml
	Calculator_material/HelpWindow.xaml.cs

	Calculator_material/Properties/AssemblyInfo.cs
	Calculator_material/Properties/Resources.Designer.cs
	Calculator_material/Properties/Resources.resx
	Calculator_material/Properties/Settings.Designer.cs
	Calculator_material/Properties/Settings.settings)

csharp_set_designer_cs_properties(
	Calculator_material/Properties/AssemblyInfo.cs
	Calculator_material/Properties/Resources.Designer.cs
	Calculator_material/Properties/Resource.resx
	Calculator_material/Properties/Settings.Designer.cs
	Calculator_material/Properties/Settings.settings)

csharp_set_xaml_cs_properties(
	Calculator_material/App.xaml
	Calculator_material/App.xaml.cs
	Calculator_material/MainWindow.xaml
	Calculator_material/MainWindow.xaml.cs
	Calculator_material/HelpWindow.xaml
	Calculator_material/HelpWindow.xaml.cs)

set_property(SOURCE App.xaml PROPERTY VS_XAML_TYPE "ApplicationDefinition")

set_property(TARGET Calculator_material PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.7.2")
set_property(TARGET Calculator_material PROPERTY WIN32_EXECUTABLE TRUE)

add_subdirectory(CustomDLLs)


set_property(TARGET Calculator_material PROPERTY VS_DOTNET_REFERENCES
	"MaterialDesignColors"
	"MaterialDesignThemes.Wpf"
	"Mathematics"
	"Microsoft.CSharp"
	"PresentationCore"
	"PresentationFramework"
	"System"
	"System.Core"
	"System.Data"
 	"System.Data.DataSetExtensions"
	"System.Net.Http"
	"System.Xaml"
	"System.Xml"
	"System.Xml.Linq"
	"WindowsBase")







