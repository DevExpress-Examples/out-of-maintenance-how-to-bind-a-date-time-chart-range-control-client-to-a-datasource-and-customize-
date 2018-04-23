' Developer Express Code Central Example:
' How to bind a date-time chart range control client to a datasource and customize its common settings
' 
' This example demonstrates how to set up a range control with the date-time chart
' client to display a chart with date-time data in the range control's background.
' In order to provide data to a chart date-time range control client, you need to
' access the ChartRangeControlClientDataProvider object using the
' ChartRangeControlClientBase.DataProvider property and assign a data source to
' the ChartRangeControlClientDataProvider.DataSource property. Then specify the
' required data fields via the
' ChartRangeControlClientDataProvider.ArgumentDataMember,
' ChartRangeControlClientDataProvider.ValueDataMember, and
' ChartRangeControlClientDataProvider.SeriesDataMember (optional) properties. In
' the current example, a date-time chart client is bound to a simple data table
' containing three columns ("Argument", "Value", and "Series"). In addition, this
' example shows how to customize chart client common settings (e.g., change the
' date-time range, customize template view and grid options).
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T125884

Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("DateTimeChartRangeClient")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("DateTimeChartRangeClient")>
<Assembly: AssemblyCopyright("Copyright ©  2014")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("ed102e0e-ede1-4a57-ac45-a33ba77bea7d")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
