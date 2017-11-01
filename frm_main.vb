
Imports CefSharp
Imports CefSharp.WinForms




Public Class frm_main
    Inherits Form
    Public Sub New()
        Try
            InitializeComponent()


            Dim settings As New CefSettings()

            CefSharp.Cef.Initialize(settings)

            chrome = New ChromiumWebBrowser("http://timeseducate.com/login/") With {
    .Dock = DockStyle.Fill
                }
            Dim life As New LifespanHandler()
            chrome.LifeSpanHandler = life
            AddHandler life.popup_request, AddressOf life_popup_request
            pan_container.Controls.Add(chrome)


            'popup browser
            chrome_popup = New ChromiumWebBrowser("")
            Me.pan_container_popup.Controls.Add(chrome_popup)

            chrome_popup.Dock = DockStyle.Fill
        Catch ex As Exception

        End Try
    End Sub

    'variable browser
    Private chrome As ChromiumWebBrowser, chrome_popup As ChromiumWebBrowser




    Private Sub carregar_popup_new_browser(url As String)
        'open pop up in second browser
        chrome_popup.Load(url)

        'chrome_popup = new ChromiumWebBrowser(url);
        'this.Invoke((MethodInvoker)delegate()
        '{
        '    this.pan_container_popup.Controls.Clear();
        '    this.pan_container_popup.Controls.Add(chrome_popup);

        '});
        'chrome_popup.Dock = DockStyle.Fill;

    End Sub

    Private Sub frm_main_FormClosing(sender As Object, e As FormClosingEventArgs)
        'close o object cef
        CefSharp.Cef.Shutdown()
        Application.[Exit]()
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs)

    End Sub

#Region "life_popup_request(string obj)"
    Private Sub life_popup_request(obj As String)
        'function for open pop up in a new browser
        Me.carregar_popup_new_browser(obj)
    End Sub
#End Region


End Class
