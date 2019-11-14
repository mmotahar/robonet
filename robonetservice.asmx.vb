Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.Services
Imports System.Xml
Imports System.Xml.Schema
Imports System.IO
Imports System.Threading.Thread

<System.Web.Services.WebService(Namespace:="http://localhost/roboservice/")> _
Public Class robonetservice
    Inherits System.Web.Services.WebService
    '--------------------------
    'USING FOR READINF XML FILE
    Dim usernamefild(20) As String
    Dim passwordfild(20) As String
    Dim namefild(20) As String
    Dim lastnamefild(20) As String
    Dim emailfild(20) As String
    Dim accessfild(20) As String
    Dim usernamecounter As Integer
    Dim passwordcounter
    Dim namecounter
    Dim lastnamecounter
    Dim emailcounter
    Dim accesscounter
    Dim emptyfile = False
    '----------------
    'USING FOR MULTI THREADING
    Dim sleep As Boolean = False

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As System.ComponentModel.IContainer
    Private random As System.Random
    Private thread As System.Threading.Thread 

    'NOTE: The following procedure is required by the Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
        random = New Random
        'thread = New Threading.Thread(Sendzero)
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the Web Services Designer
        'Do not modify it using the code editor.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    <WebMethod(EnableSession:=True)> _
    Public Function Connect(ByVal username As String, ByVal password As String) As String
        ' SRART READEING FROM XML BANK
        reset()
        Try

            Dim stream As StreamReader = New StreamReader(Server.MapPath("XML/userinfo.xml"))
            Dim reader As XmlTextReader = New XmlTextReader(stream)
            Dim schemacoll As XmlSchemaCollection = New XmlSchemaCollection
            schemacoll.Add(Nothing, "http://localhost/roboservice/users.xsd")
            Dim valreader As XmlValidatingReader = New XmlValidatingReader(reader)
            valreader.ValidationType = ValidationType.Schema
            valreader.Schemas.Add(schemacoll)
            Do While (valreader.Read())
                If (valreader.LocalName.Equals("UserName")) Then
                    usernamefild(usernamecounter) = valreader.ReadString()
                    usernamecounter = usernamecounter + 1
                ElseIf (valreader.LocalName.Equals("Password")) Then
                    passwordfild(passwordcounter) = valreader.ReadString()
                    passwordcounter = passwordcounter + 1
                ElseIf (valreader.LocalName.Equals("Name")) Then
                    namefild(namecounter) = valreader.ReadString()
                    namecounter = namecounter + 1
                ElseIf (valreader.LocalName.Equals("LastName")) Then
                    lastnamefild(lastnamecounter) = valreader.ReadString()
                    lastnamecounter = lastnamecounter + 1
                ElseIf (valreader.LocalName.Equals("Email")) Then
                    emailfild(emailcounter) = valreader.ReadString()
                    emailcounter = emailcounter + 1
                ElseIf (valreader.LocalName.Equals("Access")) Then
                    accessfild(accesscounter) = valreader.ReadString()
                    accesscounter = accesscounter + 1
                End If
            Loop
            valreader.Close()
            reader.Close()
            stream.Close()

        Catch ex As Exception

            emptyfile = True

        End Try
        ' READING XML BANK FINISHED
        If (emptyfile = False) Then
            Dim i As Integer
            For i = 0 To usernamecounter - 1 Step 1
                Try
                    If ((username.CompareTo(usernamefild(i)) = 0) And (password.CompareTo(passwordfild(i)) = 0)) Then
                        If (accessfild(i).CompareTo("1") = 0) Then
                            If (Convert.ToInt32(Application("useraccess")) = 0) Then
                                'thread = New Threading.Thread(Sendzero)
                                Dim tempkey As String
                                tempkey = random.Next(99999).ToString()
                                Application.Add("mainkey", tempkey)
                                Application.Add("key", tempkey)
                                Application.Remove("useraccess")
                                Application.Add("useraccess", 1) 
                                Application.Remove("username")
                                Application.Add("username", username)
                                Application.Remove("name")
                                Application.Add("name", namefild(i))
                                Application.Remove("lastname")
                                Application.Add("lastname", lastnamefild(i))
                                If (username.CompareTo("Administrator") = 0) Then
                                    Return Convert.ToString(Application("key")) + "#" + Convert.ToString(Application("newuser"))
                                Else
                                    Return Convert.ToString(Application("key"))
                                End If
                            ElseIf (username.CompareTo("Administrator") = 0) Then
                                Return "Divice is being used by :" + Convert.ToString(Application("username")) + _
                                       " ( " + Convert.ToString(Application("name")) + " " + Convert.ToString(Application("lastname")) + " )"
                            Else
                                Return "Divice is being used by another user !!!"
                            End If
                        Else
                            Return "You haven't Permission !!!"
                        End If
                    End If

                Catch ex As Exception
                    Return "Thread error !!!"
                End Try
            Next i
            Return "Invalid username or password !!!"
        End If
        Return "XML file error !!!"

    End Function

    <WebMethod(EnableSession:=True)> _
    Public Function Force(ByVal username As String, ByVal password As String) As String
        ' SRART READEING FROM XML BANK
        reset()
        Try

            Dim stream As StreamReader = New StreamReader(Server.MapPath("XML/userinfo.xml"))
            Dim reader As XmlTextReader = New XmlTextReader(stream)
            Dim schemacoll As XmlSchemaCollection = New XmlSchemaCollection
            schemacoll.Add(Nothing, "http://localhost/roboservice/users.xsd")
            Dim valreader As XmlValidatingReader = New XmlValidatingReader(reader)
            valreader.ValidationType = ValidationType.Schema
            valreader.Schemas.Add(schemacoll)
            Do While (valreader.Read())
                If (valreader.LocalName.Equals("UserName")) Then
                    usernamefild(usernamecounter) = valreader.ReadString()
                    usernamecounter = usernamecounter + 1
                ElseIf (valreader.LocalName.Equals("Password")) Then
                    passwordfild(passwordcounter) = valreader.ReadString()
                    passwordcounter = passwordcounter + 1
                ElseIf (valreader.LocalName.Equals("Name")) Then
                    namefild(namecounter) = valreader.ReadString()
                    namecounter = namecounter + 1
                ElseIf (valreader.LocalName.Equals("LastName")) Then
                    lastnamefild(lastnamecounter) = valreader.ReadString()
                    lastnamecounter = lastnamecounter + 1
                ElseIf (valreader.LocalName.Equals("Email")) Then
                    emailfild(emailcounter) = valreader.ReadString()
                    emailcounter = emailcounter + 1
                ElseIf (valreader.LocalName.Equals("Access")) Then
                    accessfild(accesscounter) = valreader.ReadString()
                    accesscounter = accesscounter + 1
                End If
            Loop
            valreader.Close()
            reader.Close()
            stream.Close()

        Catch ex As Exception

            emptyfile = True

        End Try
        ' READING XML BANK FINISHED
        If (emptyfile = False) Then
            Dim i As Integer
            For i = 0 To usernamecounter - 1 Step 1
                Try

                    If ((username.CompareTo(usernamefild(i)) = 0) And (password.CompareTo(passwordfild(i)) = 0)) Then
                        If (accessfild(i).CompareTo("1") = 0) Then
                            If (Convert.ToInt32(Application("useraccess")) = 0) Then
                                'thread = New Threading.Thread(Sendzero)
                                Dim tempkey As String
                                tempkey = random.Next(99999).ToString()
                                Application.Add("mainkey", tempkey)
                                Application.Add("key", tempkey)
                                Application.Remove("useraccess")
                                Application.Add("useraccess", 1) 
                                Application.Remove("username")
                                Application.Add("username", username)
                                If (username.CompareTo("Administrator") = 0) Then
                                    Return Convert.ToString(Application("key")) + "#" + Convert.ToString(Application("newuser"))
                                Else
                                    Return Convert.ToString(Application("key"))
                                End If
                            ElseIf (username.CompareTo("Administrator") = 0) Then
                                ' GETTING CONTROL BY ADMIN
                                Dim tempkey As String
                                tempkey = random.Next(99999).ToString()
                                Application.Remove("mainkey")
                                Application.Add("mainkey", tempkey)
                                Application.Remove("key")
                                Application.Add("key", tempkey)
                                Application.Remove("useraccess")
                                Application.Add("useraccess", 1) 
                                Application.Remove("username")
                                Application.Add("username", username)
                                ' SEND ZERO TO STOP
                                Out(888, 0)
                                Return Convert.ToString(Application("key")) + "#" + Convert.ToString(Application("newuser"))
                            Else
                                Return "Divice is being used by another user !!!"
                            End If
                        Else
                            Return "You haven't Permission !!!"
                        End If
                    End If

                Catch ex As Exception

                End Try

            Next i
            Return "Invalid username or password"
        End If
        Return "XML file error !!!"

    End Function

    <WebMethod(EnableSession:=True)> _
    Public Function Signin(ByVal username As String, ByVal password As String, ByVal name As String, _
                           ByVal lastname As String, ByVal email As String) As Integer
        ' SRART READEING FROM XML BANK
        reset()
        Try
            Dim stream As StreamReader = New StreamReader(Server.MapPath("XML/userinfo.xml"))
            Dim reader As XmlTextReader = New XmlTextReader(stream)
            Dim schemacoll As XmlSchemaCollection = New XmlSchemaCollection
            schemacoll.Add(Nothing, "http://localhost/roboservice/users.xsd")
            Dim valreader As XmlValidatingReader = New XmlValidatingReader(reader)
            valreader.ValidationType = ValidationType.Schema
            valreader.Schemas.Add(schemacoll)
            Do While (valreader.Read())
                If (valreader.LocalName.Equals("UserName")) Then
                    usernamefild(usernamecounter) = valreader.ReadString()
                    usernamecounter = usernamecounter + 1
                ElseIf (valreader.LocalName.Equals("Password")) Then
                    passwordfild(passwordcounter) = valreader.ReadString()
                    passwordcounter = passwordcounter + 1
                ElseIf (valreader.LocalName.Equals("Name")) Then
                    namefild(namecounter) = valreader.ReadString()
                    namecounter = namecounter + 1
                ElseIf (valreader.LocalName.Equals("LastName")) Then
                    lastnamefild(lastnamecounter) = valreader.ReadString()
                    lastnamecounter = lastnamecounter + 1
                ElseIf (valreader.LocalName.Equals("Email")) Then
                    emailfild(emailcounter) = valreader.ReadString()
                    emailcounter = emailcounter + 1
                ElseIf (valreader.LocalName.Equals("Access")) Then
                    accessfild(accesscounter) = valreader.ReadString()
                    accesscounter = accesscounter + 1
                End If
            Loop
            valreader.Close()
            reader.Close()
            stream.Close()
        Catch ex As Exception

            emptyfile = True

            
        End Try
        ' READING XML BANK FINISHED
        ' CHECKING USERNAME
        Dim j As Integer
        If (usernamecounter > 0) Then
            For j = 0 To usernamecounter - 1 Step 1
                If (usernamefild(j).CompareTo(username) = 0) Then
                    Return 2 
                End If
            Next j
        End If
        ' USRNAME CHECKED
        ' START INSERTING NEW DATA
        Dim writer As XmlTextWriter = New XmlTextWriter(Server.MapPath("XML/userinfo.xml"), Nothing)
        Try
            writer.Formatting = Formatting.Indented
            writer.WriteStartDocument()
            writer.WriteStartElement("Users") 
            writer.WriteAttributeString("xmlns", Nothing, "http://localhost/roboservice/users.xsd")
            writer.WriteStartElement("UserName")
            writer.WriteString(username)
            writer.WriteEndElement()
            writer.WriteStartElement("Password")
            writer.WriteString(password)
            writer.WriteEndElement()

            writer.WriteStartElement("UserInfo") 
            writer.WriteStartElement("Name")
            writer.WriteString(name)
            writer.WriteEndElement()
            writer.WriteStartElement("LastName")
            writer.WriteString(lastname)
            writer.WriteEndElement()
            writer.WriteStartElement("Email")
            writer.WriteString(email)
            writer.WriteEndElement()
            writer.WriteStartElement("Access")
            If (username.CompareTo("Administrator") = 0) Then
                writer.WriteString("1")
            Else
                writer.WriteString("0") 
            End If
            writer.WriteEndElement()
            writer.WriteEndElement()  
            ' NEW DATA INSERTED
        Catch ex As Exception

            Return 0 

        End Try
        If (emptyfile = False) Then
            Dim i As Integer
            For i = 0 To usernamecounter - 1 Step 1
                writer.WriteStartElement("UserName")
                writer.WriteString(usernamefild(i).ToString())
                writer.WriteEndElement()
                writer.WriteStartElement("Password")
                writer.WriteString(passwordfild(i).ToString())
                writer.WriteEndElement()

                writer.WriteStartElement("UserInfo")  
                writer.WriteStartElement("Name")
                writer.WriteString(namefild(i).ToString())
                writer.WriteEndElement()
                writer.WriteStartElement("LastName")
                writer.WriteString(lastnamefild(i).ToString())
                writer.WriteEndElement()
                writer.WriteStartElement("Email")
                writer.WriteString(emailfild(i).ToString())
                writer.WriteEndElement()
                writer.WriteStartElement("Access")
                writer.WriteString(accessfild(i).ToString())
                writer.WriteEndElement()
                writer.WriteEndElement()  
            Next i
        End If
        writer.WriteEndElement()  
        writer.WriteEndDocument()
        writer.Close()
        emptyfile = False
        reset()
        Addnewuser()
        Return 1
    End Function

    <WebMethod(enablesession:=True)> _
    Public Function Access(ByVal nowkey As Integer, ByVal nextkey As Integer, _
                           ByVal username As String, ByVal useraccess As Integer) As Integer
        If ((Convert.ToInt32(Application("key")) = nowkey) And (Convert.ToInt32(Application("useraccess")) = 1)) Then
            Application.Remove("key")
            Application.Add("key", nextkey)
            If (Application("username").CompareTo("Administrator") = 0) Then
                Dim result As Integer
                result = Changeuseraccess(username, useraccess)
                If result = 1 Then
                    Return 1
                Else
                    Return 0
                End If
            End If
        End If
        Return 3
    End Function

    <WebMethod(enablesession:=True)> _
    Public Function Delete(ByVal nowkey As Integer, ByVal nextkey As Integer, _
                           ByVal username As String) As Integer
        If ((Convert.ToInt32(Application("key")) = nowkey) And (Convert.ToInt32(Application("useraccess")) = 1)) Then
            Application.Remove("key")
            Application.Add("key", nextkey)
            If (Application("username").CompareTo("Administrator") = 0) Then
                Dim result As Integer
                result = Deleteuser(username)
                If result = 1 Then
                    Return 1
                Else
                    Return 0
                End If
            End If
        End If
        Return 3
    End Function

    <WebMethod(enablesession:=True)> _
    Public Function Report(ByVal nowkey As Integer, ByVal nextkey As Integer, _
                           ByVal access As Integer) As String
        If ((Convert.ToInt32(Application("key")) = nowkey) And (Convert.ToInt32(Application("useraccess")) = 1)) Then
            Application.Remove("key")
            Application.Add("key", nextkey)
            If (Application("username").CompareTo("Administrator") = 0) Then
                Dim result As String
                result = Sortuserbyaccess(access)
                Return result
            End If
        End If
        Return "You haven't permossion !!!"
    End Function

    <WebMethod(enablesession:=True)> _
   Public Function Userinformation(ByVal nowkey As Integer, ByVal nextkey As Integer, _
                          ByVal username As String) As String
        If ((Convert.ToInt32(Application("key")) = nowkey) And (Convert.ToInt32(Application("useraccess")) = 1)) Then
            Application.Remove("key")
            Application.Add("key", nextkey)
            If (Application("username").CompareTo("Administrator") = 0) Then
                Dim result As String
                result = Getuserinformation(username)
                Return result
            End If
        End If
        Return "You haven't permossion !!!"
    End Function

    <WebMethod(EnableSession:=True)> _
    Public Function Command(ByVal nowkey As Integer, ByVal nextkey As Integer, _
                            ByVal value As String) As Integer
        If ((Convert.ToInt32(Application("key")) = nowkey) And (Convert.ToInt32(Application("useraccess")) = 1)) Then
            Application.Remove("key")
            Application.Add("key", nextkey)
            Select Case value
                Case "f"
                    Out(888, 1)
                    Return 1
                Case "b"
                    Out(888, 2)
                    Return 1
                Case "r"
                    Out(888, 4)
                    Return 1
                Case "l"
                    Out(888, 8)
                    Return 1
                Case "fr"
                    Out(888, 5)
                    Return 1
                Case "fl"
                    Out(888, 9)
                    Return 1
                Case "br"
                    Out(888, 6)
                    Return 1
                Case "bl"
                    Out(888, 10)
                    Return 1
                Case "s"
                    Out(888, 0)
                    Application.Remove("key")
                    Application.Add("key", Application("mainkey")) ' <-- set key with first key (mainkey)
                    Return 1 
            End Select
            Return 0 ' <-- invalid command
        Else
            Return 3 ' <-- haven't permissoin
        End If
    End Function

    <WebMethod(EnableSession:=True)> _
   Public Function Disconnect(ByVal nowkey As Integer) As Integer
        If ((Convert.ToInt32(Application("key")) = nowkey) And (Convert.ToInt32(Application("useraccess")) = 1)) Then
            If (Convert.ToString(Application("username")).CompareTo("Administrator") = 0) Then
                Subnewuser()
            End If
            Application.Remove("mainkey")
            Application.Remove("key")
            Application.Remove("username")
            Application.Remove("name")
            Application.Remove("lastname")
            Application.Remove("useraccess")
            Application.Add("useraccess", "0")
            Return 1
        Else
            Return 0
        End If
    End Function

    <WebMethod(EnableSession:=True)> _
  Public Function key() As Integer
        Return Convert.ToInt32(Application("key"))
    End Function

    <WebMethod(EnableSession:=True)> _
    Private Function Changeuseraccess(ByVal username As String, ByVal useraccess As Integer) As Integer
        ' SRART READEING FROM XML BANK
        reset()
        Try
            Dim stream As StreamReader = New StreamReader(Server.MapPath("XML/userinfo.xml"))
            Dim reader As XmlTextReader = New XmlTextReader(stream)
            Dim schemacoll As XmlSchemaCollection = New XmlSchemaCollection
            schemacoll.Add(Nothing, "http://localhost/roboservice/users.xsd")
            Dim valreader As XmlValidatingReader = New XmlValidatingReader(reader)
            valreader.ValidationType = ValidationType.Schema
            valreader.Schemas.Add(schemacoll)
            Do While (valreader.Read())
                If (valreader.LocalName.Equals("UserName")) Then
                    usernamefild(usernamecounter) = valreader.ReadString()
                    usernamecounter = usernamecounter + 1
                ElseIf (valreader.LocalName.Equals("Password")) Then
                    passwordfild(passwordcounter) = valreader.ReadString()
                    passwordcounter = passwordcounter + 1
                ElseIf (valreader.LocalName.Equals("Name")) Then
                    namefild(namecounter) = valreader.ReadString()
                    namecounter = namecounter + 1
                ElseIf (valreader.LocalName.Equals("LastName")) Then
                    lastnamefild(lastnamecounter) = valreader.ReadString()
                    lastnamecounter = lastnamecounter + 1
                ElseIf (valreader.LocalName.Equals("Email")) Then
                    emailfild(emailcounter) = valreader.ReadString()
                    emailcounter = emailcounter + 1
                ElseIf (valreader.LocalName.Equals("Access")) Then
                    accessfild(accesscounter) = valreader.ReadString()
                    accesscounter = accesscounter + 1
                End If
            Loop
            valreader.Close()
            reader.Close()
            stream.Close()
        Catch ex As Exception

            emptyfile = True

        End Try
        ' READING XML BANK FINISHED
        If (emptyfile = False) Then
            ' START WRITING DATA
            Dim writer As XmlTextWriter = New XmlTextWriter(Server.MapPath("XML/userinfo.xml"), Nothing)
            writer.Formatting = Formatting.Indented
            writer.WriteStartDocument()
            writer.WriteStartElement("Users") 
            writer.WriteAttributeString("xmlns", Nothing, "http://localhost/roboservice/users.xsd")
            Dim i As Integer
            For i = 0 To usernamecounter - 1 Step 1
                writer.WriteStartElement("UserName")
                writer.WriteString(usernamefild(i).ToString())
                writer.WriteEndElement()
                writer.WriteStartElement("Password")
                writer.WriteString(passwordfild(i).ToString())
                writer.WriteEndElement()

                writer.WriteStartElement("UserInfo")  
                writer.WriteStartElement("Name")
                writer.WriteString(namefild(i).ToString())
                writer.WriteEndElement()
                writer.WriteStartElement("LastName")
                writer.WriteString(lastnamefild(i).ToString())
                writer.WriteEndElement()
                writer.WriteStartElement("Email")
                writer.WriteString(emailfild(i).ToString())
                writer.WriteEndElement()
                writer.WriteStartElement("Access")
                If (username.CompareTo(usernamefild(i)) = 0) Then
                    writer.WriteString(useraccess)
                Else
                    writer.WriteString(accessfild(i).ToString())
                End If
                writer.WriteEndElement()
                writer.WriteEndElement()  
            Next i
            writer.WriteEndElement()  
            writer.WriteEndDocument()
            writer.Close()
            ' WRITING FINISHED
        Else
            Return 0
        End If
        emptyfile = False
        reset()
        Return 1 
    End Function

    <WebMethod(EnableSession:=True)> _
    Private Function Deleteuser(ByVal username As String) As Integer
        ' SRART READEING FROM XML BANK
        reset()
        Try
            Dim stream As StreamReader = New StreamReader(Server.MapPath("XML/userinfo.xml"))
            Dim reader As XmlTextReader = New XmlTextReader(stream)
            Dim schemacoll As XmlSchemaCollection = New XmlSchemaCollection
            schemacoll.Add(Nothing, "http://localhost/roboservice/users.xsd")
            Dim valreader As XmlValidatingReader = New XmlValidatingReader(reader)
            valreader.ValidationType = ValidationType.Schema
            valreader.Schemas.Add(schemacoll)
            Do While (valreader.Read())
                If (valreader.LocalName.Equals("UserName")) Then
                    usernamefild(usernamecounter) = valreader.ReadString()
                    usernamecounter = usernamecounter + 1
                ElseIf (valreader.LocalName.Equals("Password")) Then
                    passwordfild(passwordcounter) = valreader.ReadString()
                    passwordcounter = passwordcounter + 1
                ElseIf (valreader.LocalName.Equals("Name")) Then
                    namefild(namecounter) = valreader.ReadString()
                    namecounter = namecounter + 1
                ElseIf (valreader.LocalName.Equals("LastName")) Then
                    lastnamefild(lastnamecounter) = valreader.ReadString()
                    lastnamecounter = lastnamecounter + 1
                ElseIf (valreader.LocalName.Equals("Email")) Then
                    emailfild(emailcounter) = valreader.ReadString()
                    emailcounter = emailcounter + 1
                ElseIf (valreader.LocalName.Equals("Access")) Then
                    accessfild(accesscounter) = valreader.ReadString()
                    accesscounter = accesscounter + 1
                End If
            Loop
            valreader.Close()
            reader.Close()
            stream.Close()
        Catch ex As Exception

            emptyfile = True

        End Try
        ' READING XML BANK FINISHED
        If (emptyfile = False) Then
            ' START WRITING DATA
            Dim writer As XmlTextWriter = New XmlTextWriter(Server.MapPath("XML/userinfo.xml"), Nothing)
            writer.Formatting = Formatting.Indented
            writer.WriteStartDocument()
            writer.WriteStartElement("Users") 
            writer.WriteAttributeString("xmlns", Nothing, "http://localhost/roboservice/users.xsd")
            Dim i As Integer
            For i = 0 To usernamecounter - 1 Step 1
                If (username.CompareTo(usernamefild(i)).ToString() <> 0) Then
                    writer.WriteStartElement("UserName")
                    writer.WriteString(usernamefild(i).ToString())
                    writer.WriteEndElement()
                    writer.WriteStartElement("Password")
                    writer.WriteString(passwordfild(i).ToString())
                    writer.WriteEndElement()

                    writer.WriteStartElement("UserInfo")  
                    writer.WriteStartElement("Name")
                    writer.WriteString(namefild(i).ToString())
                    writer.WriteEndElement()
                    writer.WriteStartElement("LastName")
                    writer.WriteString(lastnamefild(i).ToString())
                    writer.WriteEndElement()
                    writer.WriteStartElement("Email")
                    writer.WriteString(emailfild(i).ToString())
                    writer.WriteEndElement()
                    writer.WriteStartElement("Access")
                    writer.WriteString(accessfild(i).ToString())
                    writer.WriteEndElement()
                    writer.WriteEndElement()  
                Else
                    Nextuser()
                End If

            Next i
            writer.WriteEndElement()  
            writer.WriteEndDocument()
            writer.Close()
            ' WRITING FINISHED
        Else
            Return 0
        End If
        emptyfile = False
        reset()
        Return 1 
    End Function

    <WebMethod(EnableSession:=True)> _
    Private Function Getuserinformation(ByVal username As String) As String
        ' SRART READEING FROM XML BANK
        reset()
        Try
            Dim stream As StreamReader = New StreamReader(Server.MapPath("XML/userinfo.xml"))
            Dim reader As XmlTextReader = New XmlTextReader(stream)
            Dim schemacoll As XmlSchemaCollection = New XmlSchemaCollection
            schemacoll.Add(Nothing, "http://localhost/roboservice/users.xsd")
            Dim valreader As XmlValidatingReader = New XmlValidatingReader(reader)
            valreader.ValidationType = ValidationType.Schema
            valreader.Schemas.Add(schemacoll)
            Do While (valreader.Read())
                If (valreader.LocalName.Equals("UserName")) Then
                    usernamefild(usernamecounter) = valreader.ReadString()
                    usernamecounter = usernamecounter + 1
                ElseIf (valreader.LocalName.Equals("Password")) Then
                    passwordfild(passwordcounter) = valreader.ReadString()
                    passwordcounter = passwordcounter + 1
                ElseIf (valreader.LocalName.Equals("Name")) Then
                    namefild(namecounter) = valreader.ReadString()
                    namecounter = namecounter + 1
                ElseIf (valreader.LocalName.Equals("LastName")) Then
                    lastnamefild(lastnamecounter) = valreader.ReadString()
                    lastnamecounter = lastnamecounter + 1
                ElseIf (valreader.LocalName.Equals("Email")) Then
                    emailfild(emailcounter) = valreader.ReadString()
                    emailcounter = emailcounter + 1
                ElseIf (valreader.LocalName.Equals("Access")) Then
                    accessfild(accesscounter) = valreader.ReadString()
                    accesscounter = accesscounter + 1
                End If
            Loop
            valreader.Close()
            reader.Close()
            stream.Close()
        Catch ex As Exception

            emptyfile = True

        End Try
        ' READING XML BANK FINISHED
        If (emptyfile = False) Then
            Dim i As Integer
            For i = 0 To usernamecounter - 1 Step 1
                If (username.CompareTo(usernamefild(i)).ToString() = 0) Then
                    Dim information As String
                    information = (usernamefild(i).ToString()) + ";" + _
                    (passwordfild(i).ToString()) + ";" + _
                    (namefild(i).ToString()) + ";" + _
                    (lastnamefild(i).ToString()) + ";" + _
                    (emailfild(i).ToString()) + ";" + _
                    (accessfild(i).ToString()) + ";"
                    emptyfile = False
                    reset()
                    Return information
                Else
                    Nextuser()
                End If

            Next i
        Else
            Return "Not found !!!"
        End If
    End Function

    <WebMethod(EnableSession:=True)> _
    Private Function Sortuserbyaccess(ByVal access2 As Integer) As String
        ' SRART READEING FROM XML BANK
        reset()
        Try
            Dim stream As StreamReader = New StreamReader(Server.MapPath("XML/userinfo.xml"))
            Dim reader As XmlTextReader = New XmlTextReader(stream)
            Dim schemacoll As XmlSchemaCollection = New XmlSchemaCollection
            schemacoll.Add(Nothing, "http://localhost/roboservice/users.xsd")
            Dim valreader As XmlValidatingReader = New XmlValidatingReader(reader)
            valreader.ValidationType = ValidationType.Schema
            valreader.Schemas.Add(schemacoll)
            Do While (valreader.Read())
                If (valreader.LocalName.Equals("UserName")) Then
                    usernamefild(usernamecounter) = valreader.ReadString()
                    usernamecounter = usernamecounter + 1
                ElseIf (valreader.LocalName.Equals("Password")) Then
                    passwordfild(passwordcounter) = valreader.ReadString()
                    passwordcounter = passwordcounter + 1
                ElseIf (valreader.LocalName.Equals("Name")) Then
                    namefild(namecounter) = valreader.ReadString()
                    namecounter = namecounter + 1
                ElseIf (valreader.LocalName.Equals("LastName")) Then
                    lastnamefild(lastnamecounter) = valreader.ReadString()
                    lastnamecounter = lastnamecounter + 1
                ElseIf (valreader.LocalName.Equals("Email")) Then
                    emailfild(emailcounter) = valreader.ReadString()
                    emailcounter = emailcounter + 1
                ElseIf (valreader.LocalName.Equals("Access")) Then
                    accessfild(accesscounter) = valreader.ReadString()
                    accesscounter = accesscounter + 1
                End If
            Loop
            valreader.Close()
            reader.Close()
            stream.Close()
        Catch ex As Exception

            emptyfile = True

        End Try
        ' READING XML BANK FINISHED
        Dim usernames As String = Nothing
        If (emptyfile = False) Then
            Dim i As Integer
            For i = 0 To usernamecounter - 1 Step 1
                If (access2 = Convert.ToInt32(accessfild(i))) Then
                    usernames += (usernamefild(i).ToString()) + ";"
                Else
                    Nextuser()
                End If
            Next i
        Else
            Return "No body !!!"
        End If
        emptyfile = False
        reset()
        If (usernames = Nothing) Then
            Return "No body !!!"
        Else
            Return usernames
        End If
    End Function

    <WebMethod(EnableSession:=True)> _
    Public Function Sendzero() 
        If (sleep) Then
            thread.Sleep(10000)
        Else
            thread.ResetAbort()
        End If
    End Function

    Private Function Addnewuser()
        Dim newusercounter As Integer
        Try
            newusercounter = Convert.ToInt32(Application("newuser"))
            newusercounter += 1
            Application.Remove("newuser")
            Application.Add("newuser", newusercounter)
        Catch ex As Exception

            Application.Remove("newuser")
            Application.Add("newuser", 1)

        End Try
    End Function

    Private Function Subnewuser()
        Application.Remove("newuser")
        Application.Add("newuser", "0")
    End Function

    '-----------------------
    ' RESET THE XML FILE VARIABLES
    Private Function reset()
        Dim i As Integer
        For i = 0 To 20 Step 1
            usernamefild(i) = Nothing
            passwordfild(i) = Nothing
            namefild(i) = Nothing
            lastnamefild(i) = Nothing
            emailfild(i) = Nothing
            accessfild(i) = Nothing
        Next i
        usernamecounter = 0
        passwordcounter = 0
        namecounter = 0
        lastnamecounter = 0
        emailcounter = 0
        accesscounter = 0
    End Function

    '--------------------------
    ' JUMP TO NEXT USER
    Private Function Nextuser()
        usernamecounter += 1
        passwordcounter += 1
        namecounter += 1
        lastnamecounter += 1
        emailcounter += 1
        accesscounter += 1
    End Function

End Class
