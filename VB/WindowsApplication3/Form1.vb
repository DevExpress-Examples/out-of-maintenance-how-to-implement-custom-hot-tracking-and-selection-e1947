Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chartControl1_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chartControl1.ObjectHotTracked
			' Display the object's type.
			Me.Text = e.Object.GetType().ToString()
			' Display the additional object's type, when it is available.
			If e.AdditionalObject IsNot Nothing Then
				Me.Text &= " (" & e.AdditionalObject.GetType().ToString() & ")"
			End If
		End Sub

		Private Sub chartControl1_ObjectSelected(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chartControl1.ObjectSelected
			' Prevent the chart's diagram from being selected.
			If TypeOf e.Object Is XYDiagram Then
				e.Cancel = True
			Else
				MessageBox.Show(e.Object.GetType().ToString())
			End If
		End Sub
	End Class
End Namespace