Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Users.Reports
Imports DevExpress.XtraReports.UI

Namespace Users
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim report As New UserItemReport()
			report.CreateDocument()
			report.ShowPreviewDialog()
		End Sub
	End Class
End Namespace
