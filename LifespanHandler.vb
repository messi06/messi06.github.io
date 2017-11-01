Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports CefSharp
Imports CefSharp.WinForms

Public Class LifespanHandler
        Implements ILifeSpanHandler
        'event that receive url popup
        Public Event popup_request As Action(Of String)

        Private Function ILifeSpanHandler_OnBeforePopup(browserControl As IWebBrowser, browser As IBrowser, frame As IFrame, targetUrl As String, targetFrameName As String, targetDisposition As WindowOpenDisposition,
            userGesture As Boolean, popupFeatures As IPopupFeatures, windowInfo As IWindowInfo, browserSettings As IBrowserSettings, ByRef noJavascriptAccess As Boolean, ByRef newBrowser As IWebBrowser) As Boolean Implements ILifeSpanHandler.OnBeforePopup
            'get url popup
            RaiseEvent popup_request(targetUrl)

            'stop open popup
            newBrowser = Nothing
            Return True
        End Function

        ''' </summary>
        ''' <param name="browserControl">The <see cref="IWebBrowser"/> control that is realted to the window is closing.</param>
        ''' <param name="browser">The browser instance - check if IsDisposed as it's possible when the browser is disposing</param>
        ''' <returns>For default behaviour return false</returns>
        Private Function ILifeSpanHandler_DoClose(browserControl As IWebBrowser, browser As IBrowser) As Boolean Implements ILifeSpanHandler.DoClose
            Return False
        End Function

        ''' <summary>
        ''' Called before a CefBrowser window (either the main browser for <see cref="IWebBrowser"/>, 
        ''' or one of its children)
        ''' </summary>
        ''' <param name="browserControl">The <see cref="IWebBrowser"/> control that is realted to the window is closing.</param>
        ''' <param name="browser">The browser instance</param>
        Private Sub ILifeSpanHandler_OnBeforeClose(browserControl As IWebBrowser, browser As IBrowser) Implements ILifeSpanHandler.OnBeforeClose
        End Sub

        ''' <summary>
        ''' Called after a new browser is created.
        ''' </summary>
        ''' <param name="browserControl">The <see cref="IWebBrowser"/> control that is realted to the window is closing.</param>
        ''' <param name="browser">The browser instance</param>
        Private Sub ILifeSpanHandler_OnAfterCreated(browserControl As IWebBrowser, browser As IBrowser) Implements ILifeSpanHandler.OnAfterCreated
        End Sub
    End Class

