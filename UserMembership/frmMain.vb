Imports System.DirectoryServices

Public Class frmMain

    Public Enum ADS_USER_FLAG
        ADS_UF_SCRIPT = 1                                          '    // 0x1
        ADS_UF_ACCOUNTDISABLE = 2                                  '    // 0x2
        ADS_UF_HOMEDIR_REQUIRED = 8                                '    // 0x8
        ADS_UF_LOCKOUT = 16                                        '    // 0x10
        ADS_UF_PASSWD_NOTREQD = 32                                 '    // 0x20
        ADS_UF_PASSWD_CANT_CHANGE = 64                             '    // 0x40
        ADS_UF_ENCRYPTED_TEXT_PASSWORD_ALLOWED = 128               '    // 0x80
        ADS_UF_TEMP_DUPLICATE_ACCOUNT = 256                        '    // 0x100
        ADS_UF_NORMAL_ACCOUNT = 512                                '    // 0x200
        ADS_UF_INTERDOMAIN_TRUST_ACCOUNT = 2048                    '    // 0x800
        ADS_UF_WORKSTATION_TRUST_ACCOUNT = 4096                    '    // 0x1000
        ADS_UF_SERVER_TRUST_ACCOUNT = 8192                         '    // 0x2000
        ADS_UF_DONT_EXPIRE_PASSWD = 65536                          '    // 0x10000
        ADS_UF_MNS_LOGON_ACCOUNT = 131072                          '    // 0x20000
        ADS_UF_SMARTCARD_REQUIRED = 262144                         '    // 0x40000
        ADS_UF_TRUSTED_FOR_DELEGATION = 524288                     '    // 0x80000
        ADS_UF_NOT_DELEGATED = 1048576                             '    // 0x100000
        ADS_UF_USE_DES_KEY_ONLY = 2097152                          '    // 0x200000
        ADS_UF_DONT_REQUIRE_PREAUTH = 4194304                      '    // 0x400000
        ADS_UF_PASSWORD_EXPIRED = 8388608                          '    // 0x800000
        ADS_UF_TRUSTED_TO_AUTHENTICATE_FOR_DELEGATION = 16777216   '    // 0x1000000

    End Enum

    Private Sub btnSearchUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchUsername.Click
        If txtUsername.TextLength = 0 Then
            lblStatus.Text = "No username supplied!"
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor

        lblStatus.Text = "Searching..."
        lblName.Text = "Name"
        lblUserStatus.Text = "User Status: Unknown"
        lstGroups.Items.Clear()
        Me.Refresh()

        Me.txtUsername.SelectAll()

        Dim strGivenName As String
        Dim strSurname As String
        Dim strStatus As String = ""

        ' get the root namespace
        Dim objRootDSE As New DirectoryEntry("LDAP://RootDSE")
        Dim objsearchRoot As DirectoryEntry = New DirectoryEntry("LDAP://" & objRootDSE.Properties("defaultNamingContext")(0).ToString()) ', Nothing, Nothing, AuthenticationTypes.Secure)

        Dim dsUser As DirectorySearcher = New DirectorySearcher(String.Format("(&(&(objectcategory=user)(objectclass=person))(sAMAccountName={0}))", txtUsername.Text))

        dsUser.PropertiesToLoad.Add("AccountDisabled")
        dsUser.PropertiesToLoad.Add("memberOf")

        Dim srcUser As SearchResultCollection = dsUser.FindAll()
        Try
            If srcUser.Count = 0 Then
                lblStatus.Text = "User not found"
                Me.Refresh()
            Else
                lblStatus.Text = "User found"
                Me.Refresh()
                Dim de As DirectoryEntry = srcUser(0).GetDirectoryEntry
                Console.WriteLine(de.Path)
                strGivenName = de.Properties("givenName")(0).ToString
                strSurname = de.Properties("sn")(0).ToString
                lblName.Text = strGivenName & " " & strSurname
                If Not IsNothing(de.Properties("userAccountControl").Value) Then
                    If de.Properties("userAccountControl").Value And ADS_USER_FLAG.ADS_UF_ACCOUNTDISABLE Then strStatus = "Disabled "
                    If de.Properties("userAccountControl").Value And ADS_USER_FLAG.ADS_UF_LOCKOUT Then strStatus &= "Locked "
                    If de.Properties("userAccountControl").Value And ADS_USER_FLAG.ADS_UF_NORMAL_ACCOUNT Then strStatus &= "Normal "
                    If de.Properties("userAccountControl").Value And ADS_USER_FLAG.ADS_UF_DONT_EXPIRE_PASSWD Then strStatus &= "Password never expires "
                    If de.Properties("userAccountControl").Value And ADS_USER_FLAG.ADS_UF_PASSWORD_EXPIRED Then strStatus &= "Expired"
                Else
                    strStatus &= "has no special properties "
                End If
                If strStatus <> "" Then
                    Me.lblUserStatus.Text = "Account " & strStatus
                Else

                End If

                Dim props() As String = {"tokenGroups"}
                de.RefreshCache(props)

                Dim propertyCount As Int32 = de.Properties("memberOf").Count()
                Dim dn As String
                Dim equalsIndex As Int32, commaIndex As Int32
                Dim propertyCounter As Int32

                For propertyCounter = 0 To propertyCount - 1
                    dn = de.Properties("memberOf")(propertyCounter)
                    equalsIndex = dn.IndexOf("=", 1)
                    commaIndex = dn.IndexOf(",", 1)
                    If (-1 = equalsIndex) Then
                        Me.lstGroups.Items.Add(dn)
                    Else
                        Me.lstGroups.Items.Add(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
                    End If
                Next propertyCounter
                If Me.lstGroups.Items.Count > 0 Then AcceptButton = btnNotepadCopy
            End If
        Catch ex As Exception
            lblStatus.Text = "Error encountered whilst searching (" & ex.Message & ")"
            Me.Refresh()
        End Try

        Cursor.Current = Cursors.Default
    End Sub

    Sub FindNetBIOSName()
        Dim strDomain As String
        Dim rootds, part, parts As System.DirectoryServices.DirectoryEntry

        ' get the root namespace
        rootds = New System.DirectoryServices.DirectoryEntry("LDAP://rootDSE")
        ' get the name of the domain we're currently in
        strDomain = rootds.Properties("DefaultNamingContext")(0)
        parts = New System.DirectoryServices.DirectoryEntry("LDAP://CN=Partitions,CN=Configuration," _
         & strDomain)

        For Each part In parts.Children
            ' search the AD Configuration container for our domain name
            If part.Properties("nCName")(0) = strDomain Then
                ' Properties are case sensitive!
                MsgBox(part.Properties("nETBIOSName")(0))
                Exit For
            End If
        Next
    End Sub

    Private Sub btnNotepadCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotepadCopy.Click
        Dim i As Integer = 0
        Dim strGroupnames As String = ""
        Dim strDelimiter As String = ""

        If rbCRLF.Checked Then strDelimiter = vbCrLf
        If rbSemicolon.Checked Then strDelimiter = ";"

        If lstGroups.Items.Count > 0 Then

            For i = 0 To Me.lstGroups.Items.Count - 1
                strGroupnames &= lstGroups.Items(i).ToString & strDelimiter
            Next

            My.Computer.Clipboard.SetText(strGroupnames)
            MsgBox("Groupnames added to clipboard.", MsgBoxStyle.OkOnly, "User Membership")
        End If

        Me.txtUsername.SelectAll()
        Me.txtUsername.Focus()
        AcceptButton = btnSearchUsername
    End Sub

    Private Sub txtUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        AcceptButton = btnSearchUsername
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        AcceptButton = btnSearchUsername
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipClicked
        'CloseApp()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.ShowInTaskbar = True
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Static bShowBalloon As Boolean = True

        NotifyIcon1.Visible = True

        If bShowBalloon Then
            NotifyIcon1.BalloonTipText = "User Group Membership is still running..." & vbCrLf & vbCrLf & "Select Exit from the Right-Click menu to exit."
            NotifyIcon1.ShowBalloonTip(2)
        End If

        e.Cancel = True
        Me.ShowInTaskbar = False
        bShowBalloon = False
        Me.Hide()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        Me.Show()
        Me.ShowInTaskbar = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        CloseApp()
    End Sub

    Private Sub CloseApp()
        NotifyIcon1.Visible = False
        NotifyIcon1.Dispose()
        End
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
