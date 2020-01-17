using System;
using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: CLSCompliant (true)]

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle ("Sorters")]
[assembly: AssemblyDescription ("C# Sorting Algorithm implementations")]
[assembly: AssemblyCompany ("Pixelstorm")]
[assembly: AssemblyProduct ("Sorters")]
[assembly: AssemblyCopyright ("Copyright © Pixelstorm 2020")]
[assembly: AssemblyCulture ("")]

#if DEBUG
[assembly: AssemblyConfiguration ("Debug")]
#else
[assembly: AssemblyConfiguration ("Release")]
#endif

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible (false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid ("de0fecd3-f735-4fc1-8718-6a3d3d19c12a")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion ("1.0.0.0")]
[assembly: AssemblyFileVersion ("1.0.0.0")]
[assembly: NeutralResourcesLanguage ("en-GB")]
