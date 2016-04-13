'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:1/28/16
'The purpose of this form is to display a splash screen and load the user data.
Public NotInheritable Class SplashScreen1
    'Create a new integer counter
    Dim count As Integer
    Public Sub SplashScreen1_Load() Handles Me.Load
        'Set the counter to 0
        count = 0
        'Start the Counter
        tmrLoad.Enabled = True
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Copyright.Text = My.Application.Info.Copyright
        'Hide the main form while it loads.
        MainForm.Hide()
        'Play the boot sound
        My.Computer.Audio.Play("resources\boot.wav", AudioPlayMode.Background)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        'For every timer tick test to see if the timer has reached four seconds.
        If count > 2 Then
            'If the timer has reached two seconds then test to see if the program has been ran before.
            If My.Settings.FirstName = "0" Then
                'If it hasn't then open the registration form.
                Form11.Show()
            Else
                'If it has then show the main form.
                MainForm.Opacity = 1
                MainForm.Show()
            End If
            'Hide the splash screen and stop the timer.
            tmrLoad.Enabled = False
            Me.Close()
        End If
        'Add +1 to the counter
        count = count + 1
    End Sub
End Class