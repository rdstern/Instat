﻿'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
Imports instat.Translations
''' <summary>
''' Polynomials Dialogue
''' </summary>


Public Class dlgPolynomials
    ''' <summary>
    ''' autoTranslate(me) translates the text into other languages.
    ''' </summary>
    Private Sub dlgPolynomials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    ''' <summary>
    ''' Checked change event toggles on/off the checkbox for weights being enabled.
    ''' </summary>
    Private Sub rdoOrthogonal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOrthogonal.CheckedChanged
        If rdoOrthogonal.Checked = True Then
            chkWeights.Enabled = True
        ElseIf rdoOrthogonal.Checked = False
            chkWeights.Enabled = False
        End If
    End Sub
    ''' <summary>
    ''' Defaults the settings for resetting the form.
    ''' When this routine is called, it restores the form controls to their original unmodified set up
    ''' </summary>
    Private Sub defaultSettings()
        rdoSimple.Checked = True
        nmdOrder.Value = 2
        txtInto.Text = ""
        chkWeights.Checked = False

    End Sub

    ''' <summary>
    ''' The ClickReset event resets the form to its original setup by calling the routine defaultSettings.
    ''' Happens when the reset button is pressed
    ''' </summary>
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        defaultSettings()
    End Sub
End Class